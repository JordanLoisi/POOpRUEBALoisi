using JohnDoePOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOHNDoePOO.Datos
{
    public class Estacionamiento
    {
        int espacioDisponible;
        String Nombre;

        private List<Vehiculos> vehiculos;
      

        public Estacionamiento(int capacidadMaxima)
        {
            this.espacioDisponible = capacidadMaxima;
            vehiculos = new List<Vehiculos>();
        }

        public static explicit operator string(Estacionamiento estacionamiento)
        {
            int lugaresDisponibles = estacionamiento.espacioDisponible - estacionamiento.vehiculos.Count;

            string vehiculosEnLista = "Vehículos en la lista del estacionamiento:\n";
            foreach (var vehiculo in estacionamiento.vehiculos)
            {
                vehiculosEnLista += $"Patente: {vehiculo.Patente}\n";
               
            }

            return $"Información del Estacionamiento:\nLugares disponibles: {lugaresDisponibles}\n{vehiculosEnLista}";
        }

        public void AgregarVehiculo(Vehiculos vehiculo)
        {
            if (!vehiculos.Contains(vehiculo) && !string.IsNullOrEmpty(vehiculo.Patente) && vehiculos.Count < espacioDisponible)
            {
                vehiculos.Add(vehiculo);
                Console.WriteLine("Vehículo agregado al estacionamiento.");
            }
            else
            {
                Console.WriteLine("No se pudo agregar el vehículo al estacionamiento.");
            }
        }
             public static bool operator ==(Estacionamiento estacionamiento, Vehiculos vehiculo)
        {
            return estacionamiento.ContieneVehiculo(vehiculo);
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculos vehiculo)
        {
            return !estacionamiento.ContieneVehiculo(vehiculo);
        }

        private bool ContieneVehiculo(Vehiculos vehiculo)
        {
            return vehiculos.Contains(vehiculo);
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculos vehiculo)
        {
            estacionamiento.AgregarVehiculo(vehiculo);
            return estacionamiento;
        }

       
        public static Estacionamiento operator -(Estacionamiento estacionamiento, Vehiculos vehiculo)
        {
            estacionamiento.QuitarVehiculo(vehiculo);
            return estacionamiento;
        }

        private void QuitarVehiculo(Vehiculos vehiculo)
        {
            if (vehiculos.Contains(vehiculo))
            {
                vehiculos.Remove(vehiculo);
                Console.WriteLine("Vehículo retirado del estacionamiento.");
            }
            else
            {
                Console.WriteLine("El vehículo no es parte del estacionamiento.");
            }
        }
    }
}
