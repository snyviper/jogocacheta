using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JogoCacheta.Model;

namespace JogoCacheta.UI
{
    public partial class Form2 : Form
    {
        private int CodJogo { get; set; }
        private byte QtdJog { get; set; }
        public Form2(byte qtdjog, byte maxpontos)
        {
            this.CodJogo = Jogo.NovoJogo(qtdjog, maxpontos);
            this.QtdJog = qtdjog;
            InitializeComponent();
            if (this.QtdJog < 5)
            {
                groupBox5.Enabled = false;
                if (this.QtdJog < 4)
                {
                    groupBox4.Enabled = false;
                    if (this.QtdJog < 3)
                    {
                        groupBox3.Enabled = false;
                    }
                }
            }
            label_pontos1value.Text = maxpontos.ToString();
            label_pontos2value.Text = maxpontos.ToString();
            if (this.QtdJog > 2)
            {
                label_pontos3value.Text = maxpontos.ToString();
                if (this.QtdJog > 3)
                {
                    label_pontos4value.Text = maxpontos.ToString();
                    if (this.QtdJog > 4)
                    {
                        label_pontos5value.Text = maxpontos.ToString();
                    }
                }
            }
        }

        private void AtualizaGroupBox()
        {
            if (Jogo.GetPontos1(this.CodJogo) == 0)
            {
                groupBox1.Enabled = false;
            }
            if (Jogo.GetPontos2(this.CodJogo) == 0)
            {
                groupBox2.Enabled = false;
            }
            if (this.QtdJog > 2)
            {
                if (Jogo.GetPontos3(this.CodJogo) == 0)
                {
                    groupBox3.Enabled = false;
                }
                if (this.QtdJog > 3)
                {
                    if (Jogo.GetPontos4(this.CodJogo) == 0)
                    {
                        groupBox4.Enabled = false;
                    }
                    if (this.QtdJog > 4)
                    {
                        if (Jogo.GetPontos5(this.CodJogo) == 0)
                        {
                            groupBox5.Enabled = false;
                        }
                    }
                }
            }
        }
        private bool CheckChecked()
        {
            return (radio_1_desistiu.Checked || radio_1_perdeu.Checked || radio_1_ganhou.Checked || !groupBox1.Enabled)
                && (radio_2_desistiu.Checked || radio_2_perdeu.Checked || radio_2_ganhou.Checked || !groupBox2.Enabled)
                && (radio_3_desistiu.Checked || radio_3_perdeu.Checked || radio_3_ganhou.Checked || !groupBox3.Enabled)
                && (radio_4_desistiu.Checked || radio_4_perdeu.Checked || radio_4_ganhou.Checked || !groupBox4.Enabled)
                && (radio_5_desistiu.Checked || radio_5_perdeu.Checked || radio_5_ganhou.Checked || !groupBox5.Enabled)
                && (radio_1_ganhou.Checked || radio_2_ganhou.Checked || radio_3_ganhou.Checked || radio_4_ganhou.Checked
                || radio_5_ganhou.Checked);
        }
        private void button_avancar_rodada_Click(object sender, EventArgs e)
        {
            byte jog1, jog2;
            try
            {
                if (CheckChecked())
                {
                    if (this.QtdJog > 4)
                    {
                        byte jog3, jog4, jog5;
                        if (radio_1_desistiu.Checked)
                        {
                            jog1 = 0;
                        }
                        else if (radio_1_perdeu.Checked)
                        {
                            jog1 = 1;
                        }
                        else
                        {
                            jog1 = 2;
                        }
                        if (radio_2_desistiu.Checked)
                        {
                            jog2 = 0;
                        }
                        else if (radio_2_perdeu.Checked)
                        {
                            jog2 = 1;
                        }
                        else
                        {
                            jog2 = 2;
                        }
                        if (radio_3_desistiu.Checked)
                        {
                            jog3 = 0;
                        }
                        else if (radio_3_perdeu.Checked)
                        {
                            jog3 = 1;
                        }
                        else
                        {
                            jog3 = 2;
                        }
                        if (radio_4_desistiu.Checked)
                        {
                            jog4 = 0;
                        }
                        else if (radio_4_perdeu.Checked)
                        {
                            jog4 = 1;
                        }
                        else
                        {
                            jog4 = 2;
                        }
                        if (radio_5_desistiu.Checked)
                        {
                            jog5 = 0;
                        }
                        else if (radio_5_perdeu.Checked)
                        {
                            jog5 = 1;
                        }
                        else
                        {
                            jog5 = 2;
                        }
                        if (Jogo.NovaRodada(this.CodJogo, jog1, jog2, jog3, jog4, jog5))
                        {
                            label_pontos1value.Text = Jogo.GetPontos1(this.CodJogo).ToString();
                            label_pontos2value.Text = Jogo.GetPontos2(this.CodJogo).ToString();
                            label_pontos3value.Text = Jogo.GetPontos3(this.CodJogo).ToString();
                            label_pontos4value.Text = Jogo.GetPontos4(this.CodJogo).ToString();
                            label_pontos5value.Text = Jogo.GetPontos5(this.CodJogo).ToString();
                            AtualizaGroupBox();
                            byte ganhador = Jogo.GetGanhador(this.CodJogo);
                            MessageBox.Show("Vitória do jogador " + ganhador + "!");
                            this.Close();
                        }
                        label_pontos1value.Text = Jogo.GetPontos1(this.CodJogo).ToString();
                        label_pontos2value.Text = Jogo.GetPontos2(this.CodJogo).ToString();
                        label_pontos3value.Text = Jogo.GetPontos3(this.CodJogo).ToString();
                        label_pontos4value.Text = Jogo.GetPontos4(this.CodJogo).ToString();
                        label_pontos5value.Text = Jogo.GetPontos5(this.CodJogo).ToString();
                    }
                    else if (this.QtdJog > 3)
                    {
                        byte jog3, jog4;
                        if (radio_1_desistiu.Checked)
                        {
                            jog1 = 0;
                        }
                        else if (radio_1_perdeu.Checked)
                        {
                            jog1 = 1;
                        }
                        else
                        {
                            jog1 = 2;
                        }
                        if (radio_2_desistiu.Checked)
                        {
                            jog2 = 0;
                        }
                        else if (radio_2_perdeu.Checked)
                        {
                            jog2 = 1;
                        }
                        else
                        {
                            jog2 = 2;
                        }
                        if (radio_3_desistiu.Checked)
                        {
                            jog3 = 0;
                        }
                        else if (radio_3_perdeu.Checked)
                        {
                            jog3 = 1;
                        }
                        else
                        {
                            jog3 = 2;
                        }
                        if (radio_4_desistiu.Checked)
                        {
                            jog4 = 0;
                        }
                        else if (radio_4_perdeu.Checked)
                        {
                            jog4 = 1;
                        }
                        else
                        {
                            jog4 = 2;
                        }
                        if (Jogo.NovaRodada(this.CodJogo, jog1, jog2, jog3, jog4))
                        {
                            label_pontos1value.Text = Jogo.GetPontos1(this.CodJogo).ToString();
                            label_pontos2value.Text = Jogo.GetPontos2(this.CodJogo).ToString();
                            label_pontos3value.Text = Jogo.GetPontos3(this.CodJogo).ToString();
                            label_pontos4value.Text = Jogo.GetPontos4(this.CodJogo).ToString();
                            AtualizaGroupBox();
                            byte ganhador = Jogo.GetGanhador(this.CodJogo);
                            MessageBox.Show("Vitória do jogador " + ganhador + "!");
                            this.Close();
                        }
                        label_pontos1value.Text = Jogo.GetPontos1(this.CodJogo).ToString();
                        label_pontos2value.Text = Jogo.GetPontos2(this.CodJogo).ToString();
                        label_pontos3value.Text = Jogo.GetPontos3(this.CodJogo).ToString();
                        label_pontos4value.Text = Jogo.GetPontos4(this.CodJogo).ToString();
                    }
                    else if (this.QtdJog > 2)
                    {
                        byte jog3;
                        if (radio_1_desistiu.Checked)
                        {
                            jog1 = 0;
                        }
                        else if (radio_1_perdeu.Checked)
                        {
                            jog1 = 1;
                        }
                        else
                        {
                            jog1 = 2;
                        }
                        if (radio_2_desistiu.Checked)
                        {
                            jog2 = 0;
                        }
                        else if (radio_2_perdeu.Checked)
                        {
                            jog2 = 1;
                        }
                        else
                        {
                            jog2 = 2;
                        }
                        if (radio_3_desistiu.Checked)
                        {
                            jog3 = 0;
                        }
                        else if (radio_3_perdeu.Checked)
                        {
                            jog3 = 1;
                        }
                        else
                        {
                            jog3 = 2;
                        }
                        if (Jogo.NovaRodada(this.CodJogo, jog1, jog2, jog3))
                        {
                            label_pontos1value.Text = Jogo.GetPontos1(this.CodJogo).ToString();
                            label_pontos2value.Text = Jogo.GetPontos2(this.CodJogo).ToString();
                            label_pontos3value.Text = Jogo.GetPontos3(this.CodJogo).ToString();
                            AtualizaGroupBox();
                            byte ganhador = Jogo.GetGanhador(this.CodJogo);
                            MessageBox.Show("Vitória do jogador " + ganhador + "!");
                            this.Close();
                        }
                        label_pontos1value.Text = Jogo.GetPontos1(this.CodJogo).ToString();
                        label_pontos2value.Text = Jogo.GetPontos2(this.CodJogo).ToString();
                        label_pontos3value.Text = Jogo.GetPontos3(this.CodJogo).ToString();
                    }
                    else
                    {
                        if (radio_1_desistiu.Checked)
                        {
                            jog1 = 0;
                        }
                        else if (radio_1_perdeu.Checked)
                        {
                            jog1 = 1;
                        }
                        else
                        {
                            jog1 = 2;
                        }
                        if (radio_2_desistiu.Checked)
                        {
                            jog2 = 0;
                        }
                        else if (radio_2_perdeu.Checked)
                        {
                            jog2 = 1;
                        }
                        else
                        {
                            jog2 = 2;
                        }
                        if (Jogo.NovaRodada(this.CodJogo, jog1, jog2))
                        {
                            label_pontos1value.Text = Jogo.GetPontos1(this.CodJogo).ToString();
                            label_pontos2value.Text = Jogo.GetPontos2(this.CodJogo).ToString();
                            AtualizaGroupBox();
                            byte ganhador = Jogo.GetGanhador(this.CodJogo);
                            MessageBox.Show("Vitória do jogador " + ganhador + "!");
                            this.Close();
                        }
                        label_pontos1value.Text = Jogo.GetPontos1(this.CodJogo).ToString();
                        label_pontos2value.Text = Jogo.GetPontos2(this.CodJogo).ToString();
                    }
                    AtualizaGroupBox();
                    label_rodada.Text = "Rodada " + Jogo.GetRodada(this.CodJogo);
                }
                else
                {
                    throw new Exception("Algum jogador precisa vencer a rodada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radio_1_ganhou_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_2_ganhou.Checked)
            {
                radio_2_ganhou.Checked = false;
                radio_2_perdeu.Checked = true;
                radio_1_ganhou.Checked = true;
            }
            if (this.QtdJog > 2)
            {
                if (radio_3_ganhou.Checked)
                {
                    radio_3_ganhou.Checked = false;
                    radio_3_perdeu.Checked = true;
                    radio_1_ganhou.Checked = true;
                }
                if (this.QtdJog > 3)
                {
                    if (radio_4_ganhou.Checked)
                    {
                        radio_4_ganhou.Checked = false;
                        radio_4_perdeu.Checked = true;
                        radio_1_ganhou.Checked = true;
                    }
                    if (this.QtdJog > 4)
                    {
                        if (radio_5_ganhou.Checked)
                        {
                            radio_5_ganhou.Checked = false;
                            radio_5_perdeu.Checked = true;
                            radio_1_ganhou.Checked = true;
                        }
                    }
                }
            }
        }

        private void radio_2_ganhou_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_1_ganhou.Checked)
            {
                radio_1_ganhou.Checked = false;
                radio_1_perdeu.Checked = true;
                radio_2_ganhou.Checked = true;
            }
            if (this.QtdJog > 2)
            {
                if (radio_3_ganhou.Checked)
                {
                    radio_3_ganhou.Checked = false;
                    radio_3_perdeu.Checked = true;
                    radio_2_ganhou.Checked = true;
                }
                if (this.QtdJog > 3)
                {
                    if (radio_4_ganhou.Checked)
                    {
                        radio_4_ganhou.Checked = false;
                        radio_4_perdeu.Checked = true;
                        radio_2_ganhou.Checked = true;
                    }
                    if (this.QtdJog > 4)
                    {
                        if (radio_5_ganhou.Checked)
                        {
                            radio_5_ganhou.Checked = false;
                            radio_5_perdeu.Checked = true;
                            radio_2_ganhou.Checked = true;
                        }
                    }
                }
            }
        }

        private void radio_3_ganhou_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_1_ganhou.Checked)
            {
                radio_1_ganhou.Checked = false;
                radio_1_perdeu.Checked = true;
                radio_3_ganhou.Checked = true;
            }
            if (radio_2_ganhou.Checked)
            {
                radio_2_ganhou.Checked = false;
                radio_2_perdeu.Checked = true;
                radio_3_ganhou.Checked = true;
            }
            if (this.QtdJog > 3)
            {
                if (radio_4_ganhou.Checked)
                {
                    radio_4_ganhou.Checked = false;
                    radio_4_perdeu.Checked = true;
                    radio_3_ganhou.Checked = true;
                }
                if (this.QtdJog > 4)
                {
                    if (radio_5_ganhou.Checked)
                    {
                        radio_5_ganhou.Checked = false;
                        radio_5_perdeu.Checked = true;
                        radio_3_ganhou.Checked = true;
                    }
                }
            }
        }

