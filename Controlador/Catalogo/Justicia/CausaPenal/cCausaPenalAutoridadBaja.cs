﻿using SSP.Servidor;
using SSP.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Data.Objects.SqlClient;
using LinqKit;

namespace SSP.Controlador.Catalogo.Justicia
{
    public class cCausaPenalAutoridadBaja : EntityManagerServer<CAUSA_PENAL_AUTORIDAD_BAJA>
    {
        /// <summary>
        /// constructor de la clase
        /// </summary>
        public cCausaPenalAutoridadBaja()
        { }

        /// <summary>
        /// metodo que conecta con la base de datos para extraer todos los registros
        /// </summary>
        /// <returns>listado de tipo "DECOMISO"</returns>
        public IQueryable<CAUSA_PENAL_AUTORIDAD_BAJA> ObtenerTodos()
        {
            try
            {
                return GetData().OrderBy(w => w.NOMBRE);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        /// <summary>
        /// metodo que se conectara a la base de datos para regresar un registro 
        /// </summary>
        /// <
        /// name="Id">valor de la llave primaria para obtener registro</param>
        /// <returns>objeto de tipo "DECOMISO"</returns>
        public IQueryable<CAUSA_PENAL_AUTORIDAD_BAJA> Obtener(int Id)
        {
            try
            {
                return GetData().Where(w => w.ID_AUTO_BAJA == Id);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }


        /// <summary>
        /// metodo que se conecta a la base de datos para insertar un registro nuevo
        /// </summary>
        /// <param name="Entity">objeto de tipo "DECOMISO" con valores a insertar</param>
        public short Insertar(CAUSA_PENAL_AUTORIDAD_BAJA Entity)
        {
            try
            {
                Entity.ID_AUTO_BAJA = GetIDProceso<short>("CAUSA_PENAL_AUTORIDAD_BAJA", "ID_AUTO_BAJA", "1=1");
                if (Insert(Entity))
                    return Entity.ID_AUTO_BAJA;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return 0;
        }

        /// <summary>
        /// metodo que se conecta a la base de datos para actualizar un registro
        /// </summary>
        /// <param name="Entity">objeto de tipo "DECOMISO" con valores a actualizar</param>
        public bool Actualizar(CAUSA_PENAL_AUTORIDAD_BAJA Entity)
        {
            try
            {
                if (Update(Entity))
                    return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return false;
        }
      
    }
}