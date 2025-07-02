using Microsoft.AspNetCore.Mvc;
using wex_fs_22_team_2_be.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace wex_fs_22_team_2_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly Context _context;

        public ProductCategoryController(Context context)
        {
            _context = context;
        }

        // GET: api/<ProductCategoryController>
        [HttpGet]
        public IEnumerable<ProductCategory> Get()
        {
            return _context.ProductCategory;
        }

        // GET api/<ProductCategoryController>/5
        [HttpGet("GetCategory/{id}")]
        public ActionResult Get(int id)
        {
            var prodCat = _context.ProductCategory.FirstOrDefault(x => x.Id == id);
            if (prodCat != null)
            {
                return Ok(prodCat);
            }
            else 
            { 
            return NotFound("A product category wasn't found");
            }
        }

        [HttpGet("GetProductByCategory/")]
        public ActionResult GetProductByCategory(int id)
        {
            var isAProd = _context.Product.Where(u => u.ProductCategoryId == id).ToList();
             return Ok(isAProd);
        }

        // POST api/<ProductCategoryController>
        [HttpPost]
        public ActionResult Post([FromBody] ProductCategory newProdCat)
        {
                newProdCat.Id = null;
                _context.ProductCategory.Add(newProdCat);
                _context.SaveChanges();
                return Ok(newProdCat);
        }

        // PUT api/<ProductCategoryController>/5
        [HttpPut]
        public ActionResult Put([FromBody] ProductCategory prodCat)
        {
            ProductCategory grabbedProdCat = _context.ProductCategory.FirstOrDefault(x => x.Id == prodCat.Id);
            if (grabbedProdCat != null)
            {
                grabbedProdCat.CategoryName = prodCat.CategoryName;
                _context.ProductCategory.Update(grabbedProdCat);
                _context.SaveChanges();
                return Ok(grabbedProdCat);
            }
            return null;
        }
        
        // DELETE api/<ProductCategoryController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var ProdCatDelete = _context.ProductCategory.FirstOrDefault(x => x.Id == id);

            if (ProdCatDelete != null)
            {
                _context.ProductCategory.Remove(ProdCatDelete);
                _context.SaveChanges();
                return Ok(ProdCatDelete);
            }
            return null;
        }
    }
}
