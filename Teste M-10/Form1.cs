using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_M_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DesabilitarCampos();
        }

        private void DesabilitarCampos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is ComboBox || control is GroupBox)
                {
                    control.Enabled = false;
                    control.BackColor = System.Drawing.Color.LightGray;
                }
            }
        }

        private void button_Iniciar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is ComboBox || control is GroupBox)
                {
                    control.Enabled = true;
                    control.BackColor = System.Drawing.Color.White;
                }
            }
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control == textBox_Valor_Pagar)
                {
                    control.Enabled = false;
                }
                else if (control is TextBox && control == textBox_Categoria)
                {
                    control.Enabled = false;
                }
            }
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {

            foreach (var control in this.Controls.OfType<CheckBox>())
            {
                control.Checked = false;
            }

            radioButton_xBox.Enabled = false;
            radioButton_Playstation.Enabled = false;
            radioButton_wii.Enabled = false;

            textBox_Categoria.Clear();
            textBox_Nome_Jogo.Clear();  
            textBox_Preço.Clear();
            textBox_Quantidade.Clear();
            textBox_Valor_Pagar.Clear();
        }

        private void button_Valor_Pagar_Click(object sender, EventArgs e)
        {

        }

       
    }
}


    

