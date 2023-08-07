using ErrorOr;
using Products.Domain.Product;

namespace Products.Domain.Common.Errors;

public static partial class Errors
{
    public static class Product
    {
        private const int MIN_LENGTH = 3;
        private const int MAX_DESCRIPTION_LENGTH = 100;

        public static Error DuplicateName => Error.Conflict(
            code: "Product.DuplicateName",
            description: "Name already exists.");

        public static Error InvalidName => Error.Validation(
            code: "Product.InvalidName",
            description: $"Product name must be at least {MIN_LENGTH}");

        public static Error InvalidDescription => Error.Validation(
            code: "Product.InvalidDescription",
            description: $"Product description must be at least {MIN_LENGTH}" +
                $" characters long and at most {MAX_DESCRIPTION_LENGTH} characters long.");

        public static Error NotFound => Error.NotFound(
            code: "Product.NotFound",
            description: "Product not found");
    }
}