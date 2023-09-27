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
        public ESistema Sistema { get { return sistema; } }
        public string Valor { get { return valorNumerico.ToString(); } }

        public Numeracion(ESistema sistema, string valor)
        {
            InicializarValores(sistema, valor);
        }

        public Numeracion(ESistema sistema, double valor) : this(sistema, valor.ToString()) { }

        private void InicializarValores(ESistema sistema, string valor)
        {
            this.sistema = sistema;
            if(sistema == ESistema.Binario)
            {
                ConvertirA(ESistema.Decimal);
            }
            else if(sistema == ESistema.Decimal)
            {
                if(!double.TryParse(valor, out valorNumerico))
                {
                    valorNumerico = double.MinValue;
                }

            }
        }

        public string ConvertirA(ESistema sistema)
        {
            if(sistema == ESistema.Binario && !EsBinario(Valor))
            {
                return DecimalABinario(Valor);
            }
            else
            {
                return Valor;
            }
        }

        private static bool EsBinario(string valor)
        {
            foreach(char caracter in valor)
            {
                if(caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private string DecimalABinario(int valor)
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

        private string DecimalABinario(string valor)
        {
            int valorInt;

            if(int.TryParse(valor, out valorInt))
            {
                return DecimalABinario(valorInt);
            }
            else
            {
                return "Numero Invalido";
            }
        }

        private double BinarioADecimal(string valor)
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