        private void radio_4_ganhou_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_1_ganhou.Checked)
            {
                radio_1_ganhou.Checked = false;
                radio_1_perdeu.Checked = true;
                radio_4_ganhou.Checked = true;
            }
            if (radio_2_ganhou.Checked)
            {
                radio_2_ganhou.Checked = false;
                radio_2_perdeu.Checked = true;
                radio_4_ganhou.Checked = true;
            }
            if (radio_3_ganhou.Checked)
            {
                radio_3_ganhou.Checked = false;
                radio_3_perdeu.Checked = true;
                radio_4_ganhou.Checked = true;
            }
            if (this.QtdJog > 4)
            {
                if (radio_5_ganhou.Checked)
                {
                    radio_5_ganhou.Checked = false;
                    radio_5_perdeu.Checked = true;
                    radio_4_ganhou.Checked = true;
                }
            }
        }

        private void radio_5_ganhou_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_1_ganhou.Checked)
            {
                radio_1_ganhou.Checked = false;
                radio_1_perdeu.Checked = true;
                radio_5_ganhou.Checked = true;
            }
            if (radio_2_ganhou.Checked)
            {
                radio_2_ganhou.Checked = false;
                radio_2_perdeu.Checked = true;
                radio_5_ganhou.Checked = true;
            }
            if (radio_3_ganhou.Checked)
            {
                radio_3_ganhou.Checked = false;
                radio_3_perdeu.Checked = true;
                radio_5_ganhou.Checked = true;
            }
            if (radio_4_ganhou.Checked)
            {
                radio_4_ganhou.Checked = false;
                radio_4_perdeu.Checked = true;
                radio_5_ganhou.Checked = true;
            }
        }
    }
}
