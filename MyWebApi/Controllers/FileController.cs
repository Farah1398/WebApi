using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebApi.Data;
using MyWebApi.Models;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        //use the dependency injection to access the config. from "appsettings.cs"
        private readonly DataContext _context;
        public FileController(DataContext context)
        {
            _context = context;
        }




        // GET: api/File
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Table_File>>> Getfiles()
        {
            return await _context.files.ToListAsync();
        }

        // GET: api/File/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Table_File>> GetTable_File(int id)
        {
            var table_File = await _context.files.FindAsync(id);

            if (table_File == null)
            {
                return NotFound();
            }

            return table_File;
        }

        // PUT: api/File/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTable_File(int id, Table_File table_File)
        {
            if (id != table_File.FileId)
            {
                return BadRequest();
            }

            _context.Entry(table_File).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Table_FileExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/File
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Table_File>> PostTable_File(Table_File table_File)
        {
            _context.files.Add(table_File);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTable_File", new { id = table_File.FileId }, table_File);
        }

        // DELETE: api/File/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTable_File(int id)
        {
            var table_File = await _context.files.FindAsync(id);
            if (table_File == null)
            {
                return NotFound();
            }

            _context.files.Remove(table_File);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Table_FileExists(int id)
        {
            return _context.files.Any(e => e.FileId == id);
        }
    }
}
