using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
	public class BookController : Controller
	{
		private readonly BookStoreContext _context;

		public BookController(BookStoreContext context)
		{
			_context = context;
		}

		// GET: Book
		public async Task<IActionResult> Index()
		{
			return _context.BookModel != null ?
						View(await _context.BookModel.ToListAsync()) :
						Problem("Entity set 'BookStoreContext.BookModel'  is null.");
		}

		// GET: Book/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null || _context.BookModel == null)
			{
				return NotFound();
			}

			var bookModel = await _context.BookModel
				.FirstOrDefaultAsync(m => m.Id == id);
			if (bookModel == null)
			{
				return NotFound();
			}

			return View(bookModel);
		}

		// GET: Book/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Book/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("Id")] BookModel bookModel)
		{
			if (ModelState.IsValid)
			{
				_context.Add(bookModel);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(bookModel);
		}

		// GET: Book/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null || _context.BookModel == null)
			{
				return NotFound();
			}

			var bookModel = await _context.BookModel.FindAsync(id);
			if (bookModel == null)
			{
				return NotFound();
			}
			return View(bookModel);
		}

		// POST: Book/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("Id")] BookModel bookModel)
		{
			if (id != bookModel.Id)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(bookModel);
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!BookModelExists(bookModel.Id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			return View(bookModel);
		}

		// GET: Book/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null || _context.BookModel == null)
			{
				return NotFound();
			}

			var bookModel = await _context.BookModel
				.FirstOrDefaultAsync(m => m.Id == id);
			if (bookModel == null)
			{
				return NotFound();
			}

			return View(bookModel);
		}

		// POST: Book/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			if (_context.BookModel == null)
			{
				return Problem("Entity set 'BookStoreContext.BookModel'  is null.");
			}
			var bookModel = await _context.BookModel.FindAsync(id);
			if (bookModel != null)
			{
				_context.BookModel.Remove(bookModel);
			}

			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		public string GetAllBooks()
		{
			return "All books";
		}

		private bool BookModelExists(int id)
		{
			return (_context.BookModel?.Any(e => e.Id == id)).GetValueOrDefault();
		}
	}
}
