using MyAutoFix.Models.Abstracts;
using System;

namespace MyAutoFix.Models.Entities
{
    public class ServiceProduct : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public decimal Price { get; set; }
    }
}
