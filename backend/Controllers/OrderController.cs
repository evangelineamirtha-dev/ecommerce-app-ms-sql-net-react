using backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class OrderController : ControllerBase
    {
        // TEMP: In‑memory demo data instead of DB
        private static readonly List<Order> _demoOrders = new()
        {
            new Order { Id = 1, UserId = 1, Total = 100, Status = "Demo order 1" },
            new Order { Id = 2, UserId = 1, Total = 250, Status = "Demo order 2" },
            new Order { Id = 3, UserId = 2, Total = 500, Status = "Demo order 3" }
        };

        public OrderController()
        {
            // Empty constructor – no repository needed for now
        }

        // GET api/Order
        [HttpGet]
        public IActionResult Get()
        {
            // Returns all demo orders
            return Ok(_demoOrders);
        }

        // GET api/Order/1  (by userId)
        [HttpGet("{userId}")]
        public IActionResult Get(int userId)
        {
            var orders = _demoOrders.Where(o => o.UserId == userId).ToList();
            if (orders.Count == 0)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        // POST api/Order
        [HttpPost]
        public IActionResult Post(Order newOrder)
        {
            if (newOrder == null)
            {
                return BadRequest("Order is required");
            }

            // Simple in‑memory add for demo
            newOrder.Id = _demoOrders.Count == 0 ? 1 : _demoOrders.Max(o => o.Id) + 1;
            _demoOrders.Add(newOrder);

            return Ok(newOrder);
        }

        // PUT api/Order/5
        [HttpPut("{orderId}")]
        public IActionResult Put(int orderId, Order updatedOrder)
        {
            var existing = _demoOrders.FirstOrDefault(o => o.Id == orderId);
            if (existing == null)
            {
                return NotFound();
            }

            // Update basic fields for demo
            existing.UserId = updatedOrder.UserId;
            existing.Total = updatedOrder.Total;
            existing.Status = updatedOrder.Status;

            return Ok(existing);
        }

        // DELETE api/Order/5
        [HttpDelete("{orderId}")]
        public IActionResult Delete(int orderId)
        {
            var existing = _demoOrders.FirstOrDefault(o => o.Id == orderId);
            if (existing == null)
            {
                return NotFound();
            }

            _demoOrders.Remove(existing);
            return Ok();
        }
    }
}
