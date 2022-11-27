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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            this.Close();
        }

        private void InfoBox_TextChanged(object sender, EventArgs e)
        {
             
            using StreamReader sr = new StreamReader("Resources\\rules.txt"); //считываем файл правила игры
            InfoBox.Text = sr.ReadToEnd();
        }

      
    }
}
