﻿using SSP.Servidor;
using SSP.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace SSP.Controlador.Catalogo.Justicia
{
    public class cTipoDisposicion : EntityManagerServer<TIPO_DISPOSICION>
    {
        /// <summary>
        /// constructor de la clase
        /// </summary>
        public cTipoDisposicion()
        { }

        /// <summary>
        /// metodo que conecta con la base de datos para extraer todos los registros
        /// </summary>
        /// <returns>listado de tipo "TIPO_DISPOSICION"</returns>
        public IQueryable<TIPO_DISPOSICION> ObtenerTodos(string buscar = "")
        {
            try
            {
                if (string.IsNullOrEmpty(buscar))
                    return GetData().OrderBy(x => x.ID_DISPOSICION);
                else
                    return GetData().Where(w => w.DESCR.Contains(buscar));
            }
            catch(Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        /// <summary>
        /// metodo que se conectara a la base de datos para regresar un registro 
        /// </summary>
        /// <param name="Id">valor de la llave primaria para obtener registro</param>
        /// <returns>objeto de tipo "TIPO_DISPOSICION"</returns>
        public List<TIPO_DISPOSICION> Obtener(int Id)
        {
            var Resultado = new List<TIPO_DISPOSICION>();
            try
            {
                Resultado = GetData().Where(w => w.ID_DISPOSICION == Id).ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return Resultado;
        }

        /// <summary>
        /// metodo que se conecta a la base de datos para insertar un registro nuevo
        /// </summary>
        /// <param name="Entity">objeto de tipo "TIPO_AUTORIDAD_INTERNA" con valores a insertar</param>
        public void Insertar(TIPO_DISPOSICION Entity)
        {
            try
            {
                //Entity.ID_ESTADO_CIVIL = GetSequence<short>("ESTADO_CIVIL_SEQ");
                Insert(Entity);
            }
            catch (Exception ex)
            {                
                throw new ApplicationException(ex.Message);
            }
        }

        /// <summary>
        /// metodo que se conecta a la base de datos para actualizar un registro
        /// </summary>
        /// <param name="Entity">objeto de tipo "TIPO_DISPOSICION" con valores a actualizar</param>
        public void Actualizar(TIPO_DISPOSICION Entity)
        {
            try
            {
                Update(Entity);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("part of the object's key information"))
                    throw new ApplicationException("La llave principal no se puede cambiar");
                else
                    throw new ApplicationException(ex.Message);
            }
        }

        /// <summary>
        /// metodo que se conecta a la base de datos para eliminar un registro
        /// </summary>
        /// <param name="Id">valor de la llave primaria para obtener registro</param>
        /// <returns>"True" para eliminado, "False" para no encontrado</returns>
        public bool Eliminar(int Id)
        {
            try
            {
                var Entity = GetData().Where(w => w.ID_DISPOSICION == Id).SingleOrDefault();
                if (Entity != null)
                    return Delete(Entity);
                else
                    return false;
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