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
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primerOperando = new Numeracion(ESistema.Decimal, textBox2.Text);
            segundoOperando = new Numeracion(ESistema.Decimal, textBox1.Text);
            calculadora = new Operacion(primerOperando, segundoOperando);
            set_Resultado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
        }

        private void set_Resultado()
        {
            int primerOperandoInt;
            int segundoOperandoInt;
            if (int.TryParse(textBox1.Text, out primerOperandoInt) && int.TryParse(textBox2.Text, out segundoOperandoInt))
            {
                switch (comboBox1.SelectedIndex)
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
                string resultadoConvertido = resultado.ConvertirA(sistema);
                label5.Text = resultadoConvertido;
            }
        }

        private void rdoDecimal_CheckedChanged(object sender, EventArgs e)
        {
            sistema = ESistema.Decimal;
            if(resultado is not null)
            {
                set_Resultado();
            }
        }

        private void rdoBinario_CheckedChanged(object sender, EventArgs e)
        {
            sistema = ESistema.Binario;
            if (resultado is not null)
            {
                set_Resultado();
            }
        }
    }
}