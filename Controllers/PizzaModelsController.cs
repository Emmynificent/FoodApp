using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodApp.Models;
using FoodApp.Data;

namespace FoodApp.Controllers
{
    public class PizzaModelsController : Controller
	{
		private readonly OrderDbContext _context;

		public PizzaModelsController(OrderDbContext context)
		{
			_context = context;
		}

		// GET: PizzaModels
		public async Task<IActionResult> Index()
		{
			return View(await _context.Pizza.ToListAsync());
		}

		// GET: PizzaModels/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var pizzaModel = await _context.Pizza
				.FirstOrDefaultAsync(m => m.Id == id);
			if (pizzaModel == null)
			{
				return NotFound();
			}

			return View(pizzaModel);
		}

		// GET: PizzaModels/AddOrEdit
		public IActionResult AddOrEdit(int id = 0)
		{
			if (id == 0)
			{
				var pizzaModel = new PizzaModel();
				pizzaModel.Size = SizeOption.Small;

				return View(pizzaModel);
			}
			else
			{
				return View(_context.Pizza.Find(id));
			}
		}

		// POST: PizzaModels/AddOrEdit
		// To protect from overposting attacks, enable the specific properties you want to bin d to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> AddOrEdit([Bind("Id,Name,Description,Size,BasePrice")] PizzaModel pizzaModel)
		{

			if (pizzaModel.Id == null)
			{
				_context.Pizza.Add(pizzaModel);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			else
			{
				_context.Pizza.Update(pizzaModel);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}

		}

	   

		// GET: PizzaModels/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var pizzaModel = await _context.Pizza
				.FirstOrDefaultAsync(m => m.Id == id);
			if (pizzaModel == null)
			{
				return NotFound();
			}

			return View(pizzaModel);
		}

		// POST: PizzaModels/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var pizzaModel = await _context.Pizza.FindAsync(id);
			if (pizzaModel != null)
			{
				_context.Pizza.Remove(pizzaModel);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool PizzaModelExists(int id)
		{
			return _context.Pizza.Any(e => e.Id == id);
		}
	}
}
