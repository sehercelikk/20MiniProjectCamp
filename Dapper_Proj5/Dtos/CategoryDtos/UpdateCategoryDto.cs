﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Proj5.Dtos.CategoryDtos
{
    public class UpdateCategoryDto
    {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public string Description { get; set; }
        
    }
}
