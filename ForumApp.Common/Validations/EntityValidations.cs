namespace ForumApp.Common.Validations;

public static class EntityValidations
{
    public static class PostConstants
    {
        public const string Required = "The field {0} is required";
        public const int TitleMaxLength = 50;
        public const int TitleMinLength = 5;
        public const string TitleErrorMessage = "{0} must be between {2} and {1} symbols.";
        public const int ContentMaxLength = 1500;
        public const int ContentMinLength = 50;
        public const string ContentErrorMessage = "{0} must be between {2} and {1} symbols.";

    }
}
