﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Services
{
    public interface IImageService
    {
        public Task<string> Upload(string bucketName, Stream data);
        public Task Delete(string bucketName, string imageName);
    }
}
