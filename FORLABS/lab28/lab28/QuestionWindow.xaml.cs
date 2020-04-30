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

namespace lab28
{
	/// <summary>
	/// Логика взаимодействия для QuestionWindow.xaml
	/// </summary>
	public partial class QuestionWindow : Window
	{
		public QuestionWindow()
		{
			InitializeComponent();

		}

		public void Answer(int answ)
		{
			Question q = DataContext as Question;
			DialogResult = q.CorrectAnswer == answ;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Answer(1);
			this.Close();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Answer(2);
			this.Close();
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			Answer(3);
			this.Close();
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			Answer(4);
			this.Close();
		}
	}
}
