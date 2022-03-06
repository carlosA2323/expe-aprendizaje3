using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////https://www.youtube.com/watch?v=n2FWwmgMKok
            if (tbUsuario.Text =="Carlos" && tbContrasena.Text=="LaContrasenia")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al loguearse");
            }
        }
    }
}
