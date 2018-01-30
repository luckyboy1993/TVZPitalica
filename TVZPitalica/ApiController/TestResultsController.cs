using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TVZPitalica.DAL.Entities;

namespace TVZPitalica.ApiController
{
    [Produces("application/json")]
    [Route("api/TestResults")]
    public class TestResultsController : Controller
    {
        private readonly PitalicaDBContext _context;

        public TestResultsController(PitalicaDBContext context)
        {
            _context = context;
        }

        // GET: api/TestResults
        [HttpGet]
        public IEnumerable<TestResult> GetBusinessEntity()
        {
            return _context.BusinessEntity;
        }

        // GET: api/TestResults/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestResult([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var testResult = await _context.BusinessEntity.SingleOrDefaultAsync(m => m.Id == id);

            if (testResult == null)
            {
                return NotFound();
            }

            return Ok(testResult);
        }

        // PUT: api/TestResults/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestResult([FromRoute] int id, [FromBody] TestResult testResult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != testResult.Id)
            {
                return BadRequest();
            }

            _context.Entry(testResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestResultExists(id))
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

        // POST: api/TestResults
        [HttpPost]
        public async Task<IActionResult> PostTestResult([FromBody] TestResult testResult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.BusinessEntity.Add(testResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestResult", new { id = testResult.Id }, testResult);
        }

        // DELETE: api/TestResults/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestResult([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var testResult = await _context.BusinessEntity.SingleOrDefaultAsync(m => m.Id == id);
            if (testResult == null)
            {
                return NotFound();
            }

            _context.BusinessEntity.Remove(testResult);
            await _context.SaveChangesAsync();

            return Ok(testResult);
        }

        private bool TestResultExists(int id)
        {
            return _context.BusinessEntity.Any(e => e.Id == id);
        }
    }
}