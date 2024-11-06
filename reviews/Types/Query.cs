using System.Collections.Generic;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Types.Relay;

namespace Reviews.Types
{
    [QueryType]
    public class Query
    {
        [NodeResolver]
        public IEnumerable<Review> GetReviews(
            [Service] ReviewRepository repository) =>
            repository.GetReviews();

        [NodeResolver]
        public IEnumerable<Review> GetReviewsByAuthor(
            [Service] ReviewRepository repository,
            int authorId) =>
            repository.GetReviewsByAuthorId(authorId);

        public IEnumerable<Review> GetReviewsByProduct(
            [Service] ReviewRepository repository,
            int upc) =>
            repository.GetReviewsByProductId(upc);
    }
}