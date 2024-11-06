using System.Collections.Generic;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace Reviews.Types
{
    [QueryType]
    public class Query
    {
        //public IEnumerable<Product> GetTopProducts(
        //    int first,
        //    [Service] ProductRepository repository) =>
        //    repository.GetTopProducts(first);

        //[NodeResolver]
        //public Product GetProduct(
        //    int upc,
        //    [Service] ProductRepository repository) =>
        //    repository.GetProduct(upc);

        [NodeResolver]
        public Review GetReview(
        [Service] ReviewRepository repository,
        int upc) =>
        repository.GetReview(upc);

        public IEnumerable<Review> GetReviews(
            [Service] ReviewRepository repository) =>
            repository.GetReviews();

        public IEnumerable<Review> GetReviewsByAuthor(
            [Service] ReviewRepository repository,
            int authorId) =>
            repository.GetReviewsByAuthorId(authorId);

        public IEnumerable<Review> GetReviewsByProduct(
            [Service] ReviewRepository repository,
            int upc) =>
            repository.GetReviewsByProductId(upc);

        //public IEnumerable<Review> GetReviews(
        //    [Service] ReviewRepository repository) =>
        //    repository.GetReviews();

    }
}