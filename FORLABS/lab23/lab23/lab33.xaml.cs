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
using System.Windows.Forms;
using System.Diagnostics;

namespace lab23
{
	/// <summary>
	/// Логика взаимодействия для lab33.xaml
	/// </summary>
	public partial class lab33 : Window
	{
		public lab33()
		{
			InitializeComponent();
		}

		private void SaveText(string text)
		{
			using (var saveFileDialog1 = new SaveFileDialog())
			{
				if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
					return;
				string filename = saveFileDialog1.FileName;
				System.IO.File.WriteAllText(filename, text);
				System.Windows.MessageBox.Show("Файл сохранен");
			}
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			string textToSave = txxtBox.Text;
			SaveText(textToSave);

		}

		private void MenuItem_Click_1(object sender, RoutedEventArgs e)
		{
			using (var openFileDialog = new OpenFileDialog())
			{

				if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
					return;
				// получаем выбранный файл
				string filename = openFileDialog.FileName;
				System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(filename);
				psi.Verb = "PRINT";

				Process.Start(psi);
			}
		}

		private void MenuItem_Click_2(object sender, RoutedEventArgs e)
		{
			//this.Close();
			DialogResult = false;
		}

		private void MenuItem_Click_3(object sender, RoutedEventArgs e)
		{
			System.Windows.Application.Current.Shutdown();
		}

		private void MenuItem_Click_4(object sender, RoutedEventArgs e)
		{
			string subStr = "s";
			int start = txxtBox.Text.IndexOf(subStr);
			if (start == -1)
			{
				return;
			}
			txxtBox.Focus();
			txxtBox.Select(start, subStr.Length);
		}
	}
}
