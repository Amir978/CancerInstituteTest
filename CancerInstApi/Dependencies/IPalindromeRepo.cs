using CancerInstApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CancerInstApi.Dependencies
{
    public interface IPalindromeRepo
    {
       Task<List<Palindrome>> GetPalindromesAsync();
        Task<Palindrome> PostPalindrome(Palindrome palindrome);
    }
}
