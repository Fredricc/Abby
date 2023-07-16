using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Categories;
[BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DeleteModel(ApplicationDbContext db)
        {
            this._db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public Category Category { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnDelete()
        {
            //await _db.Category.Remove(Category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }

