using System;

namespace Aves
{
    interface IAve
    {
        void Volar();
        void Cantar();
        void PonerHuevos();
    }

    interface IAveNadadora
    {
        void Nadar();
    }

    interface IAveCazadora
    {
        void Cazar();
    }

    class Paloma : IAve
    {
        public void Volar()
        {
            Console.WriteLine("La paloma está volando.");
        }

        public void Cantar()
        {
            Console.WriteLine("La paloma está cantando.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("La paloma está poniendo huevos.");
        }
    }

    class Pato : IAve, IAveNadadora
    {
        public void Volar()
        {
            Console.WriteLine("El pato está volando.");
        }

        public void Cantar()
        {
            Console.WriteLine("El pato está cantando.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El pato está poniendo huevos.");
        }

        public void Nadar()
        {
            Console.WriteLine("El pato está nadando.");
        }
    }

    class Aguila : IAve, IAveCazadora
    {
        public void Volar()
        {
            Console.WriteLine("El águila está volando.");
        }

        public void Cantar()
        {
            Console.WriteLine("El águila está cantando.");
        }

        public void PonerHuevos()
        {
            Console.WriteLine("El águila está poniendo huevos.");
        }

        public void Cazar()
        {
            Console.WriteLine("El águila está cazando.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAve Paloma = new Paloma();
            Paloma.Volar();
            Paloma.Cantar();
            Paloma.PonerHuevos();

            IAveNadadora pato = new Pato();
            pato.Nadar();

            IAveCazadora aguila = new Aguila();
            aguila.Cazar();

            Console.ReadKey();
        }
    }
}
