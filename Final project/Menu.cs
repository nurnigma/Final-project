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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void rules_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            GameField gameField = new GameField(); //вызывасет игровое поле и показывем его
            gameField.Show();
            this.Hide(); // скрываем текущее окно
        }
        
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close(); //this ссылается на текущий экземпляр и закрывает меню
        }
    }
}
