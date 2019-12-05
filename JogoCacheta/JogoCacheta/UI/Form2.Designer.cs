namespace JogoCacheta.UI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_rodada = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_1_ganhou = new System.Windows.Forms.RadioButton();
            this.radio_1_perdeu = new System.Windows.Forms.RadioButton();
            this.label_pontos1value = new System.Windows.Forms.Label();
            this.label_pontos1 = new System.Windows.Forms.Label();
            this.radio_1_desistiu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_2_ganhou = new System.Windows.Forms.RadioButton();
            this.radio_2_perdeu = new System.Windows.Forms.RadioButton();
            this.label_pontos2value = new System.Windows.Forms.Label();
            this.label_pontos2 = new System.Windows.Forms.Label();
            this.radio_2_desistiu = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radio_3_ganhou = new System.Windows.Forms.RadioButton();
            this.radio_3_perdeu = new System.Windows.Forms.RadioButton();
            this.label_pontos3value = new System.Windows.Forms.Label();
            this.label_pontos3 = new System.Windows.Forms.Label();
            this.radio_3_desistiu = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radio_4_ganhou = new System.Windows.Forms.RadioButton();
            this.radio_4_perdeu = new System.Windows.Forms.RadioButton();
            this.label_pontos4value = new System.Windows.Forms.Label();
            this.label_pontos4 = new System.Windows.Forms.Label();
            this.radio_4_desistiu = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radio_5_ganhou = new System.Windows.Forms.RadioButton();
            this.radio_5_perdeu = new System.Windows.Forms.RadioButton();
            this.label_pontos5value = new System.Windows.Forms.Label();
            this.label_pontos5 = new System.Windows.Forms.Label();
            this.radio_5_desistiu = new System.Windows.Forms.RadioButton();
            this.button_avancar_rodada = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_rodada
            // 
            this.label_rodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rodada.Location = new System.Drawing.Point(123, 9);
            this.label_rodada.Name = "label_rodada";
            this.label_rodada.Size = new System.Drawing.Size(312, 23);
            this.label_rodada.TabIndex = 0;
            this.label_rodada.Text = "Rodada 1";
            this.label_rodada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_1_ganhou);
            this.groupBox1.Controls.Add(this.radio_1_perdeu);
            this.groupBox1.Controls.Add(this.label_pontos1value);
            this.groupBox1.Controls.Add(this.label_pontos1);
            this.groupBox1.Controls.Add(this.radio_1_desistiu);
            this.groupBox1.Location = new System.Drawing.Point(17, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogador 1";
            // 
            // radio_1_ganhou
            // 
            this.radio_1_ganhou.AutoSize = true;
            this.radio_1_ganhou.Location = new System.Drawing.Point(10, 84);
            this.radio_1_ganhou.Name = "radio_1_ganhou";
            this.radio_1_ganhou.Size = new System.Drawing.Size(63, 17);
            this.radio_1_ganhou.TabIndex = 2;
            this.radio_1_ganhou.TabStop = true;
            this.radio_1_ganhou.Text = "Ganhou";
            this.radio_1_ganhou.UseVisualStyleBackColor = true;
            this.radio_1_ganhou.CheckedChanged += new System.EventHandler(this.radio_1_ganhou_CheckedChanged);
            // 
            // radio_1_perdeu
            // 
            this.radio_1_perdeu.AutoSize = true;
            this.radio_1_perdeu.Location = new System.Drawing.Point(10, 60);
            this.radio_1_perdeu.Name = "radio_1_perdeu";
            this.radio_1_perdeu.Size = new System.Drawing.Size(59, 17);
            this.radio_1_perdeu.TabIndex = 1;
            this.radio_1_perdeu.TabStop = true;
            this.radio_1_perdeu.Text = "Perdeu";
            this.radio_1_perdeu.UseVisualStyleBackColor = true;
            // 
            // label_pontos1value
            // 
            this.label_pontos1value.AutoSize = true;
            this.label_pontos1value.Location = new System.Drawing.Point(50, 20);
            this.label_pontos1value.Name = "label_pontos1value";
            this.label_pontos1value.Size = new System.Drawing.Size(13, 13);
            this.label_pontos1value.TabIndex = 2;
            this.label_pontos1value.Text = "0";
            // 
            // label_pontos1
            // 
            this.label_pontos1.AutoSize = true;
            this.label_pontos1.Location = new System.Drawing.Point(7, 20);
            this.label_pontos1.Name = "label_pontos1";
            this.label_pontos1.Size = new System.Drawing.Size(43, 13);
            this.label_pontos1.TabIndex = 1;
            this.label_pontos1.Text = "Pontos:";
            // 
            // radio_1_desistiu
            // 
            this.radio_1_desistiu.AutoSize = true;
            this.radio_1_desistiu.Checked = true;
            this.radio_1_desistiu.Location = new System.Drawing.Point(10, 36);
            this.radio_1_desistiu.Name = "radio_1_desistiu";
            this.radio_1_desistiu.Size = new System.Drawing.Size(62, 17);
            this.radio_1_desistiu.TabIndex = 0;
            this.radio_1_desistiu.TabStop = true;
            this.radio_1_desistiu.Text = "Desistiu";
            this.radio_1_desistiu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_2_ganhou);
            this.groupBox2.Controls.Add(this.radio_2_perdeu);
            this.groupBox2.Controls.Add(this.label_pontos2value);
            this.groupBox2.Controls.Add(this.label_pontos2);
            this.groupBox2.Controls.Add(this.radio_2_desistiu);
            this.groupBox2.Location = new System.Drawing.Point(123, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jogador 2";
            // 
            // radio_2_ganhou
            // 
            this.radio_2_ganhou.AutoSize = true;
            this.radio_2_ganhou.Location = new System.Drawing.Point(10, 84);
            this.radio_2_ganhou.Name = "radio_2_ganhou";
            this.radio_2_ganhou.Size = new System.Drawing.Size(63, 17);
            this.radio_2_ganhou.TabIndex = 5;
            this.radio_2_ganhou.TabStop = true;
            this.radio_2_ganhou.Text = "Ganhou";
            this.radio_2_ganhou.UseVisualStyleBackColor = true;
            this.radio_2_ganhou.CheckedChanged += new System.EventHandler(this.radio_2_ganhou_CheckedChanged);
            // 
            // radio_2_perdeu
            // 
            this.radio_2_perdeu.AutoSize = true;
            this.radio_2_perdeu.Location = new System.Drawing.Point(10, 60);
            this.radio_2_perdeu.Name = "radio_2_perdeu";
            this.radio_2_perdeu.Size = new System.Drawing.Size(59, 17);
            this.radio_2_perdeu.TabIndex = 4;
            this.radio_2_perdeu.TabStop = true;
            this.radio_2_perdeu.Text = "Perdeu";
            this.radio_2_perdeu.UseVisualStyleBackColor = true;
            // 
            // label_pontos2value
            // 
            this.label_pontos2value.AutoSize = true;
            this.label_pontos2value.Location = new System.Drawing.Point(50, 20);
            this.label_pontos2value.Name = "label_pontos2value";
            this.label_pontos2value.Size = new System.Drawing.Size(13, 13);
            this.label_pontos2value.TabIndex = 2;
            this.label_pontos2value.Text = "0";
            // 
            // label_pontos2
            // 
            this.label_pontos2.AutoSize = true;
            this.label_pontos2.Location = new System.Drawing.Point(7, 20);
            this.label_pontos2.Name = "label_pontos2";
            this.label_pontos2.Size = new System.Drawing.Size(43, 13);
            this.label_pontos2.TabIndex = 1;
            this.label_pontos2.Text = "Pontos:";
            // 
            // radio_2_desistiu
            // 
            this.radio_2_desistiu.AutoSize = true;
            this.radio_2_desistiu.Checked = true;
            this.radio_2_desistiu.Location = new System.Drawing.Point(10, 36);
            this.radio_2_desistiu.Name = "radio_2_desistiu";
            this.radio_2_desistiu.Size = new System.Drawing.Size(62, 17);
            this.radio_2_desistiu.TabIndex = 3;
            this.radio_2_desistiu.TabStop = true;
            this.radio_2_desistiu.Text = "Desistiu";
            this.radio_2_desistiu.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radio_3_ganhou);
            this.groupBox3.Controls.Add(this.radio_3_perdeu);
            this.groupBox3.Controls.Add(this.label_pontos3value);
            this.groupBox3.Controls.Add(this.label_pontos3);
            this.groupBox3.Controls.Add(this.radio_3_desistiu);
            this.groupBox3.Location = new System.Drawing.Point(229, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 115);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jogador 3";
            // 
            // radio_3_ganhou
            // 
            this.radio_3_ganhou.AutoSize = true;
            this.radio_3_ganhou.Location = new System.Drawing.Point(10, 84);
            this.radio_3_ganhou.Name = "radio_3_ganhou";
            this.radio_3_ganhou.Size = new System.Drawing.Size(63, 17);
            this.radio_3_ganhou.TabIndex = 8;
            this.radio_3_ganhou.TabStop = true;
            this.radio_3_ganhou.Text = "Ganhou";
            this.radio_3_ganhou.UseVisualStyleBackColor = true;
            this.radio_3_ganhou.CheckedChanged += new System.EventHandler(this.radio_3_ganhou_CheckedChanged);
            // 
            // radio_3_perdeu
            // 
            this.radio_3_perdeu.AutoSize = true;
            this.radio_3_perdeu.Location = new System.Drawing.Point(10, 60);
            this.radio_3_perdeu.Name = "radio_3_perdeu";
            this.radio_3_perdeu.Size = new System.Drawing.Size(59, 17);
            this.radio_3_perdeu.TabIndex = 7;
            this.radio_3_perdeu.TabStop = true;
            this.radio_3_perdeu.Text = "Perdeu";
            this.radio_3_perdeu.UseVisualStyleBackColor = true;
            // 
            // label_pontos3value
            // 
            this.label_pontos3value.AutoSize = true;
            this.label_pontos3value.Location = new System.Drawing.Point(50, 20);
            this.label_pontos3value.Name = "label_pontos3value";
            this.label_pontos3value.Size = new System.Drawing.Size(13, 13);
            this.label_pontos3value.TabIndex = 2;
            this.label_pontos3value.Text = "0";
            // 
            // label_pontos3
            // 
            this.label_pontos3.AutoSize = true;
            this.label_pontos3.Location = new System.Drawing.Point(7, 20);
            this.label_pontos3.Name = "label_pontos3";
            this.label_pontos3.Size = new System.Drawing.Size(43, 13);
            this.label_pontos3.TabIndex = 1;
            this.label_pontos3.Text = "Pontos:";
            // 
            // radio_3_desistiu
            // 
            this.radio_3_desistiu.AutoSize = true;
            this.radio_3_desistiu.Checked = true;
            this.radio_3_desistiu.Location = new System.Drawing.Point(10, 36);
            this.radio_3_desistiu.Name = "radio_3_desistiu";
            this.radio_3_desistiu.Size = new System.Drawing.Size(62, 17);
            this.radio_3_desistiu.TabIndex = 6;
            this.radio_3_desistiu.TabStop = true;
            this.radio_3_desistiu.Text = "Desistiu";
            this.radio_3_desistiu.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radio_4_ganhou);
            this.groupBox4.Controls.Add(this.radio_4_perdeu);
            this.groupBox4.Controls.Add(this.label_pontos4value);
            this.groupBox4.Controls.Add(this.label_pontos4);
            this.groupBox4.Controls.Add(this.radio_4_desistiu);
            this.groupBox4.Location = new System.Drawing.Point(335, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 115);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Jogador 4";
            // 
            // radio_4_ganhou
            // 
            this.radio_4_ganhou.AutoSize = true;
            this.radio_4_ganhou.Location = new System.Drawing.Point(10, 84);
            this.radio_4_ganhou.Name = "radio_4_ganhou";
            this.radio_4_ganhou.Size = new System.Drawing.Size(63, 17);
            this.radio_4_ganhou.TabIndex = 11;
            this.radio_4_ganhou.TabStop = true;
            this.radio_4_ganhou.Text = "Ganhou";
            this.radio_4_ganhou.UseVisualStyleBackColor = true;
            this.radio_4_ganhou.CheckedChanged += new System.EventHandler(this.radio_4_ganhou_CheckedChanged);
            // 
            // radio_4_perdeu
            // 
            this.radio_4_perdeu.AutoSize = true;
            this.radio_4_perdeu.Location = new System.Drawing.Point(10, 60);
            this.radio_4_perdeu.Name = "radio_4_perdeu";
            this.radio_4_perdeu.Size = new System.Drawing.Size(59, 17);
            this.radio_4_perdeu.TabIndex = 10;
            this.radio_4_perdeu.TabStop = true;
            this.radio_4_perdeu.Text = "Perdeu";
            this.radio_4_perdeu.UseVisualStyleBackColor = true;
            // 
            // label_pontos4value
            // 
            this.label_pontos4value.AutoSize = true;
            this.label_pontos4value.Location = new System.Drawing.Point(50, 20);
            this.label_pontos4value.Name = "label_pontos4value";
            this.label_pontos4value.Size = new System.Drawing.Size(13, 13);
            this.label_pontos4value.TabIndex = 2;
            this.label_pontos4value.Text = "0";
            // 
            // label_pontos4
            // 
            this.label_pontos4.AutoSize = true;
            this.label_pontos4.Location = new System.Drawing.Point(7, 20);
            this.label_pontos4.Name = "label_pontos4";
            this.label_pontos4.Size = new System.Drawing.Size(43, 13);
            this.label_pontos4.TabIndex = 1;
            this.label_pontos4.Text = "Pontos:";
            // 
            // radio_4_desistiu
            // 
            this.radio_4_desistiu.AutoSize = true;
            this.radio_4_desistiu.Checked = true;
            this.radio_4_desistiu.Location = new System.Drawing.Point(10, 36);
            this.radio_4_desistiu.Name = "radio_4_desistiu";
            this.radio_4_desistiu.Size = new System.Drawing.Size(62, 17);
            this.radio_4_desistiu.TabIndex = 9;
            this.radio_4_desistiu.TabStop = true;
            this.radio_4_desistiu.Text = "Desistiu";
            this.radio_4_desistiu.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radio_5_ganhou);
            this.groupBox5.Controls.Add(this.radio_5_perdeu);
            this.groupBox5.Controls.Add(this.label_pontos5value);
            this.groupBox5.Controls.Add(this.label_pontos5);
            this.groupBox5.Controls.Add(this.radio_5_desistiu);
            this.groupBox5.Location = new System.Drawing.Point(441, 36);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(100, 115);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Jogador 5";
            // 
            // radio_5_ganhou
            // 
            this.radio_5_ganhou.AutoSize = true;
            this.radio_5_ganhou.Location = new System.Drawing.Point(10, 84);
            this.radio_5_ganhou.Name = "radio_5_ganhou";
            this.radio_5_ganhou.Size = new System.Drawing.Size(63, 17);
            this.radio_5_ganhou.TabIndex = 14;
            this.radio_5_ganhou.TabStop = true;
            this.radio_5_ganhou.Text = "Ganhou";
            this.radio_5_ganhou.UseVisualStyleBackColor = true;
            this.radio_5_ganhou.CheckedChanged += new System.EventHandler(this.radio_5_ganhou_CheckedChanged);
            // 
            // radio_5_perdeu
            // 
            this.radio_5_perdeu.AutoSize = true;
            this.radio_5_perdeu.Location = new System.Drawing.Point(10, 60);
            this.radio_5_perdeu.Name = "radio_5_perdeu";
            this.radio_5_perdeu.Size = new System.Drawing.Size(59, 17);
            this.radio_5_perdeu.TabIndex = 13;
            this.radio_5_perdeu.TabStop = true;
            this.radio_5_perdeu.Text = "Perdeu";
            this.radio_5_perdeu.UseVisualStyleBackColor = true;
            // 
            // label_pontos5value
            // 
            this.label_pontos5value.AutoSize = true;
            this.label_pontos5value.Location = new System.Drawing.Point(50, 20);
            this.label_pontos5value.Name = "label_pontos5value";
            this.label_pontos5value.Size = new System.Drawing.Size(13, 13);
            this.label_pontos5value.TabIndex = 2;
            this.label_pontos5value.Text = "0";
            // 
            // label_pontos5
            // 
            this.label_pontos5.AutoSize = true;
            this.label_pontos5.Location = new System.Drawing.Point(7, 20);
            this.label_pontos5.Name = "label_pontos5";
            this.label_pontos5.Size = new System.Drawing.Size(43, 13);
            this.label_pontos5.TabIndex = 1;
            this.label_pontos5.Text = "Pontos:";
            // 
            // radio_5_desistiu
            // 
            this.radio_5_desistiu.AutoSize = true;
            this.radio_5_desistiu.Checked = true;
            this.radio_5_desistiu.Location = new System.Drawing.Point(10, 36);
            this.radio_5_desistiu.Name = "radio_5_desistiu";
            this.radio_5_desistiu.Size = new System.Drawing.Size(62, 17);
            this.radio_5_desistiu.TabIndex = 12;
            this.radio_5_desistiu.TabStop = true;
            this.radio_5_desistiu.Text = "Desistiu";
            this.radio_5_desistiu.UseVisualStyleBackColor = true;
            // 
            // button_avancar_rodada
            // 
            this.button_avancar_rodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_avancar_rodada.Location = new System.Drawing.Point(17, 157);
            this.button_avancar_rodada.Name = "button_avancar_rodada";
            this.button_avancar_rodada.Size = new System.Drawing.Size(524, 40);
            this.button_avancar_rodada.TabIndex = 6;
            this.button_avancar_rodada.Text = "Avançar rodada";
            this.button_avancar_rodada.UseVisualStyleBackColor = true;
            this.button_avancar_rodada.Click += new System.EventHandler(this.button_avancar_rodada_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 211);
            this.Controls.Add(this.button_avancar_rodada);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_rodada);
            this.Name = "Form2";
            this.Text = "Jogo Cacheta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_rodada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_1_desistiu;
        private System.Windows.Forms.Label label_pontos1value;
        private System.Windows.Forms.Label label_pontos1;
        private System.Windows.Forms.RadioButton radio_1_ganhou;
        private System.Windows.Forms.RadioButton radio_1_perdeu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_2_ganhou;
        private System.Windows.Forms.RadioButton radio_2_perdeu;
        private System.Windows.Forms.Label label_pontos2value;
        private System.Windows.Forms.Label label_pontos2;
        private System.Windows.Forms.RadioButton radio_2_desistiu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radio_3_ganhou;
        private System.Windows.Forms.RadioButton radio_3_perdeu;
        private System.Windows.Forms.Label label_pontos3value;
        private System.Windows.Forms.Label label_pontos3;
        private System.Windows.Forms.RadioButton radio_3_desistiu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radio_4_ganhou;
        private System.Windows.Forms.RadioButton radio_4_perdeu;
        private System.Windows.Forms.Label label_pontos4value;
        private System.Windows.Forms.Label label_pontos4;
        private System.Windows.Forms.RadioButton radio_4_desistiu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radio_5_ganhou;
        private System.Windows.Forms.RadioButton radio_5_perdeu;
        private System.Windows.Forms.Label label_pontos5value;
        private System.Windows.Forms.Label label_pontos5;
        private System.Windows.Forms.RadioButton radio_5_desistiu;
        private System.Windows.Forms.Button button_avancar_rodada;
    }
}