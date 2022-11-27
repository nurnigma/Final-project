using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class BarOfAudience : Form
    {
        public BarOfAudience()
        {
            InitializeComponent();
        }

        
        public void audiance(int value1, int value2, int value3, int value4)  //четыер значения которая в сумме 100
        {
            progressBar1.Value = value1;
            progressBar2.Value = value2;
            progressBar3.Value = value3;
            progressBar4.Value = value4;
        }

    }
}
