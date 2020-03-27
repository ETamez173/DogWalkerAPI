using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace DogWalkerAPI.Models


{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public string Breed { get; set; }
        public string Notes { get; set; }
    }
}