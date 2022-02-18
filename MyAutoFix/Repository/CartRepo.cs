using MyAutoFix.Data;
using MyAutoFix.Models.Entities;
using MyAutoFix.Repository.Abstracts;
using System;

namespace MyAutoFix.Repository
{
    public class CartRepo : BaseRepository<CartItem, Guid>
    {
        public CartRepo(MyContext context) : base(context)
        {

        }
    }
}
