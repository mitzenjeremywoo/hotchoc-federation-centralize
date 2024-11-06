using HotChocolate;
using HotChocolate.Types;
using System.Collections.Generic;

namespace Reviews.Types
{
    public record Author(int Id, string Name);

    public sealed class Product
    {
        public Product(int upc)
        {
            Upc = upc;
        }

        public int Upc { get; }

        public IEnumerable<Review> GetReviews([Service] ReviewRepository repository)
            => repository.GetReviewsByProductId(Upc);
    }


    public sealed class User
    {
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }

        public string Name { get; }

        public IEnumerable<Review> GetReviews([Service] ReviewRepository repository)
            => repository.GetReviewsByAuthorId(Id);
    }

}