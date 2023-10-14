﻿using Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class AdditionalService : BaseEntity
{
    public AdditionalServiceStatus Status { get; set; }
    public int Quantity { get; set; }

    public int CollocationId { get; set; }
    public virtual Collocation Collocation { get; set; }

    public int ServiceId { get; set; }
    public virtual Service Service { get; set; }
}