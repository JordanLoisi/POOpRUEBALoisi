using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnDoePOO.Entidades
{
    public class Automovil : Vehiculos
    {
        private const int ValorHoraAutomovil = 50;
        private int valorHora;
        ConsoleColor color;

        public Automovil(string patente) : base(patente)
        {
            valorHora = ValorHoraAutomovil;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tipo: Auto\n");
            sb.AppendFormat("Patente: {0}\n", Patente);
            sb.AppendFormat("color: {0}\n", color);
            sb.AppendFormat("Hora: {0}\n", valorHora);
            sb.AppendFormat("Fecha y hora de ingreso: {0}\n", FechaIngreso);
            return sb.ToString();
        }
        public override void ImprimirTicket()
        {
            base.ImprimirTicket();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Automovil other = (Automovil)obj;
            return Patente == other.Patente;
        }
        public Automovil(string Patente, ConsoleColor color) : base(Patente)
        {
            this.color = color;

        }

        public Automovil(string Patente, ConsoleColor color, int valorHora) : base(Patente)
        {
            valorHora = ValorHoraAutomovil;
        }
    }
}
