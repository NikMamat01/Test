using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест_форма
{
    public partial class Рандом : Form
    {
        public Рандом()
        {
            InitializeComponent();
        }

        private void random1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random0 = rnd.Next(1, 1000000);
            chislo.Text = Convert.ToString(random0);
        }
    }
}
