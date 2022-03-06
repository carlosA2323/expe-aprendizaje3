using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://www.youtube.com/watch?v=gqo2TGpCOlA
namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            chart1.Series["Huracanes"].Points.AddXY("C1", 3);
            chart1.Series["Huracanes"].Points.AddXY("C3", 2);
            chart1.Series["Huracanes"].Points.AddXY("C4", 2);
            chart1.Series["Huracanes"].Points.AddXY("TS", 1);
            chart1.Series["Huracanes"].Points.AddXY("TT", 13);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
