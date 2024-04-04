using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private  IProductRepository _productRepository;
        private  ICategoryRepository _categoryRepository;

        public RepositoryManager(IProductRepository productRepository, RepositoryContext context, ICategoryRepository categoryRepository)
        {
            _context = context;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        // IRepositoryManager arabiriminde tanımlı Product özelliğinin hem getter hem de setter'ı uygulanır
        public IProductRepository Product
        {
            get => _productRepository;
            set => _productRepository = value;
        }

        public ICategoryRepository Category
        {
            get => _categoryRepository;
            set => _categoryRepository = value;
        }

        // IRepositoryManager arabiriminde tanımlı Save() metodu uygulanır
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
