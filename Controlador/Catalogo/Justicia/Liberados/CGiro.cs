﻿using SSP.Servidor;
using SSP.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data.Objects.SqlClient;
using System.Linq.Expressions;
using LinqKit;
using System.Transactions;
using System.Data;


namespace SSP.Controlador.Catalogo.Justicia
{
    public class cGiro : EntityManagerServer<GIRO>
    {
        /// <summary>
        /// constructor de la clase
        /// </summary>
        public cGiro()
        { }

        /// <summary>
        /// metodo que conecta con la base de datos para extraer todos los registros
        /// </summary>
        /// <returns>listado de tipo "FUERO"</returns>
        public IQueryable<GIRO> ObtenerTodos()
        {
            try
            {
                return GetData();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        /// <summary>
        /// metodo que se conectara a la base de datos para regresar un registro 
        /// </summary>
        /// <param name="Id">valor de la llave primaria para obtener registro</param>
        /// <returns>objeto de tipo "FUERO"</returns>
        public GIRO Obtener(short? Id = null)
        {
            try
            {
                var predicate = PredicateBuilder.True<GIRO>();
                if (Id.HasValue)
                    predicate = predicate.And(w => w.ID_GIRO == Id);
                return GetData(predicate.Expand()).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        /// <summary>
        /// metodo que se conecta a la base de datos para insertar un registro nuevo
        /// </summary>
        /// <param name="Entity">objeto de tipo "FUERO" con valores a insertar</param>
        public decimal Insertar(GIRO Entity)
        {
            try
            {
                using (TransactionScope transaccion = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted }))
                {
                    Entity.ID_GIRO = GetIDProceso<short>("GIRO", "ID_GIRO", "1 = 1");
                    Context.GIRO.Add(Entity);
                    Context.SaveChanges();
                    transaccion.Complete();
                    return Entity.ID_GIRO;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        /// <summary>
        /// metodo que se conecta a la base de datos para actualizar un registro
        /// </summary>
        /// <param name="Entity">objeto de tipo "FUERO" con valores a actualizar</param>
        public bool Actualizar(GIRO Entity)
        {
            try
            {
                using (TransactionScope transaccion = new TransactionScope(TransactionScopeOption.RequiresNew, new TransactionOptions() { IsolationLevel = System.Transactions.IsolationLevel.ReadCommitted }))
                {
                    Context.Entry(Entity).State = EntityState.Modified;
                    Context.SaveChanges();
                    transaccion.Complete();
                    return true;
                }
            }
            catch (Exception ex)
            {
               throw new ApplicationException(ex.Message);
            }
        }

        /// <summary>
        /// metodo que se conecta a la base de datos para eliminar un registro
        /// </summary>
        /// <param name="Id">valor de la llave primaria para obtener registro</param>
        /// <returns>"True" para eliminado, "False" para no encontrado</returns>
        public bool Eliminar(GIRO Entity)
        {
            try
            {
                    return Delete(Entity);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    if (ex.InnerException.InnerException.Message.Contains("child record found") || ex.InnerException.InnerException.Message.Contains("registro secundario encontrado"))
                        throw new ApplicationException("Este registro se encuentra ligado a otro registro, por lo tanto no se puede eliminar");
                }
                throw new ApplicationException(ex.Message + " " + (ex.InnerException != null ? ex.InnerException.InnerException.Message : ""));
            }
        }
        
    }
}