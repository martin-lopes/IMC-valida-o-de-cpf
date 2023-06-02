namespace Aula3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.combobox_genero = new System.Windows.Forms.Label();
            this.lb_peso = new System.Windows.Forms.Label();
            this.lb_altura = new System.Windows.Forms.Label();
            this.lb_idade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_peso = new System.Windows.Forms.TextBox();
            this.tx_altura = new System.Windows.Forms.TextBox();
            this.combo_genero = new System.Windows.Forms.ComboBox();
            this.tx_idade = new System.Windows.Forms.TextBox();
            this.button_calcular = new System.Windows.Forms.Button();
            this.tx_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo de IMC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tx_nome
            // 
            this.tx_nome.AutoSize = true;
            this.tx_nome.BackColor = System.Drawing.Color.Transparent;
            this.tx_nome.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_nome.Location = new System.Drawing.Point(51, 79);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(75, 26);
            this.tx_nome.TabIndex = 1;
            this.tx_nome.Text = "Nome:";
            this.tx_nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.BackColor = System.Drawing.Color.Transparent;
            this.cpf.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(328, 79);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(58, 26);
            this.cpf.TabIndex = 2;
            this.cpf.Text = "CPF:";
            this.cpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combobox_genero
            // 
            this.combobox_genero.AutoSize = true;
            this.combobox_genero.BackColor = System.Drawing.Color.Transparent;
            this.combobox_genero.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_genero.Location = new System.Drawing.Point(328, 147);
            this.combobox_genero.Name = "combobox_genero";
            this.combobox_genero.Size = new System.Drawing.Size(90, 26);
            this.combobox_genero.TabIndex = 3;
            this.combobox_genero.Text = "Gênero:";
            this.combobox_genero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_peso
            // 
            this.lb_peso.AutoSize = true;
            this.lb_peso.BackColor = System.Drawing.Color.Transparent;
            this.lb_peso.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_peso.Location = new System.Drawing.Point(47, 147);
            this.lb_peso.Name = "lb_peso";
            this.lb_peso.Size = new System.Drawing.Size(67, 26);
            this.lb_peso.TabIndex = 4;
            this.lb_peso.Text = "Peso:";
            this.lb_peso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_altura
            // 
            this.lb_altura.AutoSize = true;
            this.lb_altura.BackColor = System.Drawing.Color.Transparent;
            this.lb_altura.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_altura.Location = new System.Drawing.Point(133, 147);
            this.lb_altura.Name = "lb_altura";
            this.lb_altura.Size = new System.Drawing.Size(79, 26);
            this.lb_altura.TabIndex = 5;
            this.lb_altura.Text = "Altura:";
            this.lb_altura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_idade
            // 
            this.lb_idade.AutoSize = true;
            this.lb_idade.BackColor = System.Drawing.Color.Transparent;
            this.lb_idade.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idade.Location = new System.Drawing.Point(236, 147);
            this.lb_idade.Name = "lb_idade";
            this.lb_idade.Size = new System.Drawing.Size(73, 26);
            this.lb_idade.TabIndex = 6;
            this.lb_idade.Text = "Idade:";
            this.lb_idade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_idade.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 22);
            this.textBox1.TabIndex = 7;
            // 
            // tx_cpf
            // 
            this.tx_cpf.Location = new System.Drawing.Point(324, 108);
            this.tx_cpf.Mask = "000,000,000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(121, 22);
            this.tx_cpf.TabIndex = 8;
            this.tx_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tx_peso
            // 
            this.tx_peso.Location = new System.Drawing.Point(47, 178);
            this.tx_peso.Name = "tx_peso";
            this.tx_peso.Size = new System.Drawing.Size(67, 22);
            this.tx_peso.TabIndex = 9;
            // 
            // tx_altura
            // 
            this.tx_altura.Location = new System.Drawing.Point(135, 176);
            this.tx_altura.Name = "tx_altura";
            this.tx_altura.Size = new System.Drawing.Size(77, 22);
            this.tx_altura.TabIndex = 10;
            // 
            // combo_genero
            // 
            this.combo_genero.FormattingEnabled = true;
            this.combo_genero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Prefiro não dizer"});
            this.combo_genero.Location = new System.Drawing.Point(324, 176);
            this.combo_genero.Name = "combo_genero";
            this.combo_genero.Size = new System.Drawing.Size(121, 24);
            this.combo_genero.TabIndex = 11;
            // 
            // tx_idade
            // 
            this.tx_idade.Location = new System.Drawing.Point(236, 176);
            this.tx_idade.Name = "tx_idade";
            this.tx_idade.Size = new System.Drawing.Size(73, 22);
            this.tx_idade.TabIndex = 12;
            // 
            // button_calcular
            // 
            this.button_calcular.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_calcular.Location = new System.Drawing.Point(47, 237);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(148, 33);
            this.button_calcular.TabIndex = 13;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // tx_resultado
            // 
            this.tx_resultado.AutoSize = true;
            this.tx_resultado.BackColor = System.Drawing.Color.Transparent;
            this.tx_resultado.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_resultado.Location = new System.Drawing.Point(51, 273);
            this.tx_resultado.Name = "tx_resultado";
            this.tx_resultado.Size = new System.Drawing.Size(264, 78);
            this.tx_resultado.TabIndex = 14;
            this.tx_resultado.Text = "Seu IMC é:\r\nSua classificação é:\r\nSeu nível de obesidade é:";
            this.tx_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tx_resultado.Click += new System.EventHandler(this.tx_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImage = global::Aula3.Properties.Resources.Untitled_design__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.tx_resultado);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.tx_idade);
            this.Controls.Add(this.combo_genero);
            this.Controls.Add(this.tx_altura);
            this.Controls.Add(this.tx_peso);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_idade);
            this.Controls.Add(this.lb_altura);
            this.Controls.Add(this.lb_peso);
            this.Controls.Add(this.combobox_genero);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tx_nome;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label combobox_genero;
        private System.Windows.Forms.Label lb_peso;
        private System.Windows.Forms.Label lb_altura;
        private System.Windows.Forms.Label lb_idade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.TextBox tx_peso;
        private System.Windows.Forms.TextBox tx_altura;
        private System.Windows.Forms.ComboBox combo_genero;
        private System.Windows.Forms.TextBox tx_idade;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label tx_resultado;
    }
}

