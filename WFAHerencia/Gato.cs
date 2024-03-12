using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHerencia
{
    internal class Gato : Mamifero
    {
        //Atributos
        public int nBigotes { get; set; }

        //Constructor
        public Gato(string n, double p, int b) : base(n,p)
        {
            this.nBigotes = b;
        }

        public string MostrarGato()
        {
            string dato;
            dato = "El nombre del gato es: " + getNombre() + Environment.NewLine;
            dato += "El peso es: " + peso + " kilogramos" + Environment.NewLine;
            dato += "El numero de bigotes es: " + nBigotes + Environment.NewLine;
            return dato;
        }
    }
}
