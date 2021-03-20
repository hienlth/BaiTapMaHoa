using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapMaHoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            var chuoiDaMaHoa = Ceasar.Encrypt(txtChuoiNhap.Text, int.Parse(txtK.Text));
            MessageBox.Show(chuoiDaMaHoa);
        }
    }
}
