using Desafio.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio
{
	public class AppDbContext : DbContext
	{

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<Contato> Contato { get; set; }
	}
}
