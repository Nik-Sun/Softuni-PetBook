namespace PetBook.Infrastructure.Data
{
    public class DataConstants
    {
        public static class UserConstants
        {
            public const int FirstNameMaxLength = 50;
            public const int LastNameMaxLength = 50;
            public const int AddressMaxLength = 100;
        }
        public static class PetConstants
        {
            public const int NameMaxLength = 20;
            public const int DescriptionMaxLength = 5000; 
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
