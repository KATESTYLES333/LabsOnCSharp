using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using lab23.DBlab;

namespace lab23
{
	public class dataselectViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public string FirstColName { get; set; }
		public string SecondColName { get; set; }

		public ObservableCollection<DataItem> Data { get; set; }

		public Command SelectBooksCommand
		{
			get
			{
				return new Command(SelectBooks);
			}
		}

		public Command SelectAuthorsCommand
		{
			get
			{
				return new Command(SelectAuthors);
			}
		}

		public Command SelectReadersCommand
		{
			get
			{
				return new Command(SelectReaders);
			}
		}

		private void ChangeNames()
		{
			OnProperyChanged(nameof(FirstColName));
			OnProperyChanged(nameof(SecondColName));
		}

		public void SelectBooks(object _)
		{
			FirstColName = "Author";
			SecondColName = "Create date";

			using (var cotnext = new DBContextLASTEDITION())
			{
				var query = from book in cotnext.Books
							select new DataItem
							{
								FirstDataItem = book.Author.Name,
								SecondDataItem = book.CreateDate.ToString()
							};

				Data = new ObservableCollection<DataItem>(query);
				OnProperyChanged(nameof(Data));
				ChangeNames();
			}
		}

		public void SelectAuthors(object _)
		{
			FirstColName = "Id";
			SecondColName = "Name";

			using (var context = new DBContextLASTEDITION())
			{
				var query = from author in context.Authors
							select new DataItem
							{
								FirstDataItem = author.IdA.ToString(),
								SecondDataItem = author.Name
							};
				Data = new ObservableCollection<DataItem>(query);
				OnProperyChanged(nameof(Data));
				ChangeNames();
			}
		}

		public void SelectReaders(object _)
		{
			FirstColName = "Id";
			SecondColName = "Expiration date";

			using (var context = new DBContextLASTEDITION())
			{
				var query = from reader in context.Readers.Include("PersonTicket")
							select new DataItem
							{
								FirstDataItem = reader.IdR.ToString(),
								SecondDataItem = reader.PersonTicket.ExpirationDate.ToString()
							};
				Data = new ObservableCollection<DataItem>(query);
				OnProperyChanged(nameof(Data));
				ChangeNames();
			}
		}

		public virtual void OnProperyChanged(string propName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler.Invoke(this, new PropertyChangedEventArgs(propName));
			}
		}
	}
}
