using System.Collections.Generic;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace Reviews.Types
{
    [QueryType]
    public class Query
    {   
        public IEnumerable<Review> GetReviews(
            [Service] ReviewRepository repository) =>
            repository.GetReviews();

        [NodeResolver]
        public static Review? GetReviewById(
        ReviewRepository repository,
        int id) =>
        repository.GetReview(id);

        public static IEnumerable<Review> GetReviewsById(
        ReviewRepository repository,
        [ID<Review>] int[] ids)
        {
            foreach (var id in ids)
            {
                var user = repository.GetReview(id);

                if (user is not null)
                {
                    yield return user;
                }
            }
        }
        
        public static User GetUserById(
        ReviewRepository repository,
        [ID<User>] int id)
        => new User(id, "some name");

        public static Product GetProductById(
            ReviewRepository repository,
            [ID<Product>] int id)
            => new Product(id);


        //public IEnumerable<Review> GetReviewsByAuthor(
        //    [Service] ReviewRepository repository,
        //    int authorId) =>
        //    repository.GetReviewsByAuthorId(authorId);

        //public IEnumerable<Review> GetReviewsByProduct(
        //    [Service] ReviewRepository repository,
        //    int upc) =>
        //    repository.GetReviewsByProductId(upc);
    }
}
