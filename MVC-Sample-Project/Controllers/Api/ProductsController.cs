using MVC_Sample_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_Sample_Project.Controllers.Api
{
    public class ProductsController : ApiController
    {

        AppDbContext _context = new AppDbContext();

        public ProductsController()
        {
            _context = new AppDbContext();
        }

        //Get
        public IHttpActionResult GetProducts()
        {
            IEnumerable<Products> products = _context.Products.ToList();
            return Ok(products);
        }
    }
}
