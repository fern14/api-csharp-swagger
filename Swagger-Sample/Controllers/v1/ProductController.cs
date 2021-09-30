using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swagger_Sample.Models;
using System;
using System.Collections.Generic;

namespace Swagger_Sample.Controllers.v1
{
    /// <summary>
    /// API Products, retorna e adiciona produtos
    /// </summary>
    [Route("v1/products")]
    public class ProductController : Controller
    {
        private static readonly List<Product> _products = new List<Product>()
        {
            new Product("Copo", "Copo legal", 10.00M),
            new Product("Iphone 8", "258 gb", 8000.00M)
        };

        /// <summary>
        /// Retorna a Lista com todos os produtos
        /// </summary>
        /// <returns>products</returns>
        [HttpGet]
        [Route("")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _products;
        }

        /// <summary>
        /// Adiciona um novo produto
        /// </summary>
        /// <param name="product">É um produto</param>
        [HttpPost]
        [Route("")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public IActionResult AddProduct([FromBody]Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("O produto não pode ser nulo");
            }

            _products.Add(product);

            return Ok(product);
        }
    }

    
}
