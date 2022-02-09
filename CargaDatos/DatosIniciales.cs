using Modelo.Entidades;
using System;
using System.Collections.Generic;
//using static Modelo.Entidades.Personal;

namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListasTipo { 
            Configuracion, Personal, Empresa,Liquidaciones,Decimo_Tercero,Roles,Salario
        }

        public Dictionary<ListasTipo, object> Carga()
        {

            //CONFIGURACION
            #region
            Configuracion config = new Configuracion()
            {
                sueldoMaximo = 425.00f,
                NombreEmpresa = "Empresa Disfarmed",
                Horas_Extras_Maxima = 8.00f,
                Horas_Extras_Minima = 1.00f,
                Salario_Horas_Extras = 2.00f
            };
            List<Configuracion> listaConfiguracion = new List<Configuracion>()
            {
                config
            };
            #endregion
            //PERSONALES
            #region
            Personal Pedro = new Personal()
            {
                Nombre = "Pedro Navaja",
                Cedula = "1706856566",
                Email = "pedro234@g.com",
                Telefono = "0984231388",
                Direccion="Av. Del Maestro",
                EstadoCV= Personal.EstadoCivil.Soltero,
                salario=600.50f,
                tipo=Personal.TipoContrato.Completo,
                fecha_incio = new DateTime(2019, 3, 1),
                fecha_salida = new DateTime(2022, 3, 1)
            };
            Personal Diana = new Personal()
            {
                Nombre = "Diana Loachamin",
                Cedula = "1706856567",
                Email = "Diana@g.com",
                Telefono = "0984231387",
                Direccion = "El Pintado",
                EstadoCV = Personal.EstadoCivil.Soltero,
                salario = 600.50f,
                tipo = Personal.TipoContrato.Completo,
                fecha_incio = new DateTime(2019, 3, 1),
                fecha_salida = new DateTime(2022, 3, 1)
            };
            Personal Diego = new Personal()
            {
                Nombre = "Diego Loachamin",
                Cedula = "1722644299",
                Email = "Diego@g.com",
                Telefono = "0984231387",
                Direccion = "El Condado",
                EstadoCV = Personal.EstadoCivil.Soltero,
                salario = 600.50f,
                tipo = Personal.TipoContrato.Completo,
                fecha_incio = new DateTime(2019, 3, 1),
                fecha_salida = new DateTime(2022, 3, 1)
            };
            Personal Omar = new Personal()
            {
                Nombre = "Omar Patino",
                Cedula = "1722644279",
                Email = "Diego@g.com",
                Telefono = "0984231387",
                Direccion = "El Condado",
                EstadoCV = Personal.EstadoCivil.Soltero,
                salario = 600.50f,
                tipo = Personal.TipoContrato.Completo,
                fecha_incio = new DateTime(2019, 3, 1),
                fecha_salida = new DateTime(2022, 3, 1)
            };
            Personal Juan = new Personal()
            {
                Nombre = "Juan Cadena",
                Cedula = "0272644279",
                Email = "Juan@g.com",
                Telefono = "0984231117",
                Direccion = "El Bosque",
                EstadoCV = Personal.EstadoCivil.Soltero,
                salario = 600.50f,
                tipo = Personal.TipoContrato.Completo,
                fecha_incio = new DateTime(2019, 3, 1),
                fecha_salida = new DateTime(2022, 3, 1)
            };
            Personal Oliver = new Personal()
            {
                Nombre = "Oliver Cadena",
                Cedula = "0277644279",
                Email = "Oliver@g.com",
                Telefono = "0984231117",
                Direccion = "Cumbaya",
                EstadoCV = Personal.EstadoCivil.Soltero,
                salario = 600.50f,
                tipo = Personal.TipoContrato.Completo,
                fecha_incio = new DateTime(2019, 3, 1),
                fecha_salida = new DateTime(2022, 3, 1)
            };
            List<Personal> listaPersonal = new List<Personal>()
            {
                Pedro,Diana,Diego,Omar,Juan,Oliver
            };
            #endregion
            //EMPRESA
            #region
            Empresa patito = new Empresa()
            {
                Personal= Pedro,
                ruc="1722644299001",
                nombreEmpresa = "Empresa Disfarmed",
                direccion = "El Condado",
                telefono="0984231389",
                provincia="Pichincha"
            };
            List<Empresa> listaEmpresa = new List<Empresa>()
            {
                patito
            };
            #endregion
            //SALARIOS
            #region
            Salario sal1 = new Salario()
            {
                Personal = Pedro,
                SueldoBasico = 600.50f,
                DecimoTercerSueldo = 33.33f,
                DecimoCuartoSueldo = 45.12f,
                Utilidades = 120.00f,
                EstadoSal = Salario.estadoSalario.Pendiente

            };
            Salario sal2 = new Salario()
            {
                Personal = Diana,
                SueldoBasico = 600.50f,
                DecimoTercerSueldo = 33.33f,
                DecimoCuartoSueldo = 45.12f,
                Utilidades = 120.00f,
                EstadoSal = Salario.estadoSalario.Pendiente

            };
            Salario sal3 = new Salario()
            {
                Personal = Diego,
                SueldoBasico = 600.50f,
                DecimoTercerSueldo = 33.33f,
                DecimoCuartoSueldo = 45.12f,
                Utilidades = 120.00f,
                EstadoSal = Salario.estadoSalario.Pendiente

            };
            Salario sal4 = new Salario()
            {
                Personal = Omar,
                SueldoBasico = 600.50f,
                DecimoTercerSueldo = 33.33f,
                DecimoCuartoSueldo = 45.12f,
                Utilidades = 120.00f,
                EstadoSal = Salario.estadoSalario.Pendiente

            };
            Salario sal5 = new Salario()
            {
                Personal = Juan,
                SueldoBasico = 600.50f,
                DecimoTercerSueldo = 33.33f,
                DecimoCuartoSueldo = 45.12f,
                Utilidades = 120.00f,
                EstadoSal = Salario.estadoSalario.Pendiente

            };
            Salario sal6 = new Salario()
            {
                Personal = Oliver,
                SueldoBasico = 600.50f,
                DecimoTercerSueldo = 33.33f,
                DecimoCuartoSueldo = 45.12f,
                Utilidades = 120.00f,
                EstadoSal = Salario.estadoSalario.Pendiente

            };
            List<Salario> listasalario = new List<Salario>()
            {
                sal1,sal2,sal3,sal4,sal5,sal6
            };
            #endregion
            //DECIMO TERCERO
            #region
            Decimo_Tercero dec13 = new Decimo_Tercero
            {
                Personal = Pedro,
                fecha_inicio = new DateTime(2019, 3, 1),
                fecha_final = new DateTime(2022, 3, 1),
                meses = "12",
                total=33.33f,
                Salario = sal1
            };
            Decimo_Tercero dec131 = new Decimo_Tercero
            {
                Personal = Diana,
                fecha_inicio = new DateTime(2019, 3, 1),
                fecha_final = new DateTime(2022, 3, 1),
                meses = "12",
                total = 33.33f,
                Salario = sal2
            };
            Decimo_Tercero dec132 = new Decimo_Tercero
            {
                Personal = Diego,
                fecha_inicio = new DateTime(2019, 3, 1),
                fecha_final = new DateTime(2022, 3, 1),
                meses = "12",
                total = 33.33f,
                Salario = sal3
            };
            Decimo_Tercero dec133 = new Decimo_Tercero
            {
                Personal = Omar,
                fecha_inicio = new DateTime(2019, 3, 1),
                fecha_final = new DateTime(2022, 3, 1),
                meses = "12",
                total = 33.33f,
                Salario = sal4
            };
            Decimo_Tercero dec134 = new Decimo_Tercero
            {
                Personal = Juan,
                fecha_inicio = new DateTime(2019, 3, 1),
                fecha_final = new DateTime(2022, 3, 1),
                meses = "12",
                total = 33.33f,
                Salario = sal5
            };
            Decimo_Tercero dec135 = new Decimo_Tercero
            {
                Personal = Oliver,
                fecha_inicio = new DateTime(2019, 3, 1),
                fecha_final = new DateTime(2022, 3, 1),
                meses = "12",
                total = 33.33f,
                Salario = sal6
            };
            List<Decimo_Tercero> listadecimo_Terceros = new List<Decimo_Tercero>()
            {
                dec13,dec131,dec132,dec133,dec134,dec135
            };
            #endregion
            //ROLES
            #region
            Roles rol1 = new Roles()
            {
                Personal = Pedro,
                comision = 300.00f,
                aporte_iess = 45.35f,
                anticipo = 21.00f,
                total = 966.85f,
                Salario = sal1
            };
            Roles rol2 = new Roles()
            {
                Personal = Diana,
                comision = 300.00f,
                aporte_iess = 45.35f,
                anticipo = 21.00f,
                total = 966.85f,
                Salario = sal2
            };
            Roles rol3 = new Roles()
            {
                Personal = Diego,
                comision = 300.00f,
                aporte_iess = 45.35f,
                anticipo = 21.00f,
                total = 966.85f,
                Salario = sal3
            };
            Roles rol4 = new Roles()
            {
                Personal = Omar,
                comision = 300.00f,
                aporte_iess = 45.35f,
                anticipo = 21.00f,
                total = 966.85f,
                Salario = sal4
            };
            Roles rol5 = new Roles()
            {
                Personal = Juan,
                comision = 300.00f,
                aporte_iess = 45.35f,
                anticipo = 21.00f,
                total = 966.85f,
                Salario = sal5
            };
            Roles rol6 = new Roles()
            {
                Personal = Oliver,
                comision = 300.00f,
                aporte_iess = 45.35f,
                anticipo = 21.00f,
                total = 966.85f,
                Salario = sal6
            };
            List<Roles> listaroles = new List<Roles>()
            {
                rol1,rol2,rol3,rol4,rol5,rol6
            };
            #endregion
            //LIQUIDACION
            #region
            Liquidaciones liq1 = new Liquidaciones()
            {
                Personal = Pedro,
                cesantia = "300.00",
                periodo_pri = "2",
                salario_base="425.00",
                Estadoliq=Liquidaciones.estado.Liquidacion
            };
            Liquidaciones liq2 = new Liquidaciones()
            {
                Personal = Diana,
                cesantia = "300.00",
                periodo_pri = "2",
                salario_base = "425.00",
                Estadoliq = Liquidaciones.estado.Liquidacion
            };
            Liquidaciones liq3 = new Liquidaciones()
            {
                Personal = Diego,
                cesantia = "300.00",
                periodo_pri = "2",
                salario_base = "425.00",
                Estadoliq = Liquidaciones.estado.Liquidacion
            };
            Liquidaciones liq4 = new Liquidaciones()
            {
                Personal = Omar,
                cesantia = "300.00",
                periodo_pri = "2",
                salario_base = "425.00",
                Estadoliq = Liquidaciones.estado.Liquidacion
            };
            Liquidaciones liq5 = new Liquidaciones()
            {
                Personal = Juan,
                cesantia = "300.00",
                periodo_pri = "2",
                salario_base = "425.00",
                Estadoliq = Liquidaciones.estado.Liquidacion
            };
            Liquidaciones liq6 = new Liquidaciones()
            {
                Personal = Oliver,
                cesantia = "300.00",
                periodo_pri = "2",
                salario_base = "425.00",
                Estadoliq = Liquidaciones.estado.Liquidacion
            };
            List<Liquidaciones> listaliquidacion = new List<Liquidaciones>()
            {
                liq1,liq2,liq3,liq4,liq5,liq6
            };
            #endregion
            

            // --------------------------------------------
            // Diccionario contiene todas las listas
            // --------------------------------------------
            Dictionary<ListasTipo, object> dicListasDatos = new Dictionary<ListasTipo, object>()
            {
                { ListasTipo.Configuracion, listaConfiguracion},
                { ListasTipo.Personal, listaPersonal},
                { ListasTipo.Empresa, listaEmpresa},
                { ListasTipo.Decimo_Tercero, listadecimo_Terceros},
                { ListasTipo.Roles, listaroles},
                { ListasTipo.Liquidaciones, listaliquidacion},
                { ListasTipo.Salario, listasalario}
            };

            return dicListasDatos;
        
        }
    }
}
