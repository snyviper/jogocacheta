namespace JogoCacheta
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
            this.button_novo_jogo = new System.Windows.Forms.Button();
            this.label_qtdjog = new System.Windows.Forms.Label();
            this.input_qtdjog = new System.Windows.Forms.NumericUpDown();
            this.label_cacheta = new System.Windows.Forms.Label();
            this.label_pontos = new System.Windows.Forms.Label();
            this.radio7 = new System.Windows.Forms.RadioButton();
            this.radio10 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.input_qtdjog)).BeginInit();
            this.SuspendLayout();
            // 
            // button_novo_jogo
            // 
            this.button_novo_jogo.Location = new System.Drawing.Point(41, 155);
            this.button_novo_jogo.Name = "button_novo_jogo";
            this.button_novo_jogo.Size = new System.Drawing.Size(153, 23);
            this.button_novo_jogo.TabIndex = 1;
            this.button_novo_jogo.Text = "Novo Jogo";
            this.button_novo_jogo.UseVisualStyleBackColor = true;
            this.button_novo_jogo.Click += new System.EventHandler(this.button_novo_jogo_Click);
            // 
            // label_qtdjog
            // 
            this.label_qtdjog.AutoSize = true;
            this.label_qtdjog.Location = new System.Drawing.Point(38, 74);
            this.label_qtdjog.Name = "label_qtdjog";
            this.label_qtdjog.Size = new System.Drawing.Size(108, 13);
            this.label_qtdjog.TabIndex = 2;
            this.label_qtdjog.Text = "Número de jogadores";
            // 
            // input_qtdjog
            // 
            this.input_qtdjog.Location = new System.Drawing.Point(152, 72);
            this.input_qtdjog.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.input_qtdjog.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.input_qtdjog.Name = "input_qtdjog";
            this.input_qtdjog.Size = new System.Drawing.Size(42, 20);
            this.input_qtdjog.TabIndex = 0;
            this.input_qtdjog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_qtdjog.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label_cacheta
            // 
            this.label_cacheta.AutoSize = true;
            this.label_cacheta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cacheta.Location = new System.Drawing.Point(42, 20);
            this.label_cacheta.Name = "label_cacheta";
            this.label_cacheta.Size = new System.Drawing.Size(152, 24);
            this.label_cacheta.TabIndex = 3;
            this.label_cacheta.Text = "Jogo da Cacheta";
            // 
            // label_pontos
            // 
            this.label_pontos.AutoSize = true;
            this.label_pontos.Location = new System.Drawing.Point(53, 98);
            this.label_pontos.Name = "label_pontos";
            this.label_pontos.Size = new System.Drawing.Size(93, 13);
            this.label_pontos.TabIndex = 4;
            this.label_pontos.Text = "Máximo de pontos";
            // 
            // radio7
            // 
            this.radio7.AutoSize = true;
            this.radio7.Checked = true;
            this.radio7.Location = new System.Drawing.Point(152, 98);
            this.radio7.Name = "radio7";
            this.radio7.Size = new System.Drawing.Size(31, 17);
            this.radio7.TabIndex = 1;
            this.radio7.TabStop = true;
            this.radio7.Text = "7";
            this.radio7.UseVisualStyleBackColor = true;
            // 
            // radio10
            // 
            this.radio10.AutoSize = true;
            this.radio10.Location = new System.Drawing.Point(152, 121);
            this.radio10.Name = "radio10";
            this.radio10.Size = new System.Drawing.Size(37, 17);
            this.radio10.TabIndex = 2;
            this.radio10.TabStop = true;
            this.radio10.Text = "10";
            this.radio10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(232, 206);
            this.Controls.Add(this.radio10);
            this.Controls.Add(this.radio7);
            this.Controls.Add(this.label_pontos);
            this.Controls.Add(this.label_cacheta);
            this.Controls.Add(this.input_qtdjog);
            this.Controls.Add(this.label_qtdjog);
            this.Controls.Add(this.button_novo_jogo);
            this.Name = "Form1";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.input_qtdjog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_novo_jogo;
        private System.Windows.Forms.Label label_qtdjog;
        private System.Windows.Forms.NumericUpDown input_qtdjog;
        private System.Windows.Forms.Label label_cacheta;
        private System.Windows.Forms.Label label_pontos;
        private System.Windows.Forms.RadioButton radio7;
        private System.Windows.Forms.RadioButton radio10;
    }
}

