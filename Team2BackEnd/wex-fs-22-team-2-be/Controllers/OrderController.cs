using Microsoft.AspNetCore.Mvc;
using wex_fs_22_team_2_be.Models;
using System.Text;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace wex_fs_22_team_2_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly Context _context;
        private static int _orderId = 0;

        public OrderController(Context context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _context.Order;
        }

        [HttpGet("GetUserOrderHistory/{userid}")]
        public ActionResult Get(int userid)
        {
            var order = _context.Order.Where(x => x.UserId == userid).ToList();
            List<UserOrderDataTransport> tempuserdata = new List<UserOrderDataTransport>();
            foreach (var orderItem in order)
            {
                List<OrderDetail> orderdetails = _context.OrderDetails.Where(x => x.OrderIdNum == orderItem.OrderIdNum).ToList();
                tempuserdata.Add(new UserOrderDataTransport { orderNumId = orderItem.OrderIdNum, orderDetailsList = orderdetails, orderTotal = orderItem.OrderTotal });

            }
            if (order != null)
                return Ok(tempuserdata);
            return NotFound("order wasn't found");
        }
            //public ActionResult Get(int userid)
            //{
            //    var order = _context.Order.Where(x => x.UserId == userid).ToList();
            //    int tempindex = 0;
            //    UserOrderDataTransport tempuserdata = new UserOrderDataTransport();
            //    foreach (var orderItem in order)
            //    {
            //        List<OrderDetail> orderdetails = _context.OrderDetails.Where(x => x.OrderIdNum == order[tempindex].OrderIdNum).ToList();
            //        tempuserdata = new UserOrderDataTransport { orderNumId = order[tempindex].OrderIdNum, orderDetailsList = orderdetails, orderTotal = order[tempindex].OrderTotal };
            //        tempindex++;
            //    }
            //    if (order != null)
            //        return Ok(tempuserdata);
            //    return NotFound("order wasn't found");
            //}

            [HttpPatch("CheckoutPassingDetails")]
        public ActionResult Patch([FromBody] OrderCheckoutDataTrasport order)
        {
            string orderIdNumGen = DateTime.Now.ToString("dd") + DateTime.Now.ToString("MM") + "LO" + _orderId++;
            Order ord = new Order { OrderIdNum = orderIdNumGen, UserId = order.UserId, OrderTotal = order.OrderTotal };
            _context.Order.Add(ord);
            _context.SaveChanges();
            //need orderdetail array
            //user should not be able to add more to cart than exists
            //TODO: find inventory with highest cost of acquisition
            //decrement

            foreach (var detail in order.OrderDetails)
            {
                detail.OrderIdNum = orderIdNumGen;
                detail.Id = null;
                _context.OrderDetails.Add(detail);
                int quantityKeeper = detail.Quantity;
                var prod = _context.Product.FirstOrDefault(x => x.Id == detail.ProductId);
                prod.TotalInventoryCount-=quantityKeeper;
                _context.SaveChanges();
                do
                {
                    var inven = _context.Inventory.FirstOrDefault(x => x.ProductId == detail.ProductId && x.CurrentQuantity > 0);
                    //Console.WriteLine(inven.CurrentQuantity + "inven current quantity");
                    if (inven.CurrentQuantity > quantityKeeper)
                    {
                        Console.WriteLine("invencurrentquant > quantkeep");
                        inven.CurrentQuantity -= quantityKeeper;
                        quantityKeeper = 0;
                        _context.SaveChanges();
                    }
                    else
                    {
                        quantityKeeper -= inven.CurrentQuantity;
                        inven.CurrentQuantity = 0;
                        _context.SaveChanges();
                    }
                } while (quantityKeeper > 0);
            }
            _context.SaveChanges();
            return Ok("details added");
        }
    }
}
