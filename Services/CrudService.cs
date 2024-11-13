

public class CrudService<T> : ICRUDinterface<T> where T : class , Iidentity
{
    private readonly ModelContext _context;
    public CrudService(ModelContext context)
    {
        _context = context;
    }
    public bool Delete(int id)
    {
        var entity = _context.Set<T>().Find(id);
        
        if (entity != null)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return true;
        }
        else
        {
            return false;
        }
    }

    public  bool Delete(T target)
    {
        var entity = _context.Set<T>().Find(target);
        
        if (entity != null)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return true;
        }
        else
        {
            return false;
        }

    }

    public T Get(int id) // need a bug fix // er gaat mis blijkbaar returned het niet het helemaal null maar test dit verder
    {

        T entity = _context.Set<T>().Find(id);
        Console.WriteLine("Aiden is hier zomaar"); // testing
        Console.WriteLine(entity);
        if (entity != null) return entity;
        Console.WriteLine("True it is hella empty");
        return null;
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

