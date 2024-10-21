

public class CrudService<T> : ICRUDinterface<T> where T : class , Iidentity
{
    private readonly ModelContext _context;
    public CrudService(ModelContext context)
    {
        _context = context;
    }
    public async Task Delete(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        
        if (entity != null)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new KeyNotFoundException($"Entity with id {id} not found.");
        }
    }

    public async Task Delete(T target)
    {
        var entity = await _context.Set<T>().FindAsync(target);
        
        if (entity != null)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new KeyNotFoundException($"Entity with entity {target} not found.");
        }

    }

    public async Task<T> GetAsync(int id)
    {
        var entity =  await _context.Set<T>().FindAsync(id);
        return entity;
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public async Task Patch(T target)
    {   
        var entity =  await _context.Set<T>().FindAsync(target);
        
    }

    public T Post(T target)
    {
        if(target !=  null)
        {
            _context.Set<T>().Add(target);
            _context.SaveChanges();
            return target;
        }
        return null;
    }

    public Task Put(T target)
    {
        throw new NotImplementedException();
    }
}

