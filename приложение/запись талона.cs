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
    public partial class form10 : Form
    {
        string text1;
        public form10(string text)//конструтор - это метод
        {
            InitializeComponent();
            text1 = text;
            MessageBox.Show(text);
        }
    }
}
