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

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double chieudai = double.Parse(txtDAI.Text);
            double chieurong = double.Parse(txtRong.Text);
            lblKQ.Text = "- Diện Tích  :"+ dientich(chieudai, chieurong)+"\n- Chu Vi :" + chuvi(chieudai, chieurong);
        }
        double dientich(double chieudai, double chieurong) { return chieudai * chieurong; }
        double chuvi(double chieudai, double chieurong) { return (chieudai + chieurong) * 2; }

       
    }

}