using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodApp.Models;
using FoodApp.Data;
using FoodApp.Migrations;

namespace FoodApp.Controllers
{
    public class OrderModelsController : Controller
    {
        private readonly OrderDbContext _context;

        public OrderModelsController(OrderDbContext context)
        { 
            _context = context;
        }

        // GET: OrderModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Order.ToListAsync());
        }

        // GET: OrderModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderModel = await _context.Order
                .FirstOrDefaultAsync(m => m.Id == id);

            if (orderModel == null)
            {
                return NotFound();
            }

            return View(orderModel);
        }

        
        // GET: OrderModels/Create
        public async  Task<IActionResult> Create(int?  Id)
        {
            var pizza = await _context.Pizza.FindAsync(Id);
            if (Id == 0)
            {
                return View();

            }

            ViewBag.PizzaName = pizza.Name;
            ViewBag.Id = pizza.Id;

            return View(new OrderModel { Pizza = new PizzaModel { Id = pizza.Id, Name = pizza.Name} });
        }

        // POST: OrderModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( OrderModel orderModel)
        {
            if (ModelState.IsValid)
            {
                var pizza = await _context.Pizza.FindAsync(orderModel.Pizza.Id);
                //orderModel.Pizza = pizza;


                if (pizza == null)
                {
                    ModelState.AddModelError(string.Empty, "Selected Pizza is not found");
                    return View(orderModel);
                }
                //orderModel.Pizza.Name = pizzaName;
               // orderModel.Pizza.Id = pizzaId;
                orderModel.Pizza = pizza;
                _context.Add(orderModel);
                //Console.WriteLine()
                //_context.Update(orderModel);
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

               // Console.WriteLine(pizza);
                //_context.Add(orderModel);
                //await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            }
            return View(orderModel);
        }

        // GET: OrderModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderModel = await _context.Order.FindAsync(id);
            if (orderModel == null)
            {
                return NotFound();
            }
            return View(orderModel);
        }

        // POST: OrderModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,OrderDate,Status,Quantity")] OrderModel orderModel)
        {
            if (id == null )
            {
                return NotFound();
            }
             _context.Update(orderModel);
             await _context.SaveChangesAsync();
             return RedirectToAction(nameof(Index));

         //   return View(orderModel);
        }

        // GET: OrderModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderModel = await _context.Order
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderModel == null)
            {
                return NotFound();
            }

            return View(orderModel);
        }

        // POST: OrderModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderModel = await _context.Order.FindAsync(id);
            if (orderModel != null)
            {
                _context.Order.Remove(orderModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderModelExists(int id)
        {
            return _context.Order.Any(e => e.Id == id);
        }
    }
}
