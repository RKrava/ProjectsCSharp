using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (ServiceController service in ServiceController.GetServices())
            {
                if(service.DisplayName == "TektonIT - RMS Host")
                {
                    MessageBox.Show("1");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
