using Entidades;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        Numeracion primerOperando;
        Numeracion segundoOperando;
        Numeracion resultado;
        Operacion calculadora;
        ESistema sistema;
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            rdbDecimal.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primerOperando = new Numeracion(ESistema.Decimal, txtPrimerOperador.Text);
            segundoOperando = new Numeracion(ESistema.Decimal, txtSegundoOperador.Text);
            calculadora = new Operacion(primerOperando, segundoOperando); 
            switch (cmbOperador.SelectedIndex)
            {
                case 1:
                    resultado = calculadora.Operar('-');
                    break;
                case 2:
                    resultado = calculadora.Operar('*');
                    break;
                case 3:
                    resultado = calculadora.Operar('/');
                    break;
                default:
                    resultado = calculadora.Operar('+');
                    break;
            }
            set_Resultado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPrimerOperador.Text = "";
            txtSegundoOperador.Text = "";
            label5.Text = "";
            resultado = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cierre = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo);

            if (cierre == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
        }

        private void set_Resultado()
        {
           string resultadoConvertido = resultado.ConvertirA(sistema);
           label5.Text = resultadoConvertido;
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            sistema = ESistema.Decimal;
            if (resultado is not null)
            {
                set_Resultado();
            }
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            sistema = ESistema.Binario;
            if (resultado is not null)
            {
                set_Resultado();
            }
        }
    }
}