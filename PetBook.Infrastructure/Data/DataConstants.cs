namespace PetBook.Infrastructure.Data
{
    public class DataConstants
    {
        public static class UserConstants
        {
            public const int FirstNameMaxLength = 50;
            public const int LastNameMaxLength = 50;
            public const int AddressMaxLength = 100;
            public const string DefaultImageUrl = "http://localhost:9000/user-images/no-picture.jpg";
        }
        public static class PetConstants
        {
            public const int NameMaxLength = 20;
            public const int DescriptionMaxLength = 5000;

            public const int MaxPetImageFileSize = 5 * 1024 * 1024;
            public const int MaxPetImagesCount = 12;
        }
        public static class CityConstants
        {
            public const int NameMaxLength = 100;
        }
        public static class BreedConstants
        {
            public const int NameMaxLength = 100;
        }
        public static class AddressConnstants
        {
            public const int AddressTextMaxLength = 200;
        }
        public static class MinioBuckets
        {
            public const string PetBucket = "pet-images";
            public const string UserBucket = "user-images";
        }
    }
}
