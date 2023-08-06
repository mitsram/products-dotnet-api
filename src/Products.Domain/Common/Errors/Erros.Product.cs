using ErrorOr;

namespace Products.Domain.Common.Errors;

public static partial class Errors
{
    public static class Product
    {
        public static Error DuplicateName => Error.Conflict(
            code: "Product.DuplicateName",
            description: "Name already exists.");
    }
}