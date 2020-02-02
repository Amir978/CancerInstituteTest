using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CancerInstApi.Models
{
    public class Palindrome
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Phrase { get; set; }
        public DateTime DateAdded { get; set; }
       

       
    }
}
