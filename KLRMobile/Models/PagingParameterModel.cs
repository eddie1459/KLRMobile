﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KLRMobile.Models
{
    public class PagingParameterModel
    {
        public int PageNumber { get; set; } = 1;
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
