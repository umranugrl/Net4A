﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category
    {
        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        public Category()
        {
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}