using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_2
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }

        public string CustomerType { get; set; }

        public string LastMonth { get; set; }

        public string ThisMonth { get; set; }

        public string Used { get; set; }

        public string Total { get; set; }


        private void Form3_Load(object sender, EventArgs e)
        {
            label15.Text = CustomerName;
            label16.Text = CustomerPhone;
            label17.Text = CustomerAddress;
            label18.Text = CustomerType;
            label19.Text = LastMonth;
            label20.Text = ThisMonth;
            label21.Text = Used;
            label22.Text = Total;
        }
    }
}
