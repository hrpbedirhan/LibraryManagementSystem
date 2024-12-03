using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            var authors = Data.Author.Select(a => new AuthorViewModel()
            {
                Id = a.Id,
                FullName = $"{a.FirstName} {a.LastName}",
                DateOfBirth = a.DateOfBirth,
                BookCount = Data.Book.Count(b => b.AuthorId == a.Id),
            }).ToList();

            return View(authors);
        }

        //add author
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddAuthorViewModel author)
        {
            if (ModelState.IsValid)
            {
                Author newAuthor = new Author()
                {
                    Id = Data.Author.Max(b => b.Id) + 1,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    DateOfBirth = author.DateOfBirth
                };
                Data.Author.Add(newAuthor);

                TempData["Message"] = "Yeni yazar başarıyla eklendi.";
                return RedirectToAction("Index");
            }

            return View();
        }

        //edit author
        public IActionResult Edit(int id)
        {
            Author author = Data.Author.FirstOrDefault(a => a.Id == id);

            if (author == null)
                return NotFound();

            EditAuthorViewModel vm = new EditAuthorViewModel()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth
            };

            return View(vm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditAuthorViewModel vm)
        {
            Author author = Data.Author.FirstOrDefault(a => a.Id == vm.Id);

            if (author == null)
                return NotFound();

            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine($"Hata: {error.ErrorMessage}");
            }
            if (ModelState.IsValid)
            {
                author.Id = vm.Id;
                author.FirstName = vm.FirstName;
                author.LastName = vm.LastName;
                author.DateOfBirth = vm.DateOfBirth;

                TempData["Message"] = "Değişiklikler başarıyla kaydedildi.";
                return RedirectToAction("Index");
            }

            return View(vm);
        }

        //delete author
        public IActionResult Delete(int id)
        {
            Author author = Data.Author.FirstOrDefault(a => a.Id == id);

            if (author == null)
                return NotFound();

            return View(author);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            Author author = Data.Author.FirstOrDefault(a => a.Id == id);

            if (author == null)
                return NotFound();

            Data.Author.Remove(author);
            TempData["Message"] = "Yazar başarıyla silindi.";
            return RedirectToAction("Index");
        }

        //author details
        public IActionResult Details(int id)
        {
            var author = Data.Author.FirstOrDefault(a => a.Id == id);

            if (author == null)
                return NotFound();

            var vm = new AuthorViewModel
            {
                Id = author.Id,
                FullName = $"{author.FirstName} {author.LastName}",
                DateOfBirth = author.DateOfBirth,
                BookCount = Data.Book.Count(b => b.AuthorId == author.Id)
            };
            return View(vm);
        }
    }
}
