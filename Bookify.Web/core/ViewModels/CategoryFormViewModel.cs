namespace Bookify.Web.core.ViewModels
{
	public class CategoryFormViewModel
	{
        public int id { get; set; }

        [MaxLength(100)]
		public string Name { get; set; } = null!;
    }
}
