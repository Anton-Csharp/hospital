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
        
        public form10()//конструтор - это метод
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = comboBox1.SelectedItem.ToString();
            string text2 = comboBox2.SelectedItem.ToString();
            string text3 = comboBox3.SelectedItem.ToString();
            if (comboBox1.SelectedItem.ToString() != "" && comboBox2.SelectedItem.ToString() != "" && comboBox3.SelectedItem.ToString() != "")
            {
                if (label6.Text == "")
                {
                    label6.Text = "время:" + text1 + "     специалист:" + text2 + "     место" + text3;
                }
                else
                {
                    if (label7.Text == "")
                    {
                        label7.Text = "время:" + text1 + "     специалист:" + text2 + "    место" + text3;
                    }
                    else
                    {
                        if (label8.Text == "")
                        {
                            label8.Text = "время:" + text1 + "    специалист:" + text2 + "     место" + text3;
                        }
                        else
                        {
                            MessageBox.Show("Достигнута максимальное количество талонов");
                        }
                    }
                }
            }
           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }
    }
}
