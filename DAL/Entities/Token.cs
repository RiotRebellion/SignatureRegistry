﻿using DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Token : NamedEntity
    {
        public virtual Person? Owner { get; set; }

        public virtual Signature? Signature { get; set; }
        
    }
}
