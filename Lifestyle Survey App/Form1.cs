using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Fill_out_Click(object sender, EventArgs e)
        {
            Form2 obj2 = new Form2();
            obj2.Show();
            this.Visible=false;
        }

        private void btn_View_Results_Click(object sender, EventArgs e)
        {
            Form3 obj3 = new Form3();
            obj3.Show();
            this.Visible=false;
        }
    }
}
