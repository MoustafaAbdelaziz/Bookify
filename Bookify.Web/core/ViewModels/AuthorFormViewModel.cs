namespace Bookify.Web.core.ViewModels
{
	public class AuthorFormViewModel
	{
		public int id { get; set; }

		[MaxLength(100, ErrorMessage = Errors.MaxLength), Display(Name = "Author")]
		[Remote("AllowItem", null!, AdditionalFields = "id", ErrorMessage = Errors.Duplicated)]
		public string Name { get; set; } = null!;
	}
}
