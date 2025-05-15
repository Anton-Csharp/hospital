using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace приложение
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataUser = LoadDataUser();
        }
        List<string> dataUser = new List<string>();
        bool pan = true;
        Form CurrentChildForm;
        public void OpenChildForm(Form ChildForm)
        {
            
            panelShowForm.Visible = true;
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }
            CurrentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelShowForm.Controls.Add(ChildForm);
            panelShowForm.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        //вход
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataUser.Count >0)
            {
                string login = textBox1.Text;
                string password = textBox2.Text;
                if (CheckUser(login,password))
                {
                    MessageBox.Show("Готово");
                    ShowData(false);
                    return;
                }
                MessageBox.Show("Неверный логин или пароль!!");
                
            }
            else
            {
                MessageBox.Show("такого пользователя нету!!!");
            }
        }
        //рег
        private void button2_Click(object sender, EventArgs e)
        {
            if (!CheckUser(textBox3.Text ,textBox4.Text ))
            {
                saveDataUser(textBox3.Text, textBox3.Text);
                MessageBox.Show("Вы зарегестрированы");
                return;
            }
            MessageBox.Show("Такой пользователь уже существует!");
        }
        //данные пациента
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != ""&& textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox8.Text != "" )
            {
                MessageBox.Show("данные отправлены");
            }
            else
            {
                MessageBox.Show("введите все данные!");
            }
        }
        //запись талона
        private void label9_Click(object sender, EventArgs e)
        {
            panelShowForm.Visible = pan;
            OpenChildForm(new form10("123"));
        }
        //мои талоны
        private void label10_Click(object sender, EventArgs e)
        {
            panelShowForm.Visible = pan;
            OpenChildForm(new form2());

        }
        //просмотр участка
        private void label11_Click(object sender, EventArgs e)
        {
            panelShowForm.Visible = pan;
            OpenChildForm(new form3());

        }
        //все врачи
        private void label12_Click(object sender, EventArgs e)
        {
            panelShowForm.Visible = pan;
            OpenChildForm(new form4());

        }
        //обратная связь
        private void label13_Click(object sender, EventArgs e)
        {
            panelShowForm.Visible = pan;
            OpenChildForm(new form5());

        }
        public void saveDataUser (string login,string password)
        {
            File.AppendAllText("dataUser", $"{login}|{password}\n");
        }
        public void ShowData (bool v)
        {
            panel.Visible = v;
        }
        public List<string> LoadDataUser()
        {
            if (File.Exists("dataUser"))
            {
                return File.ReadAllLines("dataUser").ToList();
            }
            return new List<string>();
        }
        public bool CheckUser(string login,string password)
        {
            dataUser.Clear();
            dataUser = LoadDataUser();
            foreach (string data in dataUser)
            {
                string[] dataUser = data.Split('|');
                if (dataUser[0]== login && dataUser[1]==password)
                {
                    return true;
                }
            }
            return false ;
        }
        //главное меню
        private void label22_Click(object sender, EventArgs e)
        {
            panelShowForm.Visible = false;
        }
    }
}
