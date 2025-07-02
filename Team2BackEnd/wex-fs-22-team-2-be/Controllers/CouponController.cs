using Microsoft.AspNetCore.Mvc;
using wex_fs_22_team_2_be.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace wex_fs_22_team_2_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly Context _context;

        public CouponController(Context context)
        {
            _context = context;
        }

        // GET: api/<CouponController>
        [HttpGet]
        public IEnumerable<Coupon> Get()
        {
            return _context.Coupon;
        }

        // GET api/<CouponController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var coupon = _context.Coupon.FirstOrDefault(x => x.Id == id);
            if (coupon != null)
                return Ok(coupon);

            return NotFound("A coupon wasn't found");

        }


        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult Post([FromBody] Coupon newCoupon, bool isShopkeeper)
        {
            if (isShopkeeper == true)
            {
                newCoupon.Id = null;
                _context.Coupon.Add(newCoupon);
                _context.SaveChanges();
                return Ok(newCoupon);
            }
            return Unauthorized("Not a shopkeeper. You are not authorized to create coupons");
        }


        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Coupon coupon, bool isShopkeeper)
        {

            Coupon grabbedCoupon = _context.Coupon.FirstOrDefault(x => x.Id == id);
            if (grabbedCoupon != null && isShopkeeper == true)
            {
                coupon.Id = grabbedCoupon.Id;
                _context.Coupon.Remove(grabbedCoupon);
                _context.Add(coupon);
                _context.SaveChanges();
                return Ok(coupon);
            }
            return Unauthorized("not a shopkeeper");
        }



        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int couponId, bool isShopkeeper)
        {
            var couponDelete = _context.Coupon.FirstOrDefault(x => x.Id == couponId);
            if (isShopkeeper != true)
                return BadRequest("You are not a shopkeeper / can not delete a coupon");
            else

            if (couponDelete != null)
            {
                _context.Coupon.Remove(couponDelete);
                _context.SaveChanges();
                return Ok("Coupon has been deleted");

            }

            return Unauthorized();
        }



    }
}
