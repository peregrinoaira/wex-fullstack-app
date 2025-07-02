using Microsoft.AspNetCore.Mvc;
using wex_fs_22_team_2_be.Models;




// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace wex_fs_22_team_2_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _context.Product;
        }

        // GET: api/<ProductController>
        [HttpGet("shopkeep-products")]
        public IEnumerable<Product> GetShopKeepProducts()
        {
            return _context.Product;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var product = _context.Product.FirstOrDefault(x => x.Id == id);
            if (product != null)
                return Ok(product);
            return NotFound("A product wasn't found");
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] Product prod)
        {
                prod.Id = null;
                _context.Product.Add(prod);
                _context.SaveChanges();
                return Ok(prod);
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public ActionResult Put([FromBody] Product prod)
        {
            Product grabbedProduct = _context.Product.FirstOrDefault(x => x.Id == prod.Id);
            if(grabbedProduct != null)
            {
                //all straight assignment for any changes
                grabbedProduct.ProductName = prod.ProductName;
                grabbedProduct.ProductDescription = prod.ProductDescription;
                grabbedProduct.ProductImage = prod.ProductImage;
                grabbedProduct.ProductPrice = prod.ProductPrice;
                grabbedProduct.MinumunPrice = prod.MinumunPrice;
                grabbedProduct.Discontinued = prod.Discontinued;
                grabbedProduct.DiscontinuedDate = prod.DiscontinuedDate;
                grabbedProduct.ProductCategoryId = prod.ProductCategoryId;
                //add logic for if coupon is true to convert int array to string for be
                grabbedProduct.Coupon  = prod.Coupon;
                grabbedProduct.CouponId = prod.CouponId;
                //add logic for if sale is true to convert int array to string for be
                grabbedProduct.OnSale = prod.OnSale;
                grabbedProduct.OnSaleId = prod.OnSaleId;
                //add logic for is inventory is different it updates the inventory
                grabbedProduct.TotalInventoryCount = prod.TotalInventoryCount;
                _context.Product.Update(grabbedProduct);
                _context.SaveChanges();
                return Ok(prod);
            }
            return null;
            //TODO FIXME: add separate if else for product doesnt exist
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var prod = _context.Product.FirstOrDefault(x => x.Id == id);
            var inven = _context.Inventory.Where(x => x.ProductId == id).ToList();            
            if (prod != null && inven != null)
            {
                //foreach(var item in inven)
                //_context.Remove(inven);
                //_context.Product.Remove(prod);
                foreach (var item in inven)
                    item.CurrentQuantity = 0;
                prod.TotalInventoryCount = 0;
                prod.Discontinued = true;
                prod.DiscontinuedDate = DateTime.Now;
                _context.SaveChanges();
                return Ok("deleted");
            }
            return null;
            //TODO FIXME: add separate if else for product doesnt exist
        }
    }
}