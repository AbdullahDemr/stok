using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerVolidator : ICustomerDal
    {
        ICustomerDal _customerDal;
        public CustomerVolidator(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Delete(Customer t)
        {
           _customerDal.Delete(t);
        }

        public Customer GetById(int id)
        {
           return _customerDal.GetById(id);
        }

        public List<Customer> GetList()
        {
            return new List<Customer>();
        }

        public void Insert(Customer t)
        {
            _customerDal.Insert(t);
        }

        public void Update(Customer t)
        {
            _customerDal.Update(t);
        }
    }
}
