using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CancerInstApi.BusinessLogic;
using CancerInstApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CancerInstApi.Dependencies
{
    public class PalindromeRepo : IPalindromeRepo
    {
   
        private CancerInstContext _context;
        private IPalindromeLogic _logic;
        public PalindromeRepo(CancerInstContext context, IPalindromeLogic logic)
        {
            _context = context;
            _logic = logic;
        }

        public async Task<List<Palindrome>> GetPalindromesAsync()
        {
            return await _context.Palindromes.ToListAsync();
        }
        public async Task<Palindrome> PostPalindrome(Palindrome palindrome)
        {

            if (!String.IsNullOrEmpty(palindrome.Phrase))
            {
                if (_logic.IsPalindrome(palindrome.Phrase))
                {

                    palindrome.DateAdded = DateTime.Now;
                    _context.Palindromes.Add(palindrome);
                    await _context.SaveChangesAsync();
                    return palindrome;
                }
            }
            return null;
        }
       


    }
}
