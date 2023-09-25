namespace Entidades
{
    public class Operacion
    {
        Numeracion primerOperando;
        Numeracion segundoOperando;
        private Numeracion PrimerOperando{get{return primerOperando;} set { primerOperando = value;}}
        private Numeracion SegundoOperando { get { return segundoOperando; } set { segundoOperando = value; } }
        public Operacion(Numeracion primerOperando, Numeracion segundoOperando) 
        { 
            this.PrimerOperando = primerOperando;
            this.SegundoOperando = segundoOperando;
        }

        public Numeracion Operar(char operador)
        {
            switch (operador)
            {
                case '-':
                    return PrimerOperando - SegundoOperando;
                    break;
                case '*':
                    return PrimerOperando * SegundoOperando;
                    break;
                case '/':
                    return PrimerOperando / SegundoOperando;
                    break;
                default:
                    return PrimerOperando + SegundoOperando;
                    break;
            }
        }
    }
}