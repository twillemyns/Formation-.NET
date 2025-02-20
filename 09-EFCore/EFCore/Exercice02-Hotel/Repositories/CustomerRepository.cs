using Exercice02_Hotel.Data;
using Exercice02_Hotel.Models;

namespace Exercice02_Hotel.Repositories;

internal class CustomerRepository(AppDbContext context) : IRepository<Customer>
{
    public Customer? Get(Func<Customer, bool> predicate)
    {
        return context.Customers.FirstOrDefault(predicate);
    }

    public Customer? GetById(int id)
    {
        return context.Customers.Find(id);
    }

    public IEnumerable<Customer> GetAll()
    {
        return context.Customers;
    }

    public IEnumerable<Customer> GetAll(Func<Customer, bool> predicate)
    {
        return context.Customers.Where(predicate);
    }

    public bool Add(Customer entity)
    {
        context.Customers.Add(entity);
        return context.SaveChanges() == 1;
    }

    public bool Delete(int id)
    {
        var customer = GetById(id);
        if (customer == null)
            return false;

        context.Customers.Remove(customer);
        return context.SaveChanges() == 1;
    }

    public int Save()
    {
        return context.SaveChanges();
    }
}
