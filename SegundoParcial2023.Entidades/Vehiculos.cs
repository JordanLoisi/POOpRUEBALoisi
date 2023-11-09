using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JohnDoePOO.Entidades
{
    public abstract class Vehiculos 
    {
        public DateTime FechaIngreso { get; }
        public string Patente { get; }

       

        public Vehiculos(string patente)
        {
            FechaIngreso = DateTime.Now.AddHours(-3);
            Patente = ValidarPatente(patente);
        }

        private string ValidarPatente(string patente)
        {
           
            if (Regex.IsMatch(patente, @"^[A-Z]{2,3}\d{3}$|^\d{3}[A-Z]{2}$"))
            {
                return patente;
            }
            else
            {
                throw new ArgumentException("Formato de patente no válido");
            }
        }

        public virtual void ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Patente: {0}\n", Patente);
            sb.AppendFormat("Fecha y hora de ingreso: {0}\n", FechaIngreso);
            Console.WriteLine(sb.ToString());
        }

        public override string ToString()
        {
            return string.Format("Patente {0}", Patente);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Vehiculos other = (Vehiculos)obj;
            return Patente == other.Patente;
        }

        public override int GetHashCode()
        {
            return Patente.GetHashCode();
        }
        public static bool operator ==(Vehiculos vehiculo1, Vehiculos vehiculo2)
        {
            if (ReferenceEquals(vehiculo1, vehiculo2))
            {
                return true;
            }
            if (ReferenceEquals(vehiculo1, null) || ReferenceEquals(vehiculo2, null))
            {
                return false;
            }
            return vehiculo1.Equals(vehiculo2);
        }

        public static bool operator !=(Vehiculos vehiculo1, Vehiculos vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }
        override
        public virtual string ConsultarDatos()
        {
            throw new NotImplementedException();
        }
    }


}

