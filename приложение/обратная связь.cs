using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace приложение
{
    public partial class form5 : Form
    {
        public form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(1, 10000);
            MessageBox.Show("вы в очереди,ваше место в очереди:"+num);
        }
    }
}
