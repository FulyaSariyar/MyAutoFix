﻿using AutoMapper;

namespace MyAutoFix.MapperProfiles
{
    public class AccountProfile:Profile
    {
        
            public AccountProfile()
            {
                //CreateMap<ApplicationUser, UserProfileViewModel>().ReverseMap();
                // CreateMap<UserProfileViewModel,ApplicationUser>()  // Yukarda ReverseMap() işlemi yapıldığı için 

            }
    }
}
