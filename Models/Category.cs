using System;
using System.Collections.Generic;

namespace COMP2084GetMeAGame.Models
{
        public class Category
        {

            public int Id { get; set; }

            //[Required]
            public string Name { get; set; }


        // reference the child model (1 category to many products)
            public List<Product> Products { get; set; }
    }
    }
