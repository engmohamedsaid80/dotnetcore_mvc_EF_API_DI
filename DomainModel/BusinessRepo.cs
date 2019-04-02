using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class BusinessRepo : IRepo
    {
        BusinessDM _context;
        public BusinessRepo(BusinessDM context)
        {
            _context = context;
        }


        public BusService GetService()
        {
            var s = _context.BusServices.FirstOrDefault();

            return s;
        }


    }
}
