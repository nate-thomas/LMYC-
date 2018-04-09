using LowerMainlandYachtClub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LowerMainlandYachtClub.Data
{
    public class DBInitializer
    {
        public static async Task Initialize(YachtClubDbContext context,
                                      UserManager<User> _userManager,
                                      RoleManager<IdentityRole> _roleManager)
        {
            context.Database.EnsureCreated();

            Debug.WriteLine("In Initializer");

            //Create admin role if not found.
            if (!_roleManager.RoleExistsAsync("Admin").Result)
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            //Create Member role if not found.
            if (!_roleManager.RoleExistsAsync("Member").Result)
            {
                await _roleManager.CreateAsync(new IdentityRole("Member"));
            }

            //First member.
            if (_userManager.FindByEmailAsync("m1@m.m").Result == null)
            {
                User member1 = new User
                {
                    Email = "m1@m.m",
                    UserName = "m1",
                    FirstName = "Rob",
                    LastName = "Stan",
                    MemberStatus = "Full member good standing",
                    SkipperStatus = "Crew",
                    Street = "Cotton Drive",
                    City = "Vancouver",
                    Province = "British Columbia",
                    PostalCode = "V5N 1A7",
                    Country = "Canada",
                    MobilePhone = "7787770088",
                    HomePhone = "",
                    WorkPhone = "",
                    SailingQualifications = "None",
                    SailingExperience = "None",
                    Credits = 320,
                };
                await _userManager.CreateAsync(member1, "P@$$w0rd");
                await _userManager.AddToRoleAsync(_userManager.FindByEmailAsync(member1.Email).Result, "Member");
            }

            if (_userManager.FindByEmailAsync("a1@a.a").Result == null)
            {
                User member1 = new User
                {
                    Email = "a1@a.a",
                    UserName = "a1",
                    FirstName = "Derek",
                    LastName = "Livington",
                    MemberStatus = "Full member good standing",
                    SkipperStatus = "Day skipper",
                    Street = "Fraser Street",
                    City = "Vancouver",
                    Province = "British Columbia",
                    PostalCode = "V1D 3B7",
                    Country = "Canada",
                    MobilePhone = "7781234657",
                    HomePhone = "",
                    WorkPhone = "",
                    SailingQualifications = "Sailing Legend",
                    SailingExperience = "Born in the ocean",
                    Credits = 320,
                };
                await _userManager.CreateAsync(member1, "P@$$w0rd");
                await _userManager.AddToRoleAsync(_userManager.FindByEmailAsync(member1.Email).Result, "Admin");
            }

            if (_userManager.FindByEmailAsync("m2@m.m").Result == null)
            {
                User member1 = new User
                {
                    Email = "m2@m.m",
                    UserName = "m2",
                    FirstName = "Ryan",
                    LastName = "Smith",
                    MemberStatus = "Full member not good standing",
                    SkipperStatus = "Cruise skipper",
                    Street = "East 11th Avenue",
                    City = "Vancouver",
                    Province = "British Columbia",
                    PostalCode = "V1D 3B7",
                    Country = "Canada",
                    MobilePhone = "6048976544",
                    HomePhone = "",
                    WorkPhone = "",
                    SailingQualifications = "None",
                    SailingExperience = "None",
                    Credits = 0,
                };
                await _userManager.CreateAsync(member1, "P@$$w0rd");
                await _userManager.AddToRoleAsync(_userManager.FindByEmailAsync(member1.Email).Result, "Admin");
            }

            context.Boats.AddRange(DummyData.GetBoats());
            await context.SaveChangesAsync();
            context.Bookings.AddRange(DummyData.GetBookings(context));
            await context.SaveChangesAsync();
            context.Report.AddRange(DummyData.GetReports());
            await context.SaveChangesAsync();
        }
    }
}
