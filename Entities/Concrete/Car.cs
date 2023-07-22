﻿using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string CarName { get; set; }
    }
}
