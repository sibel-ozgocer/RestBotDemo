using RestBotDemo.Application.Abstractions;
using RestBotDemo.Application.Repositories;

namespace RestBotDemo.Application.Concretes;



public class BaseService<T> : IBaseService<T> where T : class
{
    private IBaseRepository<T> _repository;

    public BaseService(IBaseRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task<T> CreateAsync(T entity)
    {
        await _repository.AddAsync(entity);
        return entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
        return true;
        ;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        // Veritabanından tüm öğeleri al
        var entities = await _repository.GetAllAsync();

        if (entities == null || !entities.Any())
        {
            // Eğer hiçbir öğe bulunamazsa, boş bir koleksiyon dönebiliriz.
            return Enumerable.Empty<T>();
        }

        return entities;
    }

    public async Task<T> GetByIdAsync(int id)
    {
        // Veritabanında ID'ye göre öğeyi bul
        var entity = await _repository.GetByIdAsync(id);

        if (entity == null)
        {
            // Eğer öğe bulunamazsa, exception fırlatılabilir
            throw new KeyNotFoundException($"Entity with ID {id} not found.");
        }

        return entity;
    }

    public async Task<T> UpdateAsync(int id, T entity)
    {
        // Veritabanında mevcut olan öğeyi ID'ye göre bul
        var existingEntity = await _repository.GetByIdAsync(id);

        if (existingEntity == null)
        {
            // Eğer öğe bulunamazsa, exception veya null dönebilirsin.
            throw new InvalidOperationException("Entity not found.");
        }

        // Veritabanındaki öğeyi güncelle
        // Bu adımda mevcut öğe ile gelen entity'nin verilerini birleştirebilirsin.
        // (Eğer entity'yi doğrudan değiştirebiliyorsanız bu kısmı atlayabilirsiniz.)
        existingEntity = entity;

        // Güncellenmiş öğeyi kaydet
        await _repository.UpdateAsync(existingEntity);

        // Güncellenmiş öğeyi geri döndür
        return existingEntity;
    }
}
