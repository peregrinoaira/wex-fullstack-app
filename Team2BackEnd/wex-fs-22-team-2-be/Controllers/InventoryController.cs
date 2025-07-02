using Microsoft.AspNetCore.Mvc;
using wex_fs_22_team_2_be.Models;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace wex_fs_22_team_2_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly Context _context;


        public InventoryController(Context context)


        {
            _context = context;
        }

        // GET: api/<InventoryController>
        [HttpGet]
        public IEnumerable<Inventory> Get()
        {
            return _context.Inventory;
        }

        // GET api/<InventoryController>/5
        [HttpGet("{id}")]
        //gets list of inventory 
        public IEnumerable<Inventory> Get(int id)
        {
            var inven = _context.Inventory.Where(x => x.ProductId == id);
            return inven;

        }


        [HttpPost("AddingShipmentShopkeeper")]
        public ActionResult Post(Inventory inven, bool isShopkeeper)
        {

        
            if (isShopkeeper)
            {
                var prod = _context.Product.FirstOrDefault(x => x.Id == inven.ProductId);

                inven.CurrentQuantity = inven.ShipmentQuantity;
                prod.TotalInventoryCount += inven.ShipmentQuantity;

                inven.Id = null;
                _context.Inventory.Add(inven);
                //var prod = _context.Product.FirstOrDefault(x => x.Id == inven.ProductId);
                prod.TotalInventoryCount += inven.ShipmentQuantity;
                _context.SaveChanges();
                return Ok(inven);

            }
            return Unauthorized("not a shopkeeper");
            
        }


        [HttpPut("InventoryAdjustmentForShopkeeper/{id}")]
        public ActionResult Put(int id, [FromBody] Inventory inven, bool isShopkeeper)
        {
            var grabbedInven = _context.Inventory.FirstOrDefault(x => x.Id == id);
            if(grabbedInven != null && isShopkeeper == true)
            {

                var prod = _context.Product.FirstOrDefault(x => x.Id == inven.ProductId);

                if (grabbedInven.CurrentQuantity > inven.CurrentQuantity)
                     
                {
                    int tempvar = grabbedInven.CurrentQuantity - inven.CurrentQuantity;
                    prod.TotalInventoryCount -= tempvar;

                    grabbedInven.CurrentQuantity = inven.CurrentQuantity;
                    
                }
                else if (grabbedInven.CurrentQuantity < inven.CurrentQuantity)

                {
                    int tempvar = inven.CurrentQuantity - grabbedInven.CurrentQuantity ;
                    prod.TotalInventoryCount += tempvar;

                    grabbedInven.CurrentQuantity = inven.CurrentQuantity;
                }
            
                _context.Inventory.Update(grabbedInven);
                _context.SaveChanges();
                return Ok(grabbedInven);

            }
            if(!isShopkeeper)
            return Unauthorized("not a shopkeeper");
            return BadRequest("id of inventory not found");
            
        }



        // DELETE api/<InventoryController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id, bool isShopkeeper)
        {
            var grabbedInven = _context.Inventory.FirstOrDefault(x => x.Id == id);
            var grabbedProd = _context.Product.FirstOrDefault(x => x.Id == grabbedInven.ProductId);
            if (!isShopkeeper)
                return Unauthorized("not a shopkeeper");
            if(grabbedInven != null && grabbedProd != null)
            {
                grabbedProd.TotalInventoryCount -= grabbedInven.CurrentQuantity;
                _context.Inventory.Remove(grabbedInven);                
                _context.SaveChanges();
                return Ok("Inventory Deleted");
                
            }
            return BadRequest("inventory not found");
        }
    }
}
