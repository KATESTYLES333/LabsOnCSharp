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

namespace lab23
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public MainWindow()
		{
			InitializeComponent();

			List<string> styles = new List<string> { "light", "dark" };
			Dark.Click += ThemeChange;
			Light.Click += ThemeChange;
		}

		string str = "";

		private void ThemeChange(object sender, RoutedEventArgs e)
		{
			string style = str as string;
			// определяем путь к файлу ресурсов
			var uri = new Uri(style + ".xaml", UriKind.Relative);
			// загружаем словарь ресурсов
			ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
			// очищаем коллекцию ресурсов приложения
			Application.Current.Resources.Clear();
			// добавляем загруженный словарь ресурсов
			Application.Current.Resources.MergedDictionaries.Add(resourceDict);
		}

		private void Button_Click_23(object sender, RoutedEventArgs e)
		{
			
		}

		private void Button_Click_31(object sender, RoutedEventArgs e)
		{
			dataselect wnd = new dataselect();
			wnd.Style = this.Style;
			wnd.Title = LAB31.Content.ToString();
			wnd.Icon = this.Icon;
			wnd.ShowDialog();
		}

		private void Button_Click_33(object sender, RoutedEventArgs e)
		{
			lab33 wnd = new lab33();
			wnd.Style = this.Style;
			wnd.Title = LAB33.Content.ToString();
			wnd.Icon = this.Icon;
			wnd.ShowDialog();
		}

		private void Button_Click_26(object sender, RoutedEventArgs e)
		{
			Lab26 wnd = new Lab26();
			wnd.Style = this.Style;
			wnd.Title = LAB26.Content.ToString();
			wnd.Icon = this.Icon;
			wnd.ShowDialog();
		}

		private void Button_Click_28(object sender, RoutedEventArgs e)
		{
			List<Question> questions = new List<Question>()
			{
				new Question(){ FirstAnswer = "Ковер Серпинского", SecondAnswer = "Кривая дракона", ThirdAnswer = "Папоротник Барнсли", FourthAnswer = "Дерево Пифагора", QuestionText = "Вы разбираетесь во фракталах? Что под номером 1?", CorrectAnswer = 2, ImgPath="/lab23;component/img/firstImg.png"},
				new Question(){ FirstAnswer = "Этим ученым был Альберт Эйнштейн", SecondAnswer = "Вацлав Серпинский", ThirdAnswer = "Герберт Эдельсбруннер", FourthAnswer = "Стивен Хокинг", QuestionText = "Кто из перечисленных ученых не родился сегодня, 14-го марта?", CorrectAnswer = 4, ImgPath="/lab23;component/img/secondImg.png"},
				new Question(){ FirstAnswer = "Абстрактная чепуха", SecondAnswer = "Штука", ThirdAnswer = "Микроб", FourthAnswer = "Тропическая геометрия", QuestionText = "Каких математических терминов не существует?", CorrectAnswer = 3, ImgPath="/lab23;component/img/thirdImg.png"},
				new Question(){ FirstAnswer = "Амеба", SecondAnswer = "Инфузория-туфелька", ThirdAnswer = "Тихоходка", FourthAnswer = "Глобигерина", QuestionText = "Тем не менее скажите, какой микроб перед вами?", CorrectAnswer = 1, ImgPath="/lab23;component/img/fourthImg.png"},
				new Question(){ FirstAnswer = "Это тривиально — 1", SecondAnswer = "Элементарно — 2", ThirdAnswer = "Очевидно — 3", FourthAnswer = "Легко видеть, что — 4", QuestionText = "На картинке четыре разных вида сфер. Найдите среди них рогатую сферу Александера!", CorrectAnswer = 2, ImgPath="/lab23;component/img/fifthImg.png"},
				new Question(){ FirstAnswer = "Теоремы о бутерброде", SecondAnswer = "Теоремы о двух милиционерах", ThirdAnswer = "Теоремы о причесывании ежа", FourthAnswer = "Теоремы об одиноком бегуне", QuestionText = "Какой теоремы не существует?", CorrectAnswer = 4, ImgPath="/lab23;component/img/SixImg.png"},
				new Question(){ FirstAnswer = "Односвязное компактное трехмерное многообразие гомеоморфное трехмерной сфере без края", SecondAnswer = "Односвязное компактное трехмерное многообразие без края гомеоморфно трехмерной сфере", ThirdAnswer = "Трехмерное компактное многообразие без края гомеоморфное сфере односвязно", FourthAnswer = "Компактное односвязное многообразие без края гомеоморфное сфере трехмерно", QuestionText = "Как формулируется знаменитая гипотеза Пуанкаре, доказанная в 2003 году Григорием Перельманом?", CorrectAnswer = 2, ImgPath="/lab23;component/img/seventhImg.png"},
				new Question(){ FirstAnswer = "2011 и 2017", SecondAnswer = "2013 и 2019", ThirdAnswer = "2027 и 2029", FourthAnswer = "Pi и e", QuestionText = "Ладно, настало время настоящей математики. Сконцентрируйтесь. Какие из этих пар чисел являются сексуальными простыми?", CorrectAnswer = 1, ImgPath="/lab23;component/img/eightsImg.png"}
			};

			Lab28 wnd = new Lab28();
			wnd.Style = this.Style;
			wnd.Title = LAB28.Content.ToString();
			wnd.Icon = this.Icon;
			int score = 0;
			foreach (var q in questions)
			{
				wnd.DataContext = q;
				if (wnd.ShowDialog().Value)
				{
					++score;
				}
			}
			MessageBox.Show("Score: " + score);
		}

		private void Button_Click_30(object sender, RoutedEventArgs e)
		{
			lab30 wnd = new lab30();
			wnd.Style = this.Style;
			wnd.Title = LAB30.Content.ToString();
			wnd.Icon = this.Icon;
			wnd.ShowDialog();
		}

		private void Dark_Click(object sender, RoutedEventArgs e)
		{
			str = Dark.Content.ToString();
		}

		private void Light_Click(object sender, RoutedEventArgs e)
		{
			str = Light.Content.ToString();
		}
	}
}
