namespace Bookify.Web.core.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			//Category
			CreateMap<Category, CategoryViewModel>();
			CreateMap<CategoryFormViewModel, Category>().ReverseMap();

			//Author
			CreateMap<Author, AuthorViewModel>();
			CreateMap<AuthorFormViewModel, Author>().ReverseMap();
		}
	}
}
