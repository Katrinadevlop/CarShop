using CarShopWpf.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace CarShopWpf
{
    public partial class MainWindow : Window
    {
        AppContent db;

        public MainWindow()
        {
            InitializeComponent();
            var registrationTabs = MainTabControl.Items.Cast<TabItem>().FirstOrDefault(item => item.Header.ToString() == "Регистрация");
            var mainMenuTab = MainTabControl.Items.Cast<TabItem>().FirstOrDefault(item => item.Header.ToString() == "Главное меню");
            var basketTab = MainTabControl.Items.Cast<TabItem>().FirstOrDefault(item => item.Header.ToString() == "Корзина");
            var profilTab = MainTabControl.Items.Cast<TabItem>().FirstOrDefault(item => item.Header.ToString() == "Профиль");
            /*db = new AppContent();
            List<Registrations> registrations = db.Registrations.ToList();
            string str = "";
            foreach (Registrations registration in registrations)
            {
                str += "Name " + registration.Name + " Surname " + registration.Surname;
            }
            list.Items.Add(str);*/
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var registrationTab = MainTabControl.Items.Cast<TabItem>().FirstOrDefault(item => item.Header.ToString() == "Регистрация");
            
            if (MainTabControl.SelectedItem is TabItem selectedTab)
            {
                switch (selectedTab.Header.ToString())
                {
                    case "Регистрация":

                        break;
                    case "Главное меню":

                        break;
                    case "Корзина":

                        break;
                    case "Профиль":

                        break;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //регистрация
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string patronymic = patronymicTextBox.Text;
            string numberPhone = numberProneTextBox.Text;
            string city = cityTextBox.Text;
            string password = passwordTextBox.Text;
            MessageBox.Show(password);

            Registrations registrationTab = new Registrations(name, surname, patronymic, numberPhone, city, password);

            db.Registrations.Add(registrationTab);

            try
            {
                db.SaveChanges();
                MessageBox.Show("Data save");
            }
            catch (DbEntityValidationException ex)
            {
                // Логируем подробности ошибки валидации
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        // Можно вывести сообщение об ошибке в консоль или показать в UI
                        MessageBox.Show($"Свойство: {validationError.PropertyName}, Ошибка: {validationError.ErrorMessage}");
                    }
                }
            }

        }
    }
}
