﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using mvc_test.Data;
using mvc_test.Models;

namespace mvc_test.Controllers
{
    public class AccountController : Controller
    {
        private readonly mvc_testContext _context;

        public AccountController(mvc_testContext context)
        {
            _context = context;
        }
        public IActionResult sucess()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]

        // register user for resgistration
        public IActionResult SignUp(user user)
        {
            System.Console.WriteLine("*************************************************************************");

            if (ModelState.IsValid)
            {
                if (_context.user.Any(u => u.ID == user.ID))
                {
                    ModelState.AddModelError("ID", "ID already in use!!!");
                    return View("SignUp");
                }
                PasswordHasher<user> Hasher = new PasswordHasher<user>();
                user.password = Hasher.HashPassword(user, user.password);

                _context.Add(user);
                _context.SaveChanges();

                //setting user's first name in session
                HttpContext.Session.SetString("ID", user.ID);

                return RedirectToAction("sucess");
            }
            return View("sucess");

        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(user User)
        {
            List<user> All = _context.user.ToList();
            ViewBag.AllUsers = All;

            if (ModelState.IsValid)
            {
                System.Console.WriteLine("========================================");
                System.Console.WriteLine("Form is Valid");
                System.Console.WriteLine("========================================");

                var userInDb = _context.user.SingleOrDefault(u => u.ID == User.ID);

                if (userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email");
                    return View("Login");
                }
                var hasher = new PasswordHasher<user>();
                var result = hasher.VerifyHashedPassword(User, userInDb.password, User.password);

                if (result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Password");
                    return View("Login");
                }
                HttpContext.Session.SetString("ID", userInDb.ID);

                return RedirectToAction("sucess");
            }
            System.Console.WriteLine("========================================");
            System.Console.WriteLine("Form is Invalid");
            System.Console.WriteLine("========================================");

            return View("Login");
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return NoContent();
        }

    }
}
