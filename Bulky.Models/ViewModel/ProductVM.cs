using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bulky.Models.ViewModel
{
	public class ProductVM
	{
		public IEnumerable<SelectListItem> CategoryList { get; set; } // Correct type
		public Product Product { get; set; }
	}
}
