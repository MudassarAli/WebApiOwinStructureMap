using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiOwinStructureMap.Model
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> FindAll();
    }
}