using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CancerInstApi.Models;
using Microsoft.AspNetCore.Cors;
using CancerInstApi.Dependencies;

namespace CancerInstApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class PalindromesController : ControllerBase
    {
        private readonly IPalindromeRepo _palindrome;

        public PalindromesController(IPalindromeRepo palindrome)
        {
            
            _palindrome = palindrome;
        }

        // GET: api/Palindromes
      
        [HttpGet]
        public async Task<List<Palindrome>> GetPalindromesAsync()
        {
            return await _palindrome.GetPalindromesAsync();
        }

        // POST: api/Palindromes
        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> PostPalindrome([FromBody]Palindrome palindrome)
        {
            var addedPalindrome = await _palindrome.PostPalindrome(palindrome);
            if (addedPalindrome == null)
            {
                return BadRequest();
            }
            
            return  Ok(addedPalindrome);
        }
        
    }
}
