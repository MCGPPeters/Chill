using System.Threading.Tasks;

namespace Chill.Examples.Tests.Examples.TestSubjects.TestSubjects
{
    public interface ICustomerStore
    {
        Customer GetCustomer(int id);

        Task<Customer> GetCustomerAsync(int id);

        void DeleteCustomer(int id);
    }
}