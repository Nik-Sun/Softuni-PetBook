using Microsoft.Extensions.Configuration;
using Minio;
using Minio.Exceptions;

namespace PetBook.Core.Services
{
    public class ImageService : IImageService
    {
        private readonly IConfiguration configuration;
        private readonly MinioClient client;

        public ImageService(IConfiguration _configuration)
        {
            configuration = _configuration;
            client = new MinioClient()
              .WithEndpoint(configuration.GetSection("MinioCreds:Endpoint").Value)
              .WithCredentials(configuration.GetSection("MinioCreds:AccessKey").Value
              , configuration.GetSection("MinioCreds:SecretKey").Value)
              .Build();
        }

        public async Task<string> Upload(string bucketName,Stream data)
        {
            var endpoint = configuration.GetSection("MinioCreds:Endpoint").Value;
            var accessKey = configuration.GetSection("MinioCreds:AccessKey").Value;
            var secretKey = configuration.GetSection("MinioCreds:SecretKey").Value;
            var fileName = $"{Guid.NewGuid()}.jpg";
         
            var objectName = fileName;
            var contentType = "image/jpeg";
            try
            {
               
              
                var putObjectArgs = new PutObjectArgs()
                    .WithBucket(bucketName)
                    .WithObject(fileName)
                    .WithStreamData(data)
                    .WithObjectSize(data.Length)
                    .WithContentType(contentType);
                   

                await client.PutObjectAsync(putObjectArgs).ConfigureAwait(false);
                Console.WriteLine("Successfully uploaded " + objectName);

                return $"http://{endpoint}/{bucketName}/{fileName}";
            }
            catch (MinioException e )
            {
                Console.WriteLine("File Upload Error: {0}", e.Message);
                return @"http://localhost/pet-images/noImage.jpg";
            }

        }


        public async Task Delete(string bucketName,string imageName)
        {
            try
            {
                RemoveObjectArgs rmArgs = new RemoveObjectArgs()
                                              .WithBucket(bucketName)
                                              .WithObject(imageName);
                await client.RemoveObjectAsync(rmArgs);
                Console.WriteLine($"successfully removed {bucketName}/{imageName}");
            }
            catch (MinioException e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

       
    }
}
