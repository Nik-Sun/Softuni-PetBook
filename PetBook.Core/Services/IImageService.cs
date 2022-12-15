using Microsoft.AspNetCore.Http;
using Minio.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Services
{
    public interface IImageService
    {
        public Task<string> Upload(Stream data);
        public Task Delete(string imageUrl);
    }
}
