using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using craftSupplies.Models;

namespace CraftSupplies.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EmbroideryThreadController : ControllerBase
  {
    private readonly CraftSuppliesContext _db;

    public EmbroideryThreadController(CraftSuppliesContext db)
    {
      _db = db;
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
  }
}