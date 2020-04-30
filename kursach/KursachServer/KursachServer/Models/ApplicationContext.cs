using KursachServer.Models.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursachServer.Models
{
	public class ApplicationContext : DbContext
	{
		public ApplicationContext()
		{
			this.Database.EnsureCreated();
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS01;Initial Catalog=kursachdatabase;Trusted_connection=True");
		}

		public virtual DbSet<Service> Services { get; set; }
	}
}
