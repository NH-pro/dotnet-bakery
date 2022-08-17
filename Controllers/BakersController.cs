using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DotnetBakery.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetBakery.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // url route
    public class BakersController : ControllerBase
    {
        private readonly ApplicationContext _context; // _ means a private field
        public BakersController(ApplicationContext context) {
            _context = context;
        }

        // Our REST API

        // get all bakers
        [HttpGet] // HTTP methods
        // router.get()
        public IEnumerable<Baker> GetAll() {
            Console.WriteLine("Get all bakers");

            // must return something
            return _context.Bakers;
        }


        // post
        [HttpPost]
        public IActionResult Post(Baker baker) {

            // SQL trancsactions
            _context.Add(baker);
            _context.SaveChanges();

            // 201 response
            return CreatedAtAction(nameof(Post), new {id = baker.id }, baker);
        }
    }
}
