using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmpTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpsController : ControllerBase
    {
        private s17041Context _context;
        public EmpsController(s17041Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetEmps(string order="ename")
        {
            if (order == "sal")
            {
                return Ok(_context.Emp.OrderBy(e=>e.Sal).ToList());
            }
            return Ok(_context.Emp.OrderBy(e => e.Ename).ToList());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetEmp(int id)
        {
            var emp = _context.Emp.FirstOrDefault(e => e.Empno == id);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }
        [HttpPost]
        public IActionResult Create(Emp newEmp)
        {
            _context.Emp.Add(newEmp);
            _context.SaveChanges();

            return StatusCode(201, newEmp);
        }
        [HttpPut("{empno:int}")]
        public IActionResult Update(Emp updatedEmp)
        {
                           
            if (_context.Emp.Count(e => e.Empno == updatedEmp.Empno) == 0)
            {
                return NotFound(); 
            }

            _context.Emp.Attach(updatedEmp);
            _context.Entry(updatedEmp).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(updatedEmp);
        }
        [HttpDelete("{empno:int}")]
        public IActionResult Delete(int empno)
        {
            var emp = _context.Emp.FirstOrDefault(e => e.Empno == empno);
            if (emp == null)
            {
                return NotFound();
            }

            _context.Emp.Remove(emp);
            _context.SaveChanges();

            return Ok(emp);

        }
    }
}