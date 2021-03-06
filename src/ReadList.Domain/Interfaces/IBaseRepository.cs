namespace ReadList.Domain.Interfaces
{
    public interface IBaseRepository<TModel> : IDisposable
    {
        Task<List<TModel>> Search();
        Task<TModel> Find(Guid id);        
        Task Create(TModel model);
        Task CreateMany(List<TModel> models);
        Task Update(TModel model);
        Task Delete(Guid id);
    }
}
