﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string TypeName { get; set; }
        public short SignUpFee { get; set; }
        public byte DurrationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}