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

namespace lab28
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			List<Question> questions = new List<Question>()
			{
				new Question(){ FirstAnswer = "Ковер Серпинского", SecondAnswer = "Кривая дракона", ThirdAnswer = "Папоротник Барнсли", FourthAnswer = "Дерево Пифагора", QuestionText = "Вы разбираетесь во фракталах? Что под номером 1?", CorrectAnswer = 2, ImgPath="/lab28;component/img/firstImg.png"},
				new Question(){ FirstAnswer = "Этим ученым был Альберт Эйнштейн", SecondAnswer = "Вацлав Серпинский", ThirdAnswer = "Герберт Эдельсбруннер", FourthAnswer = "Стивен Хокинг", QuestionText = "Кто из перечисленных ученых не родился сегодня, 14-го марта?", CorrectAnswer = 4, ImgPath="/lab28;component/img/secondImg.png"},
				new Question(){ FirstAnswer = "Абстрактная чепуха", SecondAnswer = "Штука", ThirdAnswer = "Микроб", FourthAnswer = "Тропическая геометрия", QuestionText = "Каких математических терминов не существует?", CorrectAnswer = 3, ImgPath="/lab28;component/img/thirdImg.png"},
				new Question(){ FirstAnswer = "Амеба", SecondAnswer = "Инфузория-туфелька", ThirdAnswer = "Тихоходка", FourthAnswer = "Глобигерина", QuestionText = "Тем не менее скажите, какой микроб перед вами?", CorrectAnswer = 1, ImgPath="/lab28;component/img/fourthImg.png"},
				new Question(){ FirstAnswer = "Это тривиально — 1", SecondAnswer = "Элементарно — 2", ThirdAnswer = "Очевидно — 3", FourthAnswer = "Легко видеть, что — 4", QuestionText = "На картинке четыре разных вида сфер. Найдите среди них рогатую сферу Александера!", CorrectAnswer = 2, ImgPath="/lab28;component/img/fifthImg.png"},
				new Question(){ FirstAnswer = "Теоремы о бутерброде", SecondAnswer = "Теоремы о двух милиционерах", ThirdAnswer = "Теоремы о причесывании ежа", FourthAnswer = "Теоремы об одиноком бегуне", QuestionText = "Какой теоремы не существует?", CorrectAnswer = 4, ImgPath="/lab28;component/img/SixImg.png"},
				new Question(){ FirstAnswer = "Односвязное компактное трехмерное многообразие гомеоморфное трехмерной сфере без края", SecondAnswer = "Односвязное компактное трехмерное многообразие без края гомеоморфно трехмерной сфере", ThirdAnswer = "Трехмерное компактное многообразие без края гомеоморфное сфере односвязно", FourthAnswer = "Компактное односвязное многообразие без края гомеоморфное сфере трехмерно", QuestionText = "Как формулируется знаменитая гипотеза Пуанкаре, доказанная в 2003 году Григорием Перельманом?", CorrectAnswer = 2, ImgPath="/lab28;component/img/seventhImg.png"},
				new Question(){ FirstAnswer = "2011 и 2017", SecondAnswer = "2013 и 2019", ThirdAnswer = "2027 и 2029", FourthAnswer = "Pi и e", QuestionText = "Ладно, настало время настоящей математики. Сконцентрируйтесь. Какие из этих пар чисел являются сексуальными простыми?", CorrectAnswer = 1, ImgPath="/lab28;component/img/eightsImg.png"}
			};

			int score = 0;
			foreach (var q in questions)
			{
				QuestionWindow wnd = new QuestionWindow();
				wnd.DataContext = q;
				if (wnd.ShowDialog().Value)
				{
					++score;
				}
			}
			MessageBox.Show("Score: " + score);
		}
	}
}
