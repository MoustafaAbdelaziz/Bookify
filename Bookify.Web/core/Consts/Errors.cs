namespace Bookify.Web.core.Consts
{
	public static class Errors
	{
		public const string MaxLength = "Length can't be more than {1} Characters";
		public const string Duplicated = "{0} with the same name is already exists!";
		public const string DuplicatedBookWithAuthor = "{0} with the same name is already exists with the same author!";
		public const string DuplicatedAuthorWithBook = "{0} with the same name is already exists with the same title!";
		public const string NotAllowedExtension = "Only .png, .jpg .jpeg files are allowed!";
		public const string MaxSize = "File can't exceed 2 MB";
		public const string NotllowedFutureDate = "future date is not allowed";
	}
}
