using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ESistema
    {
        Decimal,
        Binario
    }
    public class Numeracion
    {
        private ESistema Sistema { get; }
        private string Valor {get; }
        ESistema sistema;
        double valorNumerico;


        public Numeracion(ESistema sistema, double valorNumerico)
        {
            InicializarValores(sistema, valorNumerico);
        }

        private void InicializarValores(ESistema sistema, double valorNumerico)
        {
            this.sistema = sistema;
            this.valorNumerico = valorNumerico;
        }

        public string ConvertirA(ESistema sistema)
        {
            if(sistema == ESistema.Binario)
            {
            }
            else
            {
            }
        }

        private bool EsBinario(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if(caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private string DecimalBinario(int valor)
        {
        }

        private string DecimalBinario(string valor)
        {
        }

        private double BinarioDecimal(string valor)
        {
        }
    }
}
