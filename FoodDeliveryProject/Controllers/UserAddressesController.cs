﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodDeliveryProject.Data;
using FoodDeliveryProject.Models;

namespace FoodDeliveryProject.Controllers
{
    public class UserAddressesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserAddressesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UserAddresses
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserAddresses.ToListAsync());
        }

        // GET: UserAddresses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAddress = await _context.UserAddresses
                .FirstOrDefaultAsync(m => m.UserAddressID == id);
            if (userAddress == null)
            {
                return NotFound();
            }

            return View(userAddress);
        }

        // GET: UserAddresses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserAddresses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserAddressID,City,Address")] UserAddress userAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userAddress);
        }

        // GET: UserAddresses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAddress = await _context.UserAddresses.FindAsync(id);
            if (userAddress == null)
            {
                return NotFound();
            }
            return View(userAddress);
        }

        // POST: UserAddresses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserAddressID,City,Address")] UserAddress userAddress)
        {
            if (id != userAddress.UserAddressID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserAddressExists(userAddress.UserAddressID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(userAddress);
        }

        // GET: UserAddresses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAddress = await _context.UserAddresses
                .FirstOrDefaultAsync(m => m.UserAddressID == id);
            if (userAddress == null)
            {
                return NotFound();
            }

            return View(userAddress);
        }

        // POST: UserAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userAddress = await _context.UserAddresses.FindAsync(id);
            _context.UserAddresses.Remove(userAddress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserAddressExists(int id)
        {
            return _context.UserAddresses.Any(e => e.UserAddressID == id);
        }
    }
}
