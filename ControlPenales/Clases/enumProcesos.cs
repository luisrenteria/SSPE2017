﻿namespace ControlPenales
{
    public enum enumProcesos
    {
        INGRESO = 1,
        FICHA = 10,
        EVENTO = 70,
        SOLICITUD_ATENCION = 21,
        EMI_LIBERADOS = 23,
        DECOMISO = 100,
        UBICACION_ESTANCIAS = 101,
        VISITA_EXTERNA = 102,
        CAUSA_PENAL = 103,
        PERTENENCIAS = 104,
        SANCIONES_DISCIPLINARIAS = 105,
        CONTROL_SANCIONES = 106,
        EMI = 107,
        REGISTRO_PERSONAL = 108,
        PADRON_ABOGADOS = 109,
        PADRON_COLABORADORES = 110,
        PADRON_ACTUARIOS = 111,
        REQUERIMIENTO_INTERNOS = 112,
        LIBERACION = 113,
        REGISTRO_LIBERADOS = 114,
        PADRON_VISITAS = 115,
        LIBERACION_BIOMETRICA = 116,
        CITA = 118,
        TRASLADOMASIVO = 120,
        TRASLADOEXTERNO = 121,
        AUTORIZAINGRESOTRASLADO = 122,
        RECEPCION_ADUANA = 123,
        PLANIMETRIA = 124,
        ESTUDIO_SOCIOECONOMICO = 125,
        EMI_PENDIENTE = 126,
        EXCARCELACIONES = 127,
        ESTUDIO_PERSONALIDAD = 128,
        ESTATUS_ADMINISTRATIVO = 129,
        CONTROL_DE_INTERNOS_EN_EDIFICIOS = 130,
        CONTROL_DE_ACTIVIDADES = 131,
        PROGRAMACION_VISITA_POR_EDIFICIO = 132,
        CREACION_GRUPOS = 133,
        CREACION_GRUPOS_COMPLEMENTARIOS = 134,
        MANEJO_EMPALMES = 135,
        SEGUIMIENTO_EVALUACION_GRUPOS = 136,
        NOTA_MEDICA = 138,
        EQUIPO_AREA = 139,
        HISTORIA_CLINICA = 140,
        EXCARCELACIONAUTORIZACION = 141,
        AGENDAMEDICA = 142,
        MANEJO_GRUPOS = 143,
        MANEJO_CANCELADO_SUSPENDIDO = 144,
        CONTROL_CALIFICACIONES = 145,
        CONTROL_PARTICIPACION = 146,
        PROGRAMACION_VISITA_POR_APELLIDO = 147,
        VERIFICAR_PASE = 148,
        CANCELAR_SUSPENDER_CREDENCIALES = 149,
        CONTROL_ACTIVIDADES_PROGRAMADAS = 150,
        CONTROL_ACTIVIDADES_NO_PROGRAMADAS = 151,
        ATENCION_CITA = 152,
        ATENCION_CITA_LISTA = 153,
        TRABAJO_SOCIAL = 154,
        REPORTE_PSICOLOGICO = 155,
        VISITA_DOMICILIARIA = 156,
        REALIZACION_LISTAS_ESTUDIOS = 157,
        CERTIFICADO_MEDICO_TRASPASOS_CANCELACIONES = 158,
        SOLICITUD_ATENCION_ESTATUS = 159,
        CONSULTA_UNIFICADA = 160,
        ENTREVISTA_INICIAL_TRABAJO_SOCIAL = 161,
        BITACORA_REGISTRO_ABOGADO = 162,
        REPORTE_ABOGADO = 163,
        REPORTE_ABOGADOS_FECHA = 164,
        REPORTE_ABOGADO_INGRESO = 165,
        REPORTE_ABOGADO_POBLACION_ASIGNADA = 166,
        REPORTE_EMI_PENDIENTE = 167,
        CONFIGURACIONDEPARTAMENTOAREATECNICA = 168,
        CAT_MEDIA_FILIACION = 169,
        CAT_TIPO_FILIACION = 170,
        CAT_ESCOLARIDAD = 171,
        CAT_RELIGION = 172,
        CAT_TIPO_SANGRE = 173,
        CAT_OCUPACION = 174,
        CAT_ETNIAS = 175,
        CAT_PANDILLAS = 176,
        CAT_COMPORTAMIENTO_HOMOSEXUAL = 177,
        CAT_TATUAJES = 178,
        CAT_CICATRICES = 179,
        CAT_DEFECTOS = 180,
        CAT_LUNARES = 181,
        CAT_TIPO_DISCAPACIDAD = 182,
        CAT_TIPO_ABOGADO = 183,
        CAT_PAISES = 184,
        CAT_ESTADOS = 185,
        CAT_MUNICIPIO = 186,
        CAT_COLONIAS = 187,
        CAT_CENTROS = 188,
        CAT_EDIFICIOS = 189,
        CAT_SECTORES = 190,
        CAT_CELDAS = 191,
        CAT_CAMAS = 192,
        CAT_DEPARTAMENTOS = 193,
        CAT_TIPO_PROGRAMA = 194,
        CAT_AREAS = 195,
        CAT_TIPO_ACTIVIDAD_PROGRAMAS = 196,
        CAT_ACTIVIDADES = 197,
        CAT_EJES = 198,
        CAT_DELITOS = 199,
        CAT_AUTOS_TERMINOS = 200,
        CAT_TIPO_RECURSO = 201,
        CAT_TIPO_INGRESO = 202,
        CAT_TIPO_ESTUDIO = 203,
        CAT_MOTIVO_SOLICITUD_ESTUDIO = 204,
        CAT_TIPO_VISITANTE = 205,
        CAT_RELACION = 206,
        CAT_TIPO_SITUACION = 207,
        CAT_MARCA_MODELO = 208,
        CAT_FABRICANTE_MODELO = 209,
        CAT_COMPANIAS = 210,
        CAT_UNIDAD_MEDIDA = 211,
        CAT_OBJETOS = 212,
        CAT_GRUPOS_POLICIALES = 213,
        CAT_SECTOR_CLASIFICACION = 214,
        CAT_TIPO_MENSAJE = 215,
        CAT_TIPO_AMPARO_INDIRECTO = 216,
        CAT_TIPO_INCIDENTE = 217,
        CAT_CONSULTA_UNIFICADA = 218,
        CAT_HORARIO_YARDAS = 219,
        PRIVILEGIOS = 220,
        CAMBIO_CLAVE_ACCESO = 221,
        CAT_EQUIPOS_AUTORIZADOS = 222,
        OPCIONES_GENERALES = 223,
        CONF_DEPARTAMENTOS = 224,
        CAT_AGENCIAS = 225,
        CAT_JUZGADOS = 226,
        CAT_PARAMETROS = 227,
        ACTIVACION_CUENTA = 228,
        CATALOGOACTIVIDADEJE = 229,
        CATALOGOESPECIALIDADES = 230,
        CATALOGOTIPOSERVICIOSAUX = 231,
        CATALOGOSUBTIPOSERVICIOSAUX = 232,
        REPORTE_CERTIFICADO_MEDICO_NUEVO_INGRESO = 233,
        CATALOGOSERVICIOSAUXILIARES = 234,
        CAT_PROCEDIMIENTO_SUBTIPO = 235,
        CAT_PROCEDIMIENTO_MEDICO = 236,
        CAT_PROCEDIMIENTO_MATERIAL = 237,
        CATALOGOTIPOATENCIONINTERCONSULTA = 238,
        HISTORIA_CLINICA_DENTAL = 239,
        NOTIFICACION_TS = 240,
        RESULT_SERVICIOS_AUX = 241,
        CATALOGO_DE_ESPECIALISTAS = 242,
        SOLICITUDINTERCONSULTA = 243,
        AGENDA_ESPECIALISTA = 244,
        CORRESPONDENCIA = 245,
        PROGRAMACION_EVENTOS = 246,
        NOTA_TECNICA = 247,
        HISTORIAL_CITAS = 248,
        VISITAS_LEGALES = 249,
        REPORTE_LISTADO_GENERAL = 250,
        REPORTE_IMPRESION_LISTAS = 251,
        REPORTE_SITUACION_JURIDICA = 252,
        REPORTE_CONTROL_INTERNOS_EDIFICIO = 253,
        REPORTE_INTERNOS_UBICACION = 254,
        REPORTE_INTERNOS_REUBICACIONES = 255,
        REPORTE_PAPELETAS = 256,
        REPORTE_ALTAS_BAJAS = 257,
        REPORTE_TRASLADOS_ESTATALES = 258,
        REPORTE_LISTADO_GENERAL_DELITO = 259,
        REPORTE_GAFETES_BRAZALETES = 260,
        REPORTE_CREDENCIAL_BIBLIOTECA = 261,
        REPORTE_CONTROL_VISITANTES = 262,
        REPORTE_POBLACION = 263,
        REPORTE_ESTADISTICA_ALTAS_BAJAS = 264,
        REPORTE_POBLACION_DELITO = 265,
        REPORTE_POBLACION_ENTIDAD_PROCEDENCIA = 266,
        REPORTE_POBLACION_INDIGENA = 267,
        REPORTE_POBLACION_EXTRANJERA = 268,
        REPORTE_POBLACION_TERCERA_EDAD = 269,
        REPORTE_TOTAL_INGRESOS = 270,
        REPORTE_MOTIVOS_SALIDA = 271,
        REPORTE_TIEMPO_COMPURGACION = 272,
        REPORTE_CAUSA_PENAL = 273,
        REPORTE_RELACION_INTERNO_ABOGADO = 274,
        REPORTE_KARDEX_INTERNO = 275,
        REPORTE_LISTADO_INTERNOS_GRUPO = 276,
        REPORTE_LISTADO_GRUPOS_ACTIVOS = 277,
        REPORTE_HORARIOS_GRUPOS = 278,
        REPORTE_LISTADO_RESPONSABLES_GRUPO = 279,
        REPORTE_HORARIO_RESPONSABLE_GRUPO = 280,
        REPORTE_HORARIO_AREAS = 281,
        REPORTE_PADRON_EMPLEADO = 282,
        REPORTE_FORMATO_IDENTIFICACION_FICHA = 283,
        REPORTE_DECOMISOS_FECHA = 284,
        REPORTE_ALTO_IMPACTO = 285,
        REPORTE_REOS_PELIGROSOS = 286,
        REPORTE_BIT_ACCESO_ADUANA = 287,
        REPORTE_BIT_CORRESP_POB_PENIT = 288,
        REPORTE_PADRON_VISITA_EXTERNA = 289,
        REPORTE_TOTALES_VISITA = 290,
        REPORTE_POBLACION_INTERNOS = 291,
        REPORTE_INGRESOS_EGRESOS = 292,
        REPORTE_VISITA_FAMILIAR = 293,
        REPORTE_CONTROL_VISITANTES_DIA = 294,
        REPORTE_CONTROL_VISITANTES_INTIMOS_DIA = 295,
        REPORTE_BITACORA_TIEMPOS = 296,
        REPORTE_VISITANTES_TRAMITE = 297,
        REPORTE_VISITANTES_REGISTRADOS_INTERNO = 298,
        REPORTE_PROGRAMAS_REHABILITACION = 299,
        SOLICITUD_CANALIZACION = 300,
        ATENCION_CANALIZACION = 301,
        RESULTADOS_SERVICIOS_AUXILIARES = 302,
        BITACORA_HOSPITALIZACION = 303,
        REPORTE_POBLACION_ACTIVA_CIERRE = 304,
        REPORTE_PRIMERA_VEZ_FUERO_DELITO = 305,
        REPORTE_SENTENCIADO_SEXO_FUERO_DELITO = 306,
        REPORTE_PROCESADO_SEXO_FUERO_DELITO = 307,
        REPORTE_CDNH = 308,
        REPORTE_DECOMISO_CUSTODIO = 309,
        REPORTE_DECOMISO_OBJETO = 310,
        ENTREVISTA_INICIAL_LIBERADOS = 311,
        REPORTE_REINGRESOS = 312,
        REPORTE_REINCIDENTES = 313,
        CIERRE_ESTUDIOS_PERSONALIDAD = 314,
        REALIZACION_ESTUDIOS_PERSONALIDAD = 315,
        HOJA_CONTROL_LIQUIDOS = 316,
        REPORTE_HOJA_REF_MEDICA = 317,
        NOTA_MEDICA_ESPECIALISTA = 318,
        RECETA_MEDICA = 319,
        CAPTURADEFUNCION = 320,
        NOTA_EVOLUCION = 321,
        REPORTETARJETAINFORMATIVADECESO = 322,
        CATALOGOCAMASHOSPITAL = 323,
        ESCALA_RIESGO = 324,
        HOJA_ENFERMERIA = 325,
        REPORTEINCIDENTE = 326,
        CATALOGOENFERMEDADES = 327,
        CATALOGOMEDICAMENTOS = 328,
        CATALOGOMEDICAMENTO_CATEGORIAS = 329,
        CATALOGOMEDICAMENTO_SUBCATEGORIAS = 330,
        CATALOGO_PATOLOGICOS=331,
        AGENDAENFERMERO=332,
        PROGRAMA_LIBERTAD = 333,
        PROGRAMAS_LIBERTAD = 334,
        UNIDAD_RECEPTORA = 335,
        BITACORA_VISITA_FAMILIAR = 336,
        REAGENDATRASLADOVIRTUAL=337,
        CONSULTA_EXPEDIENTE=338,
        CAT_INSTITUCIONES_MEDICAS=339,
        REPORTE_ACTIVIDADES = 340
    }
}