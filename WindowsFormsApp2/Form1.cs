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
        
        string[] usernames = { "user1", "user2", "user3", "user4", "user5" };
        string[] passwords = { "pass1", "pass2", "pass3", "pass4", "pass5" };
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= usernames.Length; i++)
            {
              //  for (int j = 0; j <= passwords.Length; j++)
              //  {
                    ////https://www.youtube.com/watch?v=n2FWwmgMKok
                    if (tbUsuario.Text == usernames[i] && tbContrasena.Text == passwords[i])
                    {
                        new Form2().Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                            if (usernames.Length != i + 1)
                        {
                               
                        }
                            else
                        {
                            MessageBox.Show("Error al loguearse");
                            break;
                        }
                    }

                //}
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
