using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManage.Models;

namespace StudentManage.Pages.cources
{
    public class EditModel : PageModel
    {
        private readonly StudentManage.Models.StudentManage1Context _context;

        public EditModel(StudentManage.Models.StudentManage1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Cources Cources { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cources = await _context.Cources.FirstOrDefaultAsync(m => m.ID == id);

            if (Cources == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cources).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourcesExists(Cources.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CourcesExists(int id)
        {
            return _context.Cources.Any(e => e.ID == id);
        }
    }
}
