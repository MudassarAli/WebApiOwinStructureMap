using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiOwinStructureMap.Model;

namespace WebApiOwinStructureMap.Service
{
    public class GetCustomersResponse
    {
        public IEnumerable<Customer> Customers { get; set; }
        public bool Success { get; set; }
        public Exception OperationException { get; set; }
    }
}