using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7_hinhchunhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDt_Click(object sender, EventArgs e)
        {
            double dai, rong, dientich;

            dai = Convert.ToDouble(txtDAI.Text);

            rong = Convert.ToDouble(txtRong.Text);
            double s = dai * rong;
            txtKq.Text=s.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dai, rong, chuvi;

            dai = Convert.ToDouble(txtDAI.Text);

            rong = Convert.ToDouble(txtRong.Text);
            double p = (dai + rong) * 2;
            txtKq.Text = p.ToString();
        }
    }
}
