﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormativeCalculator.Database.Helper
{
    public class RecipeResourceParameters
    {

        const int maxPageSize = 100;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 10;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = ((value > maxPageSize) || (value <= 0)) ? maxPageSize : value;
        }
        public string OrderBy { get; set; } = "Price";

    }
}
