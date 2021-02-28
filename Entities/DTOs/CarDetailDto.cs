using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int Id { get; set; }
        public int CarName { get; set; }
        public int BrandName { get; set; }
        public int ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        
    }
}
