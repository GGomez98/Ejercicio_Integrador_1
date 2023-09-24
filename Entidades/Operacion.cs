namespace Entidades
{
    public class Operacion
    {
        private Numeracion PrimerOperando {  get; set; }
        private Numeracion SegundoOperando { get; set; }
        Numeracion primerOperando;
        Numeracion segundoOperando;
        public Operacion(Numeracion primerOperando, Numeracion segundoOperando) 
        { 
        }

        public Numeracion Operar(char operador)
        {
            switch (operador)
            {
                case '-':
                    break;
                case '*':
                    break;
                case '/':
                    break;
                default:
                    break;
            }
        }
    }
}