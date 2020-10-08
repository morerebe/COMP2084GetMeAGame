using System;
namespace COMP2084GetMeAGame.Models
{
    public class Product
    { 
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int CategoryId { get; set; }
            public string Photo { get; set; }
            public string Description { get; set; }
            public int Rating { get; set; }

            // reference the parent class (1 Category to Many Products)

            public Category Category { get; set; }
        }
    }
