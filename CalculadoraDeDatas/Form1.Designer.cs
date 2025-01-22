namespace CalculadoraDeDatas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btnCalculaDiferenca = new Button();
            dtpFinal = new DateTimePicker();
            dtpInicial = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rbSubtrai = new RadioButton();
            rbAdiciona = new RadioButton();
            btnAdicionaSubtrai = new Button();
            tbAnos = new TextBox();
            label7 = new Label();
            tbMeses = new TextBox();
            label6 = new Label();
            tbDias = new TextBox();
            label5 = new Label();
            dtpDataAdicionaSubtrai = new DateTimePicker();
            label4 = new Label();
            lbResultado = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCalculaDiferenca);
            groupBox1.Controls.Add(dtpFinal);
            groupBox1.Controls.Add(dtpInicial);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 97);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Diferença de Datas";
            // 
            // btnCalculaDiferenca
            // 
            btnCalculaDiferenca.Location = new Point(301, 62);
            btnCalculaDiferenca.Name = "btnCalculaDiferenca";
            btnCalculaDiferenca.Size = new Size(75, 23);
            btnCalculaDiferenca.TabIndex = 4;
            btnCalculaDiferenca.Text = "Calcular";
            btnCalculaDiferenca.UseVisualStyleBackColor = true;
            btnCalculaDiferenca.Click += btnCalculaDiferenca_Click;
            // 
            // dtpFinal
            // 
            dtpFinal.Format = DateTimePickerFormat.Short;
            dtpFinal.Location = new Point(262, 33);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.Size = new Size(114, 23);
            dtpFinal.TabIndex = 3;
            // 
            // dtpInicial
            // 
            dtpInicial.Format = DateTimePickerFormat.Short;
            dtpInicial.Location = new Point(77, 33);
            dtpInicial.Name = "dtpInicial";
            dtpInicial.Size = new Size(114, 23);
            dtpInicial.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 39);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 1;
            label3.Text = "Data Final";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 39);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "Data Inicial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 32);
            label1.TabIndex = 1;
            label1.Text = "Calculadora de Datas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbSubtrai);
            groupBox2.Controls.Add(rbAdiciona);
            groupBox2.Controls.Add(btnAdicionaSubtrai);
            groupBox2.Controls.Add(tbAnos);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbMeses);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbDias);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dtpDataAdicionaSubtrai);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 114);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adição ou Subtração de Datas";
            // 
            // rbSubtrai
            // 
            rbSubtrai.AutoSize = true;
            rbSubtrai.Location = new Point(262, 26);
            rbSubtrai.Name = "rbSubtrai";
            rbSubtrai.Size = new Size(78, 19);
            rbSubtrai.TabIndex = 14;
            rbSubtrai.Text = "Subtração";
            rbSubtrai.UseVisualStyleBackColor = true;
            // 
            // rbAdiciona
            // 
            rbAdiciona.AutoSize = true;
            rbAdiciona.Checked = true;
            rbAdiciona.Location = new Point(197, 26);
            rbAdiciona.Name = "rbAdiciona";
            rbAdiciona.Size = new Size(62, 19);
            rbAdiciona.TabIndex = 13;
            rbAdiciona.TabStop = true;
            rbAdiciona.Text = "Adição";
            rbAdiciona.UseVisualStyleBackColor = true;
            // 
            // btnAdicionaSubtrai
            // 
            btnAdicionaSubtrai.Location = new Point(301, 80);
            btnAdicionaSubtrai.Name = "btnAdicionaSubtrai";
            btnAdicionaSubtrai.Size = new Size(75, 23);
            btnAdicionaSubtrai.TabIndex = 5;
            btnAdicionaSubtrai.Text = "Calcular";
            btnAdicionaSubtrai.UseVisualStyleBackColor = true;
            btnAdicionaSubtrai.Click += btnAdicionaSubtrai_Click;
            // 
            // tbAnos
            // 
            tbAnos.Location = new Point(263, 51);
            tbAnos.Name = "tbAnos";
            tbAnos.Size = new Size(62, 23);
            tbAnos.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(223, 55);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 11;
            label7.Text = "Anos";
            // 
            // tbMeses
            // 
            tbMeses.Location = new Point(155, 51);
            tbMeses.Name = "tbMeses";
            tbMeses.Size = new Size(62, 23);
            tbMeses.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 55);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 9;
            label6.Text = "Meses";
            // 
            // tbDias
            // 
            tbDias.Location = new Point(41, 51);
            tbDias.Name = "tbDias";
            tbDias.Size = new Size(62, 23);
            tbDias.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 55);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 7;
            label5.Text = "Dias";
            // 
            // dtpDataAdicionaSubtrai
            // 
            dtpDataAdicionaSubtrai.Format = DateTimePickerFormat.Short;
            dtpDataAdicionaSubtrai.Location = new Point(77, 24);
            dtpDataAdicionaSubtrai.Name = "dtpDataAdicionaSubtrai";
            dtpDataAdicionaSubtrai.Size = new Size(114, 23);
            dtpDataAdicionaSubtrai.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 5;
            label4.Text = "Data Inicial";
            // 
            // lbResultado
            // 
            lbResultado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbResultado.Location = new Point(12, 277);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(388, 54);
            lbResultado.TabIndex = 3;
            lbResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 344);
            Controls.Add(lbResultado);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculadora de Datas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpInicial;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnCalculaDiferenca;
        private DateTimePicker dtpFinal;
        private RadioButton rbSubtrai;
        private RadioButton rbAdiciona;
        private Button btnAdicionaSubtrai;
        private TextBox tbAnos;
        private Label label7;
        private TextBox tbMeses;
        private Label label6;
        private TextBox tbDias;
        private Label label5;
        private DateTimePicker dtpDataAdicionaSubtrai;
        private Label label4;
        private Label lbResultado;
    }
}
