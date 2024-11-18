using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Title is required.")]
		public string Title { get; set; }

		[Required(ErrorMessage = "Description is required.")]
		public string Description { get; set; }

		[Required(ErrorMessage = "ISBN is required.")]
		[MaxLength(13, ErrorMessage = "ISBN cannot exceed 13 characters.")]
		public string ISBN { get; set; }

		[Required(ErrorMessage = "Author is required.")]
		public string Author { get; set; }

		[Required]
		[Display(Name = "List Price")]
		[Range(1, 1000, ErrorMessage = "List Price must be between 1 and 1000.")]
		public double ListPrice { get; set; }

		[Required]
		[Display(Name = "Price for 1-50")]
		[Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000.")]
		public double Price { get; set; }

		[Required]
		[Display(Name = "Price for 50+")]
		[Range(1, 1000, ErrorMessage = "Price for 50+ must be between 1 and 1000.")]
		public double Price50 { get; set; }

		[Required]
		[Display(Name = "Price for 100+")]
		[Range(1, 1000, ErrorMessage = "Price for 100+ must be between 1 and 1000.")]
		public double Price100 { get; set; }

		[Required]
		[DisplayName("Category")]
		public int CategoryId { get; set; }

		[ForeignKey("CategoryId")]
		[ValidateNever]
		public Category Category { get; set; } // Navigation property
		[ValidateNever]

		public string ImageUrl { get; set; }
    }
}
