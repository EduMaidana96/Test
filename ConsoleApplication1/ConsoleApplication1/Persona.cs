using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Persona
    {
        private string nombre;
        private int edad;

        public Persona()
        {
            this.nombre = "";
            this.edad = 0;


        }
        public void setnombre( string nombre)
        {
            this.nombre = nombre;

        }

        public string getnombre()
        {
            return this.nombre;
        }

        public void setedad (int edad)
        {
            this.edad = edad;

        }

        public int getedad()
        {
            return this.edad;


        }
        public void presentar()
        {
            Console.WriteLine("hola , soy " + this.nombre + " y tengo "+ this.edad + " años ");
            
        }
    }

}
