using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.DTOs.Request
{
    public class RecipeCategoriesGetDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public DateTime DateCreated { get; set; }   
    }
}
