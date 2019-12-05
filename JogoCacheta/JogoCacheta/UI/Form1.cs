using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoCacheta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_novo_jogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (radio7.Checked)
            {
                UI.Form2 f2 = new UI.Form2(Convert.ToByte(input_qtdjog.Value), 7);
                f2.ShowDialog();
            }
            else
            {
                UI.Form2 f2 = new UI.Form2(Convert.ToByte(input_qtdjog.Value), 10);
                f2.ShowDialog();
            }
            this.Show();
        }
    }
}
