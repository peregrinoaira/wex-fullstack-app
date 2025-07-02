using Microsoft.AspNetCore.Mvc;
using wex_fs_22_team_2_be.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace wex_fs_22_team_2_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly Context _context;

        public SalesController(Context context)
        {
            _context = context;
        }

        // GET: api/<SalesController>
        [HttpGet]
        public IEnumerable<Sale> Get()
        {
            return _context.Sale;
        }

        // GET api/<SalesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var sales = _context.Sale.FirstOrDefault(x => x.Id == id);
            if (sales != null)
                return Ok(sales);
            return NotFound("A sale wasn't found");
        }

        // POST api/<SalesController>
        [HttpPost]
        public ActionResult Post([FromBody] Sale newSale, bool isShopkeeper)
        {
            if (isShopkeeper == true)
            {
                newSale.Id = null;
                _context.Sale.Add(newSale);
                _context.SaveChanges();
                return Ok(newSale);
            }
            return Unauthorized("Not a shopkeeper. You are not authorized to create a sale");
        }

        // PUT api/<SalesController>/5
        [HttpPut("{id}")]

        public ActionResult Put(int id, [FromBody] Sale sale, bool isShopkeeper)
        {
            Sale grabbedSale = _context.Sale.FirstOrDefault(x => x.Id == id);
            if (isShopkeeper != true)
                return BadRequest("You are not a shopkeeper / can not modify a sale");
            else
            if (grabbedSale != null)
            {
                sale.Id = grabbedSale.Id;
                _context.Sale.Remove(grabbedSale);
                _context.Add(sale);
                _context.SaveChanges();
                return Ok(sale);
            }
            return Unauthorized("not a shopkeeper");
        }

        // DELETE api/<SalesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int salesId, bool isShopkeeper)
        {
            var salesDelete = _context.Sale.FirstOrDefault(x => x.Id == salesId);
            if (isShopkeeper != true)
                return BadRequest("You are not a shopkeeper / can not delete a sale");
            else
            if (salesDelete != null)
            {
                _context.Sale.Remove(salesDelete);
                _context.SaveChanges();
                return Ok("Sales has been deleted");
            }
            return Unauthorized();
        }
    }
}