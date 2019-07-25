using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoreMvcProject.Models;

namespace CoreMvcProject.Controllers
{
    public class UsersController : Controller
    {
        private readonly CoreMvcProjectContext _context;

        public UsersController(CoreMvcProjectContext context)
        {
            _context = context;
        }

        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register([Bind("UserId,UserPw,UserName,UserEmail")]User user)
        {
            if (ModelState.IsValid)
            {
                user.UserRegisterDate = DateTime.Now;
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("index","Home");
            }
            return View();
        }

    }
}
