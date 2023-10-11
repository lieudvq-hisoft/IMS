﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class Service: BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual ICollection<AdditionalService> AdditionalServices { get; set; }
}
