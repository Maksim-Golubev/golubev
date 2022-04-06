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
using System.Windows.Shapes;

namespace DizXAML
{
    /// <summary>
    /// Логика взаимодействия для zayavki.xaml
    /// </summary>
    public partial class zayavki : Window
    {
        Zavob db;
        public zayavki()
        {
            InitializeComponent();
            db = new Zavob();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fio = textBox1.Text.Trim();
            string date = date1.Text.Trim();
            string pol = comboBox1.Text.Trim();
            string addres = textBox2.Text.Trim().ToLower();
            string passport = textBox3.Text.Trim().ToLower();
            if (fio.Length < 10)
            {
                textBox1.ToolTip = "Это поле введено не корректно!";
                textBox1.Background = Brushes.DarkRed;
            }
            else if (addres.Length < 15)
            {
                textBox2.ToolTip = "Это поле введено не корректно!";
                textBox2.Background = Brushes.DarkRed;
            }
            else if (passport.Length < 10)
            {
                textBox2.ToolTip = "Это поле введено не корректно!";
                textBox2.Background = Brushes.DarkRed;
            }
            else
            {
                textBox1.ToolTip = "";
                textBox1.Background = Brushes.Transparent;
                textBox2.ToolTip = "";
                textBox2.Background = Brushes.Transparent;
                textBox3.ToolTip = "";
                textBox3.Background = Brushes.Transparent;



                MessageBox.Show("Все хорошо!");


                Uc ucs = new Uc(fio, date, pol, addres, passport);

                db.Ucs.Add(ucs);
                db.SaveChanges();

            }
        }

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                Menu menu = new Menu();
                menu.Show();
                Hide();
            }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    }

