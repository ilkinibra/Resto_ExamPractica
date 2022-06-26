using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resto_Backend.Models
{
	public class Specialties
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }
		public string ImageUrl { get; set; }
		[NotMapped]
		public IFormFile Photo { get; set; }
	}
}
