using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXeKhach
{
    public partial class frmDecorPage : Form
    {
        public frmDecorPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
