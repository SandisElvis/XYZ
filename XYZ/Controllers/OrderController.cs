using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XYZ.Models;

namespace XYZ.Controllers
{
    [Route("/api/[controller]")]
    public class OrderController : Controller
    {
        private List<Order> _orders = new List<Order>
        {
            new Order { OrderNumber = "ON1234",UserId = 1,PayableAmount = 32.01f,PaymentGateway = "Card",OptionalDescription = "Mobile phone SX"},
            new Order { OrderNumber = "ON2345",UserId = 2,PayableAmount = 10.00f,PaymentGateway = "Money",OptionalDescription = "TV" },
            new Order { OrderNumber = "ON4567",UserId = 2,PayableAmount = 15.50f,PaymentGateway = "Card",OptionalDescription = "Computer"}
        };

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            return Ok(_orders);
        }

        [HttpGet]
        [Route("{OrderNumber}")]
        public IActionResult GetOrderByOrderNumber(string OrderNumber)
        {
            var order = _orders.FirstOrDefault(o => o.OrderNumber == OrderNumber);
            if (order == null)
                return NotFound("Order wasn't found!");

            return Ok(order); 
        }

        [HttpGet]
        [Route("{OrderNumber}/{PayableAmount}")]
        public IActionResult GetAndBuyOrder(string OrderNumber, double PayableAmount)
        {
            var order = _orders.FirstOrDefault(o => o.OrderNumber == OrderNumber);
            if (order == null)
                return NotFound();

            double value = PayableAmount - order.PayableAmount;
            if (value >= 0)
            {
                var receipt = new Receipt
                {
                    Company = "XYZ",
                    OrderNumber = order.OrderNumber,
                    Price = order.PayableAmount,
                    Payed = PayableAmount,
                    Change = value,
                    Description = order.OptionalDescription
                };

                return Ok(receipt);
            }
            else
            {
                return BadRequest("Don't have enough money to buy!");
            }
        }
    }
}
