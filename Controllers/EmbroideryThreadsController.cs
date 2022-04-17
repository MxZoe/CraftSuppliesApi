using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using craftSupplies.Models;
using System.Linq;

namespace CraftSupplies.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EmbroideryThreadController : Controller
  {
    private readonly CraftSuppliesContext _db;

    public EmbroideryThreadController(CraftSuppliesContext db)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      var allThreads = EmbroideryThread.GetThreads();
      return View(allThreads);
    }
    // GET api/EmbroideryThreads
    [HttpGet]
    public async Task<ActionResult<IEnumerable<EmbroideryThread>>> Get()
    {
      return await _db.EmbroideryThreads.ToListAsync();
    }

    // POST api/EmbroideryThreads
    [HttpPost]
    public async Task<ActionResult<EmbroideryThread>> Post(EmbroideryThread thread)
    {
      _db.EmbroideryThreads.Add(thread);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = thread.Id }, thread);
    }

    // GET: api/embroiderythreads/dmc
    [HttpGet("{brand}")]
    public async Task<ActionResult<IEnumerable<EmbroideryThread>>> GetBrand(string brand)
    {
  
      var query = _db.EmbroideryThreads.AsQueryable();

      if (brand != null)
      {
        query = query.Where(entry => entry.Brand == brand);
      }


      return await query.ToListAsync();
    }
  }
}