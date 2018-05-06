using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Negocio
{
    //Implementar reglas de negocio en las clases

    public class Persona
    {
        private string _nombre;
        private DateTime _fechaNacimiento;
        private long _rut;
        private string _digitoVerificador;

     

        public string Nombre
        {
            get { return _nombre; }
            set {
                if(value == String.Empty)
                {
                    //Arrojar nueva ExcepcionPersonalizada
                    throw new ArgumentException("No se puede ingresar un nombre vacio");
                }
                else if(value.Trim().Length < 2)
                {
                    throw new ArgumentException("El nombre no puede tener menos de 2 caracteres");
                }
                else
                {
                    _nombre = value;
                }
            }
        }


        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set {
                if(value > DateTime.Now)
                {
                    throw new ArgumentException("No puede ingresar una fecha mayor a hoy");
                }
                else
                {
                    _fechaNacimiento = value;
                }
            }
        }


        public long Rut
        {
            get { return _rut; }
            set {
                if (value <= 0 && value >= 100000000)
                {
                    throw new ArgumentException("El rut es incorrecto");
                }
                else
                {
                    _rut = value;
                }
            }
        }

        public string DigitoVerificador
        {
            get { return _digitoVerificador; }
            set {
                if (value.Trim() == string.Empty)
                {
                    throw new ArgumentException("Debe ingresar un digito verificador");
                }
                else
                {
                    _digitoVerificador = value;
                }
            }
        }

        public Persona(string nombre, long rut, string dv, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Rut = rut;
            DigitoVerificador = dv;
            FechaNacimiento = fechaNacimiento;
        }
        public Persona()
        {
            _nombre = "Nombre";
            _rut = 1;
            _digitoVerificador = "j";
            _fechaNacimiento = new DateTime(1990,12,10);
        }
    }
}
