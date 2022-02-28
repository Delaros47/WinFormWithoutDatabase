using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CustomerManager
    {

        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{Id=1,FirstName="Ahmet",LastName="Hamdi",City="Mardin",Email="ahmet@hotmail.com"},
                new Customer{Id=2,FirstName="Cemal",LastName="Demir",City="Izmir",Email="cemal@hotmail.com"},
            };
        }

        List<Customer> customers;
        public List<Customer> GetAll()
        {
            
            return customers;
        }



        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
