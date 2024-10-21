using System.Collections;

public interface ICRUDinterface<T>
{
    // Create Read Update Delete
    T Post(T target);
    Task<T> GetAsync(int id);
    List<T> GetAll();
    // Task Put(T target); //replace entirely
    // Task Patch(T target); // replace partially // these 2 i find way too hard to use with generics
    Task Delete(int id);
    Task Delete(T target);
    
}