using CloudinaryDotNet;
using CloudinaryDotNet.Actions;


namespace PetBook.Core.Services
{
    public class ImageService : IImageService
    {

        private readonly Cloudinary client;

        public ImageService(Cloudinary _client)
        {
            client = _client;
        }

        public async Task<string> Upload(Stream data)
        {
            ImageUploadResult result;
            ImageUploadParams parameters;

            using (data)
            {
                parameters = new ImageUploadParams()
                {
                    File = new FileDescription("file", data),
                    PublicId = $"{Guid.NewGuid()}"

                };

                result = await client.UploadAsync(parameters);

            }

            return result.Url.ToString();
        }


        public async Task Delete(string imageUrl)
        {
            var id = imageUrl.Split("/").Last().Split(".").FirstOrDefault();
            if (id != null)
            {
                var delParams = new DeletionParams(id)
                {
                    Invalidate = true
                };
                await client.DestroyAsync(delParams);

            }

        }


    }
}
