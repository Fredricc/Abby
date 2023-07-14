using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories;
[BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            this._db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public Category Category { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            await _db.Category.AddAsync(Category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }

