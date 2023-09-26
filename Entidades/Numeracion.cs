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
        private ESistema sistema;
        private double valorNumerico;
        private ESistema Sistema { get { return sistema; } }
        private string Valor { get { return valorNumerico.ToString(); } }

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
            if(sistema == ESistema.Binario && !this.EsBinario(Valor))
            {
                return this.DecimalBinario(Valor);
            }
            else
            {
                return Valor;
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
            if (valor >= 0)
            {
                if (valor == 0)
                {
                    return "0";
                }

                string binario = "";

                while (valor > 0)
                {
                    int aux = valor % 2;
                    binario = aux + binario;
                    valor /= 2;
                }

                return binario;
            }
            else
            {
                return "Numero Invalido";
            }
        }

        private string DecimalBinario(string valor)
        {
            int valorInt;

            if(int.TryParse(valor, out valorInt))
            {
                return this.DecimalBinario(valorInt);
            }
            else
            {
                return "Numero Invalido";
            }
        }

        private double BinarioDecimal(string valor)
        {
            try
            {
                return Convert.ToInt32(valor, 2);
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        public static Numeracion operator + (Numeracion n1, Numeracion n2)
        {
            Numeracion r = new Numeracion(ESistema.Decimal, 0);
            r.valorNumerico = n1.valorNumerico + n2.valorNumerico;
            return r;
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            Numeracion r = new Numeracion(ESistema.Decimal, 0);
            r.valorNumerico = n1.valorNumerico - n2.valorNumerico;
            return r;
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            Numeracion r = new Numeracion(ESistema.Decimal, 0);
            r.valorNumerico = n1.valorNumerico / n2.valorNumerico;
            return r;
        }

        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            Numeracion r = new Numeracion(ESistema.Decimal, 0);
            r.valorNumerico = n1.valorNumerico * n2.valorNumerico;
            return r;
        }

    }
}
