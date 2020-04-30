using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace lab20
{
	class MyException : Exception
	{
		public MyException() : base()
		{ }

		public MyException(string message) : base(message)
		{ }

		public MyException(string message, Exception inner) : base(message, inner)
		{ }
	}

	[Serializable]
	class Reader
	{
		public String Surname { get; set; }
		public int ReaderTicket { get; set; }

		public List<Book> GivenToBooks { get; set; }

		public override string ToString()
		{
			return ReaderTicket.ToString() + " - number of reader ticket " + Surname + " ";
		}

		public Reader() { }

		public Reader(int readerTicket, List<Book> GivenBooks1, String surname)
		{
			Surname = surname;
			ReaderTicket = readerTicket;
			GivenToBooks = GivenBooks1;
		}

		public void GetBook(Book book)
		{
			GivenToBooks.Add(book);
		}
	}

	[Serializable]
	public class Book
	{
		private string author;

		public string Author
		{
			get => author;
			set
			{
				if (value.ToUpper().StartsWith(value[0].ToString()))
				{
					author = value;
				}
				else
				{
					throw new MyException("No author starts with little letter");
				}
			}

		}
		private string bookName;
		public string BookName
		{
			get => bookName;
			set
			{
				if (value.ToUpper().StartsWith(value[0].ToString()))
				{
					bookName = value;
				}
				else
				{
					throw new MyException("No book starts with little letter");
				}
			}
		}
		public DateTime PublishYear { get; set; }
		public Book()
		{
		}
		public Book(DateTime date)
		{
			PublishYear = date;
		}

		private decimal price;
		public decimal Price
		{
			get => price;
			set
			{
				if (value > 0)
				{
					price = value;
				}
				else
				{
					throw new MyException("No!!!!!");
				}
			}
		}

		public override string ToString()
		{
			return BookName + " " + Author + " " + PublishYear + " - " + Price;
		}
	}

	[Serializable]
	class Library
	{
		public List<Book> Books { get; private set; }
		public List<Reader> Readers { get; private set; }

		public Library()
		{
			Books = new List<Book>();
			Readers = new List<Reader>();
		}

		public void AddBook(Book book)
		{
			Books.Add(book);
		}

		public void AddReader(Reader reader)
		{
			Readers.Add(reader);
		}

		public void GiveBook(Reader reader, Book book)
		{
			if (reader.ReaderTicket == 0)
			{
				throw new MyException("No reader ticket");
			}
			reader.GetBook(book);
			Books.Remove(book);
		}
	}

	class Program
	{
		static void WriteBooksToXML(IEnumerable<Book> books)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(Book));
			using (FileStream fs = new FileStream("D:\\book.xml", FileMode.OpenOrCreate))
			{
				foreach (var book in books)
				{
					formatter.Serialize(fs, book);
				}

				Console.WriteLine("Объект сериализован");
			}
		}

		static void Main(string[] args)
		{
			Library library = new Library();
			List<Book> Books = new List<Book>();
			List<Book> GivenBooks = new List<Book>();
			List<Reader> Readers = new List<Reader>();

			Book bk = new Book()
			{
				Author = "Ccc",
				BookName = "In some world",
				PublishYear = new DateTime(1999, 12, 10),
				Price = 200
			};

			Book bk1 = new Book()
			{
				Author = "Bbb",
				BookName = "Forever",
				PublishYear = new DateTime(1968, 2, 12),
				Price = 100
			};

			Book bk2 = new Book()
			{
				Author = "Aaa",
				BookName = "Today",
				PublishYear = new DateTime(1954, 11, 9),
				Price = 150
			};

			Book bk3 = new Book()
			{
				Author = "Hhh",
				BookName = "Wertyu",
				PublishYear = new DateTime(1499, 8, 12),
				Price = 250
			};

			Book bk4 = new Book()
			{
				Author = "Pppp",
				BookName = "Flajl",
				PublishYear = new DateTime(1988, 12, 11),
				Price = 800
			};

			library.AddBook(bk);
			library.AddBook(bk1);
			library.AddBook(bk2);
			library.AddBook(bk3);
			library.AddBook(bk4);

			Console.WriteLine("Books in library:");
			foreach (var item in library.Books)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			Reader reader = new Reader() { ReaderTicket = 1, GivenToBooks = Books, Surname = "Петров" };
			Reader reader1 = new Reader() { ReaderTicket = 3, GivenToBooks = Books, Surname = "Цуке" };
			Reader reader2 = new Reader() { ReaderTicket = 5, GivenToBooks = Books, Surname = "Влар" };
			Reader reader3 = new Reader() { ReaderTicket = 2, GivenToBooks = Books, Surname = "Зшфва" };

			library.AddReader(reader);
			library.AddReader(reader1);
			library.AddReader(reader2);
			library.AddReader(reader3);

			Console.WriteLine("People in library:");
			foreach (var item in library.Readers)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();


			library.GiveBook(reader, bk);
			library.GiveBook(reader, bk1);


			Console.WriteLine("LINQ FOR BEST PRICE:");

			var bestBook = from book in library.Books
						   where book.Price > 500
						   select book;

			foreach (var item in bestBook)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();

			Console.WriteLine("LINQ FOR GROUP BY AUTHOR:");

			var bookGroups = from b in library.Books
							 group b by b.Author;

			foreach (IGrouping<string, Book> g in bookGroups)
			{
				Console.WriteLine(g.Key + ":");
				foreach (var item in g)
				{
					Console.WriteLine(item.BookName);
				}
			}
			Console.WriteLine();

			Console.WriteLine("Group by 2 params:");
			var group = from g in library.Readers
						orderby g.ReaderTicket
						orderby g.GivenToBooks
						select g;

			foreach (var item in group)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine();


			Console.WriteLine("LINQ FOR GROUP BY NAME:");

			var nameGroups = from b in library.Books
							 group b by b.BookName;

			foreach (IGrouping<string, Book> g in nameGroups)
			{
				Console.WriteLine(g.Key + ":");
				foreach (var item in g)
				{
					Console.WriteLine(item.Author);
				}
			}
			Console.WriteLine();

			var bannedUsers = from b in library.Readers
							  where b.GivenToBooks.Count != 0
							  select b;

			foreach (var item in bannedUsers)
			{
				Console.WriteLine("Banned user: " + item);
			}

			Console.ReadLine();

			WriteBooksToXML(Books);
		}
	}

}
