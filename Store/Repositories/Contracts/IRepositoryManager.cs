namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository Product { get; set; }
        ICategoryRepository Category { get; set; }
        void Save();
    }
}