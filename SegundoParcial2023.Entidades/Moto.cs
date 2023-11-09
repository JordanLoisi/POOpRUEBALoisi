using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnDoePOO.Entidades
{
    public class Moto : Vehiculos
    {
        int cilindrada;
        short Ruedas;
        int valorHora;
        public Moto(string patente) : base(patente)
        {
            valorHora = 30;
            Ruedas = 2; 
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tipo: Moto\n");
            sb.AppendFormat("Patente: {0}\n", Patente);
            sb.AppendFormat("Ruedas: {0}\n", Ruedas);
            sb.AppendFormat("Hora: {0}\n", valorHora);
            sb.AppendFormat("Fecha y hora de ingreso: {0}\n", FechaIngreso);
            return sb.ToString();
        }



       
    }
}
