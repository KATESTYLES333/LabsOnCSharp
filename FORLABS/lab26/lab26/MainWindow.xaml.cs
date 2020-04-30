using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace lab26
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void EmailBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void PasswordBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Regex reg = new Regex(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$");
			if (string.IsNullOrEmpty(emailBox.Text) || !reg.IsMatch(emailBox.Text))
			{
				MessageBox.Show("Wrong email");
				return;
			}
			if (string.IsNullOrEmpty(passwordBox.Text))
			{
				MessageBox.Show("Wrong password");
				return;
			}
			MessageBox.Show("Good job");
			AuthorizationInfo info = new AuthorizationInfo() { Email = emailBox.Text, Password = passwordBox.Text };
			this.Close();
		}

		private void Hyperlink_Click(object sender, RoutedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://oz.by/");
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.facebook.com/");
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://auth.oz.by/index.phtml?action=loginByProvider&provider_id=mailru");
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://vk.com/ozby_books");
		}
	}
}
