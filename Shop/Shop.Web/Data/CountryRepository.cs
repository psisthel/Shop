namespace Shop.Web.Data
{
	using Entities;
	public class CountryRepository : GenericRepository<Country>, ICountryRepository
	{
		//injecta datacontext y constructor base
		public CountryRepository(DataContext context) : base(context)
		{
		}
	}
}
