using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiOwinStructureMap.Model;
using WebApiOwinStructureMap.Repository;
using WebApiOwinStructureMap.Service;

namespace WebApiOwinStructureMap.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly ICustomerService _customerService;

        public CustomersController()
        {
            _customerService = new CustomerService(new CustomerRepository());
        }

        public async Task<IHttpActionResult> Get()
        {
            GetCustomersResponse response = await _customerService.GetCustomersAsync();
            if (response.Success)
            {
                return Ok<IEnumerable<Customer>>(response.Customers);
            }

            return InternalServerError(response.OperationException);
        }
    }
}

