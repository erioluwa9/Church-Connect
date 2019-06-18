using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChurchConnectLite.Core.Entities;
using ChurchConnectLite.Data.Data;
using Microsoft.AspNetCore.Identity;

namespace ChurchConnectLite.Web.Controllers
{
    public class ChurchesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ChurchContext _context;

        public ChurchesController(ChurchContext context, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Churches
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            if (currentUser == null)
            {
                return Challenge();
            }
           
            var churchContext = await _context.Churches.Include(c => c.Country).Include(c => c.Denominations).Include(c => c.State).FirstOrDefaultAsync(m => m.ApplicationUserId == currentUser.Id); ;
            return View( churchContext);
        }

        // GET: Churches/Dashboard/5
        public async Task<IActionResult> Dashboard()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            if (currentUser == null)
            {
                return Challenge();
            }
           

            var church = await _context.Churches
                .Include(c => c.Country)
                .Include(c => c.Denominations)
                .Include(c => c.State)
                .FirstOrDefaultAsync(m => m.ApplicationUserId == currentUser.Id);
            if (church == null)
            {
                return NotFound();
            }

            return View(church);
        }

        // GET: Churches/Create
        public IActionResult Create()
        {
            var currentUser =  _userManager.GetUserAsync(HttpContext.User);

            if (currentUser == null)
            {
                return Challenge();
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "ID", "ID");
            ViewData["DenominationId"] = new SelectList(_context.Denominations, "ID", "ID");
            ViewData["StateId"] = new SelectList(_context.States, "ID", "ID");
            return View();
        }

        // POST: Churches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DenominationId,StateId,CountryId,ApplicationUserId, Name,YearFounded,About,Email,Phone1,Phone2,WorshipDays,Website,LogoUrl,Address,OnlineServiceUrl,Account,AccountName,AccountNumber,Facebook,Twitter,Instagram")] Church church)
        {

            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (ModelState.IsValid)
            {
                church.ApplicationUserId = currentUser.Id;
                _context.Add(church);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Dashboard));
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "ID", "ID", church.CountryId);
            ViewData["DenominationId"] = new SelectList(_context.Denominations, "ID", "ID", church.DenominationId);
            ViewData["StateId"] = new SelectList(_context.States, "ID", "ID", church.StateId);
            return View(church);
        }

        // GET: Churches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var church = await _context.Churches.FindAsync(id);
            if (church == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "ID", "ID", church.CountryId);
            ViewData["DenominationId"] = new SelectList(_context.Denominations, "ID", "ID", church.DenominationId);
            ViewData["StateId"] = new SelectList(_context.States, "ID", "ID", church.StateId);
            return View(church);
        }

        // POST: Churches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DenominationId,StateId,CountryId,Name,Year,About,Email,Phone1,Phone2,WorshipDays,Website,LogoUrl,Address,OnlineServiceUrl,Account,AccountName,AccountNumber,Facebook,Twitter,Instagram")] Church church)
        {
            if (id != church.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(church);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChurchExists(church.ID))
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
            ViewData["CountryId"] = new SelectList(_context.Countries, "ID", "ID", church.CountryId);
            ViewData["DenominationId"] = new SelectList(_context.Denominations, "ID", "ID", church.DenominationId);
            ViewData["StateId"] = new SelectList(_context.States, "ID", "ID", church.StateId);
            return View(church);
        }

        // GET: Churches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var church = await _context.Churches
                .Include(c => c.Country)
                .Include(c => c.Denominations)
                .Include(c => c.State)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (church == null)
            {
                return NotFound();
            }

            return View(church);
        }

        // POST: Churches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var church = await _context.Churches.FindAsync(id);
            _context.Churches.Remove(church);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChurchExists(int id)
        {
            return _context.Churches.Any(e => e.ID == id);
        }
    }
}
