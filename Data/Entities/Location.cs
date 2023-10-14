﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class Location: BaseEntity
{
    public int StartPosition { get; set; }

    public int RackId { get; set; }
    public virtual Rack Rack { get; set; }

    public virtual ICollection<DeviceLocation> DeviceLocations { get; set; }    
}