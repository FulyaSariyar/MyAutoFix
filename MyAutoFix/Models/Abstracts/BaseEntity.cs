using System;
using System.ComponentModel.DataAnnotations;

namespace MyAutoFix.Models.Abstracts
{
    public abstract class BaseEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [StringLength(128)]
        public string CreatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [StringLength(128)]

        public string UpdatedUser { get; set; }
    }
}
