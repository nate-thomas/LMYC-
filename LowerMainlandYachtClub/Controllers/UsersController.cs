using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LowerMainlandYachtClub.Data;
using LowerMainlandYachtClub.Models;
using Microsoft.AspNetCore.Identity;

namespace LowerMainlandYachtClub.Controllers
{
    public class UsersController : Controller
    {
        private readonly YachtClubDbContext _context;
        private readonly UserManager<User> _userManager;

        public UsersController(YachtClubDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var yachtClubDbContext = _context.Users.Include(u => u.EmergencyContacts);
            return View(await yachtClubDbContext.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.EmergencyContacts)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            ViewData["EmergencyContactId"] = new SelectList(_context.EmergencyContacts, "EmergencyContactId", "EmergencyContactId");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,MemberStatus,SkipperStatus,Street,City,Province,PostalCode,Country,MobilePhone,HomePhone,WorkPhone,SailingQualifications,Skills,SailingExperience,Credits,EmergencyContactId,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmergencyContactId"] = new SelectList(_context.EmergencyContacts, "EmergencyContactId", "EmergencyContactId", user.EmergencyContactId);
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.SingleOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["EmergencyContactId"] = new SelectList(_context.EmergencyContacts, "EmergencyContactId", "EmergencyContactId", user.EmergencyContactId);
            UserViewModel userViewModel = new UserViewModel
            {
                Id = user.Id,
                UserName = user.UserName
            };
            ViewBag.Role = new SelectList(_context.Roles, "Name", "Name");
            return View(userViewModel);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // string id, [Bind("FirstName,LastName,MemberStatus,SkipperStatus,Street,City,Province,PostalCode,Country,MobilePhone,HomePhone,WorkPhone,SailingQualifications,Skills,SailingExperience,Credits,EmergencyContactId,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] User user
        public async Task<IActionResult> Edit(UserViewModel userViewModel)
        {
            //if (id != user.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(user);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!UserExists(user.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["EmergencyContactId"] = new SelectList(_context.EmergencyContacts, "EmergencyContactId", "EmergencyContactId", user.EmergencyContactId);
            //return View(user);

            if (ModelState.IsValid)
            {

                var updatedUser = _context.Users.SingleOrDefault(x => x.Id == userViewModel.Id);
                await this._userManager.AddToRoleAsync(updatedUser, userViewModel.Role);

                return RedirectToAction(nameof(Index));
            }
            return View(userViewModel);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.EmergencyContacts)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(m => m.Id == id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
