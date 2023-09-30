namespace MiCalculadora
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            rdbDecimal = new RadioButton();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            cmbOperador = new ComboBox();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            label5 = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 41);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(246, 65);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado:";
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(6, 22);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 2;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(284, 168);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(181, 58);
            grpSistema.TabIndex = 1;
            grpSistema.TabStop = false;
            grpSistema.Text = "Representar el resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(96, 22);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 3;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(22, 249);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(221, 37);
            lblPrimerOperador.TabIndex = 9;
            lblPrimerOperador.Text = "Primer Operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(307, 249);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(146, 37);
            lblOperacion.TabIndex = 8;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(514, 249);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(250, 37);
            lblSegundoOperador.TabIndex = 7;
            lblSegundoOperador.Text = "Segundo Operador:";
            // 
            // cmbOperador
            // 
            cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperador.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperador.FormattingEnabled = true;
            cmbOperador.ItemHeight = 28;
            cmbOperador.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperador.Location = new Point(321, 298);
            cmbOperador.Name = "cmbOperador";
            cmbOperador.Size = new Size(121, 36);
            cmbOperador.TabIndex = 5;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(22, 298);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(238, 23);
            txtPrimerOperador.TabIndex = 4;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(526, 298);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(238, 23);
            txtSegundoOperador.TabIndex = 6;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(59, 360);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(172, 57);
            btnOperar.TabIndex = 7;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(293, 360);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(172, 57);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button2_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(559, 360);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(172, 57);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(260, 53);
            label5.Name = "label5";
            label5.Size = new Size(0, 50);
            label5.TabIndex = 10;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(cmbOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(grpSistema);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            Text = "Calculadora de Gastón Gómez";
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private RadioButton rdbDecimal;
        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private ComboBox cmbOperador;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label label5;
    }
}