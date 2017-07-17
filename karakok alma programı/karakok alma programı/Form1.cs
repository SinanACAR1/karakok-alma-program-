using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace üs_alma_karakok_alma_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double karakök;

            karakök =Convert.ToDouble(textBox1.Text);
           
            karakök = Math.Sqrt(karakök);
            label4.Text = karakök.ToString();

           
        }
    }
}
