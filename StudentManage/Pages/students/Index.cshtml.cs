using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManage.Models;

namespace StudentManage.Pages.students
{
    public class IndexModel : PageModel
    {
        private readonly StudentManage.Models.StudentManage1Context _context;

        public IndexModel(StudentManage.Models.StudentManage1Context context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; }

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}
