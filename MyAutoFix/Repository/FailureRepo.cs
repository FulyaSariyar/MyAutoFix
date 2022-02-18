using MyAutoFix.Data;
using MyAutoFix.Models.Entities;
using MyAutoFix.Repository.Abstracts;
using System;

namespace MyAutoFix.Repository
{
    public class FailureRepo : BaseRepository<FailureLogging, Guid>
    {
        public FailureRepo(MyContext context) : base(context)
        {

        }
    }
}
