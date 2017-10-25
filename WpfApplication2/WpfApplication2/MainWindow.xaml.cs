using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public struct record
        {
            public string fName { get; set; }
            public string sName { get; set; }
            public string lName { get; set; }
            public string age { get; set; }
            public string fStat { get; set; }
            public string address { get; set; }
            public string email { get; set; }
            public string tel { get; set; }
            public bool c { get; set; }
            public bool cpp { get; set; }
            public bool csh { get; set; }
            public bool dNet { get; set; }
            public bool eng { get; set; }

        }

        public static List<record> users = new List<record>();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new record() {
                fName = textBox.Text.ToString(),
                sName = textBox1.Text.ToString(),
                lName = textBox2.Text.ToString(),
                age = textBox3.Text.ToString(),
                fStat = textBox4.Text.ToString(),
                address = textBox5.Text.ToString(),
                email = textBox6.Text.ToString(),
                tel = textBox7.Text.ToString(),
                c = checkBox.IsChecked.Value,
                cpp = checkBox1.IsChecked.Value,
                csh = checkBox2.IsChecked.Value,
                dNet = checkBox3.IsChecked.Value,
                eng = checkBox4.IsChecked.Value
            });

            listBox.Items.Add("Добавлено!");
            comboBox.Items.Add(textBox.Text.ToString() + " " + textBox1.Text.ToString());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            checkBox.IsChecked = false;
            checkBox1.IsChecked = false;
            checkBox2.IsChecked = false;
            checkBox3.IsChecked = false;
            checkBox4.IsChecked = false;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            try
            {
                foreach (var user in users)
                {
                    if ((user.fName.ToString() + " " + user.sName.ToString()) ==
                         comboBox.SelectedItem.ToString())
                    {
                        
                        listBox.Items.Add(
                            user.fName.ToString() + " " +
                            user.sName.ToString() + " " +
                            user.lName.ToString());
                        listBox.Items.Add("возраст: " + user.age.ToString());
                        listBox.Items.Add("семейное положение: " + user.fStat.ToString());
                        listBox.Items.Add("адрес: " + user.address.ToString());
                        listBox.Items.Add("e-mail" + user.email.ToString());
                        listBox.Items.Add("телефон: " + user.tel.ToString());
                        listBox.Items.Add(
                            checkBox.Content.ToString() + ": " + (user.c ? "Знает" : "Не знает") + "\t" +
                            checkBox1.Content.ToString() + ": " + (user.cpp ? "Знает" : "Не знает") + "\t" +
                            checkBox2.Content.ToString() + ": " + (user.csh ? "Знает" : "Не знает") + "\t" +
                            checkBox3.Content.ToString() + ": " + (user.dNet ? "Знает" : "Не знает") + "\t" +
                            checkBox4.Content.ToString() + ": " + (user.eng ? "Знает" : "Не знает"));
                        
                        listBox.Items.Add("");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Совпадений не найдено!");
            }
           
        }

        //fName = "Иванов", "Иван", "Иванович", "21", "Одесса, Дерибасовская", "mail@mail.com" 




    }
}
