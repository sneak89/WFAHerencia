using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHerencia
{
    internal class Vaca : Mamifero
    {
        private double litrosDeLeche { get; set; }

        public Vaca(string n, double p, double l) : base(n, p)
        {
            this.litrosDeLeche = l;
        }

        public double CalcularCantidadComida()
        {
            double kComida = 0;
            kComida = peso / litrosDeLeche;
            return kComida;
        }

        public string mostrarVaca()
        {
            string dato;
            dato = "El nombre de la vaca es: " + getNombre() + Environment.NewLine;
            dato += "El peso es: " + peso + " kilogramos" + Environment.NewLine;
            dato += "La cantidad de leche que produces es : " + litrosDeLeche + Environment.NewLine;
            dato += "Come " + CalcularCantidadComida() + " Kilos" + Environment.NewLine; 
            return dato;
        }

    }
}
