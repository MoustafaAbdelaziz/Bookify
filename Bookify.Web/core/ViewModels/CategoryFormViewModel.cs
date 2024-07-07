using Microsoft.AspNetCore.Mvc;

namespace Bookify.Web.core.ViewModels
{
	public class CategoryFormViewModel
	{
        public int id { get; set; }

        [MaxLength(100, ErrorMessage = "Max length can not be more than 100 chr.")]
		[Remote("AllowItem", null, AdditionalFields ="id", ErrorMessage = "Category with the same name is already exists!")]
		public string Name { get; set; } = null!;
    }
}
