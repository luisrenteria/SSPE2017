﻿using SSP.Servidor;
using SSP.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data.Objects.SqlClient;
using System.Linq.Expressions;


namespace SSP.Controlador.Catalogo.Justicia
{
    public class cEventoIngreso : EntityManagerServer<EVENTO_INGRESO>
    {
        /// <summary>
        /// constructor de la clase
        /// </summary>
        public cEventoIngreso()
        { }

        /// <summary>
        /// metodo que conecta con la base de datos para extraer todos los registros
        /// </summary>
        /// <returns>listado de tipo "FUERO"</returns>
        public IQueryable<EVENTO_INGRESO> ObtenerTodos()
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
        public IQueryable<EVENTO_INGRESO> Obtener(int Id)
        {
            try
            {
                return GetData().Where(w => w.ID_EVENTO == Id);
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
        public bool Insertar(EVENTO_INGRESO Entity)
        {
            try
            {
                if (Insert(Entity))
                    return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return false;
        }

        public bool Insertar(List<EVENTO_INGRESO> Entity, int Id)
        {
            try
            {
                if (Eliminar(Id))
                {
                    if (Entity.Count == 0)
                        return true;
                    else
                        if (Insert(Entity))
                            return true;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// metodo que se conecta a la base de datos para actualizar un registro
        /// </summary>
        /// <param name="Entity">objeto de tipo "FUERO" con valores a actualizar</param>
        public bool Actualizar(EVENTO_INGRESO Entity)
        {
            try
            {
                if(Update(Entity))
                    return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("part of the object's key information"))
                    throw new ApplicationException("La llave principal no se puede cambiar");
                else
                    throw new ApplicationException(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// metodo que se conecta a la base de datos para eliminar un registro
        /// </summary>
        /// <param name="Id">valor de la llave primaria para obtener registro</param>
        /// <returns>"True" para eliminado, "False" para no encontrado</returns>
        public bool Eliminar(EVENTO_INGRESO Entity)
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


        public bool Eliminar(int Id)
        {
            try
            {
                var list = GetData().Where(x => x.ID_EVENTO == Id);
                if (list != null)
                {
                    foreach (var l in list)
                    {
                        if (!Delete(l))
                            return false;
                    }
                }

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
            return true;
        }
    }
}