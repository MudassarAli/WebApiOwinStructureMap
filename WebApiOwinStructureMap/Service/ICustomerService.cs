using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApiOwinStructureMap.Model;

namespace WebApiOwinStructureMap.Service
{
    public interface ICustomerService
    {
        Task<GetCustomersResponse> GetCustomersAsync();
    }
   
}