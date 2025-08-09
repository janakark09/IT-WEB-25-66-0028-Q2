using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManage.Models;

namespace StudentManage.Pages.cources
{
    public class CreateModel : PageModel
    {
        private readonly StudentManage.Models.StudentManage1Context _context;

        public CreateModel(StudentManage.Models.StudentManage1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cources Cources { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cources.Add(Cources);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}