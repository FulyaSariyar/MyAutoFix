﻿using Microsoft.AspNetCore.Http;

namespace MyAutoFix.ViewModels
{
    public class ServiceProductViewModel
    {
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public decimal Price { get; set; }
        public IFormFile File { get; set; }
    }
}
