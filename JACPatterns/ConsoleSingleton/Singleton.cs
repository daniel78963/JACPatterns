using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSingleton
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton("Juan");
        //private static Singleton instance;
        public  string texto = String.Empty;
        public int numerito = -1;

        //public string Texto { get => texto;}

        Singleton(string valor) 
        {
            texto = valor;
        }
        //Propiedad para acceder a la instancia única
        public static Singleton Instance
        {
            get { return instance; }
        }

        //public static Singleton GetInstance(string nombre) 
        //{
        //    if (instance == null)
        //        instance = new Singleton(nombre);

        //    return instance;
        //}

    }
}
