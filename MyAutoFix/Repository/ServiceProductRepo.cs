using MyAutoFix.Data;
using MyAutoFix.Models.Entities;
using MyAutoFix.Repository.Abstracts;
using System;

namespace MyAutoFix.Repository
{
    public class ServiceProductRepo : BaseRepository<ServiceProduct, Guid>
    {
        public ServiceProductRepo(MyContext context) : base(context)
        {
        }
    }
}
