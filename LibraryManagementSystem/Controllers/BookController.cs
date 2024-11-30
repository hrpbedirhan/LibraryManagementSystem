using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var books = Data.Book.Select(b => new BookViewModel()
            {
                Id = b.Id,
                Title = b.Title,
                AuthorName = Data.Author
                                 .Where(a => a.Id == b.AuthorId)
                                 .Select(a => a.FirstName + " " + a.LastName)
                                 .FirstOrDefault() ?? "Yazar Bilgisi yok",
                Genre = b.Genre,
                PublishDate = b.PublishDate,
                ISBN = b.ISBN,
                CopiesAvailable = b.CopiesAvailable
            }).ToList();

            return View(books);
        }

        //add book
        public IActionResult Add()
        {
            ViewData["Author"] = Data.Author;
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddBookViewModel book)
        {
            if (ModelState.IsValid)
            {
                Book newBook = new Book()
                {
                    Id = Data.Book.Max(b => b.Id) + 1,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    Genre = book.Genre,
                    PublishDate = book.PublishDate,
                    ISBN = book.ISBN,
                    CopiesAvailable = book.CopiesAvailable,
                };
                Data.Book.Add(newBook);

                TempData["Mesaj"] = "Yeni kitap başarıyla eklendi.";
                return RedirectToAction("Index");
            }

            ViewData["Author"] = Data.Author;
            return View();
        }

        //edit book
        public IActionResult Edit(int id)
        {
            Book book = Data.Book.FirstOrDefault(b => b.Id == id);

            if (book == null)
                return NotFound();

            EditBookViewModel vm = new EditBookViewModel()
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable,
            };

            ViewData["Author"] = Data.Author;
            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditBookViewModel vm)
        {
            Book book = Data.Book.FirstOrDefault(b => b.Id == vm.Id);

            if (book == null)
                return NotFound();

            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine($"Hata: {error.ErrorMessage}");
            }
            if (ModelState.IsValid)
            {
                book.Id = vm.Id;
                book.Title = vm.Title;
                book.AuthorId = vm.AuthorId;
                book.Genre = vm.Genre;
                book.PublishDate = vm.PublishDate;
                book.ISBN = vm.ISBN;
                book.CopiesAvailable = vm.CopiesAvailable;

                TempData["Mesaj"] = "Değişiklikler başarıyla kaydedildi.";
                return RedirectToAction("Index");
            }

            ViewData["Author"] = Data.Author;
            return View(vm);
        }

        //delete book
        public IActionResult Delete(int id)
        {
            Book book = Data.Book.FirstOrDefault(b => b.Id == id);

            if (book == null)
                return NotFound();

            return View(book);
        }

        [HttpPost]
        public IActionResult DeleteConFirm(int id)
        {
            Book book = Data.Book.FirstOrDefault(b => b.Id == id);

            if (book == null)
                return NotFound();

            Data.Book.Remove(book);
            TempData["Mesaj"] = "Kitap başarıyla silindi.";
            return RedirectToAction("Index");
        }

        //details
        public IActionResult Details(int id)
        {
            var book = Data.Book.FirstOrDefault(b => b.Id == id);
            
            if (book == null)
                return NotFound();

            var vm = new BookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                AuthorName = Data.Author
                                     .Where(a => a.Id == book.AuthorId)
                                     .Select(a => a.FirstName + " " + a.LastName)
                                     .FirstOrDefault() ?? "Yazar Bilgisi yok",
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable
            };
            return View(vm);
        }
    }
}
