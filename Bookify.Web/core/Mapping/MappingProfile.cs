using AutoMapper;
using Bookify.Web.core.Models;

namespace Bookify.Web.core.Mapping
{
	public class MappingProfile: Profile
	{
		public MappingProfile()
		{
			//Category
			CreateMap<Category, CategoryViewModel>();
			CreateMap<CategoryFormViewModel, Category>().ReverseMap();
		}
	}
}
