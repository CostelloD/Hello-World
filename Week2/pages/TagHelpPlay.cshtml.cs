using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week2.pages
{
    public class TagHelpPlayModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }


        public void OnGet()
        {

        }
    }
}