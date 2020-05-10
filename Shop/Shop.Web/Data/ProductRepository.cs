namespace Shop.Web.Data
{
	using Entities;

	public class ProductRepository : GenericRepository<Product>, IProductRepository
	{
		//injecta datacontext y constructor base
		public ProductRepository(DataContext context) : base(context)
		{
		}
	}

}
