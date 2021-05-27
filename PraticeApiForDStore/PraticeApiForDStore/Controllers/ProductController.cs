using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using PraticeApiForDStore.Entities;
using PraticeApiForDStore.Models;
using PraticeApiForDStore.OperationDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticeApiForDStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly AssignmentQueries assignmentQueries;
        private readonly IMapper _mapper;
        private readonly LinkGenerator _linkGenerator;
        public ProductController(AssignmentQueries queries, IMapper mapper, LinkGenerator linkGenerator)
        {
            assignmentQueries = queries;
            _mapper = mapper;
            _linkGenerator = linkGenerator;
        }


        [HttpGet("products")]
        public IActionResult Get(bool includePrice = false) {

            try {

                var result = assignmentQueries.GetAllProduct(includePrice);
                List<ProductModel> model = _mapper.Map<List<ProductModel>>(result);
                
                return Ok(model);

            } catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }        
        
        }

        [HttpGet("products/{id}")]
        public IActionResult GetBycode(string code, bool includePrice = false) {

            try {

                var resut = assignmentQueries.GetProductByCode(code, includePrice);
                ProductModel model = _mapper.Map<ProductModel>(resut);
                return Ok(model);
            }
            catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }

        
        }

        [HttpPost("products")]
        public IActionResult Post(ProductModel productModel) {
            try {
                Product product = _mapper.Map<Product>(productModel);
                assignmentQueries.Add(product);

                return Ok(_mapper.Map<ProductModel>(product));
            }
            catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        
        }

        [HttpPost("products/inventory")]
        public IActionResult PostInventory(InventoryModel inventoryModel) {

            try
            {
                Inventory inventory = _mapper.Map<Inventory>(inventoryModel);
                assignmentQueries.Add(inventory);
                assignmentQueries.saveChangestoDatabase();
                return Ok(_mapper.Map<InventoryModel>(inventory));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }

        }

        [HttpPost("products/productprice")]
        public IActionResult PostProductPrice(ProductPriceModel productPriceModel) {
            try {

                ProductPrice productPrice = _mapper.Map<ProductPrice>(productPriceModel);

                assignmentQueries.Add(productPrice);
                assignmentQueries.saveChangestoDatabase();


                return Ok(_mapper.Map<ProductPriceModel>(productPrice));
            }
            catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpPut("products/{code}")]
        public IActionResult PutProduct(string code, ProductModel productModel, bool includePrice = false) {

            try {

                Product oldProduct = assignmentQueries.GetProductByCode(code, includePrice);

                if (oldProduct == null) { return NotFound($"Product Not Found {code}"); }

                _mapper.Map(productModel, oldProduct);

                if (assignmentQueries.saveChangestoDatabase())
                {

                    return Ok(_mapper.Map<ProductPriceModel>(oldProduct));
                }
                else {

                    return BadRequest("Not Saved");
                
                }
            
        }
            catch (Exception) {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
    }

}
    }
}
