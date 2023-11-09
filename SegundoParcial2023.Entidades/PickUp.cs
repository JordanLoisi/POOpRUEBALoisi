using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnDoePOO.Entidades
{
    public class PickUp : Vehiculos
    {
        string Modelo;
        

       
        private  int ValorHoraPickUp = 70;
        private int valorHora;

        public PickUp(string patente) : base(patente)
        {
            valorHora = ValorHoraPickUp;
        }

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tipo: PickUp\n");
            sb.AppendFormat("Patente: {0}\n", Patente);
            sb.AppendFormat("Hora: {0}\n", valorHora);
            sb.AppendFormat("Fecha y hora de ingreso: {0}\n", FechaIngreso);
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            PickUp other = (PickUp)obj;
            return Patente == other.Patente;
        }
        public override void ImprimirTicket()
        {
            base.ImprimirTicket();
        }

        public PickUp(string Patente, string Modelo) : base(Patente)
        {
            this.Modelo = Modelo;

        }

        public PickUp(string Patente, string Modelo, int valorHora) : base(Patente)
        {
            valorHora = ValorHoraPickUp;
        }



    }
}
