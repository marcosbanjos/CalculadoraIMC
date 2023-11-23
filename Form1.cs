using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal peso = Convert.ToDecimal(txtPeso.Text);
            decimal altura = Convert.ToDecimal(txtAltura.Text);
            string sexo = cmbSexo.SelectedItem.ToString();
            decimal resultado = 0;

            resultado = peso / (altura * altura);

            lblResultado.Text = resultado.ToString();

            lblAbaixo.BackColor = Color.White;
            lblNormal.BackColor = Color.White;
            lblAcima.BackColor = Color.White;
            lblObeso.BackColor = Color.White;
            lblObeso2.BackColor = Color.White;
            lblObeso3.BackColor = Color.White;

            if (resultado < 18.5m)
            {
                lblAbaixo.BackColor = Color.Red;
            }
            else if (resultado > 18.5m && resultado < 24.99m)
            {
                lblNormal.BackColor = Color.Green;
            }
            else if (resultado > 25m && resultado < 29.99m)
            {
                lblAcima.BackColor = Color.Orange;
            }
            else if (resultado > 30m && resultado < 34.99m)
            {
                lblObeso.BackColor = Color.Orange;
            }
            else if (resultado > 35m && resultado < 39.99m)
            {
                lblObeso2.BackColor = Color.Red;
            }
            else
            {
                lblObeso3.BackColor = Color.Red;
            }
        }

        
    }
}
