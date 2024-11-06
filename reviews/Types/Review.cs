using HotChocolate.Types;

namespace Reviews.Types
{
    public record Review(int Id, int AuthorId, int Upc, string Body);

    public class ReviewType : ObjectType<Review>
    {
        protected override void Configure(IObjectTypeDescriptor<Review> descriptor)
        {
            descriptor
               .ImplementsNode()
               .IdField(n => n.Upc)
               .ResolveNode(async (context, id) =>
               {
                   var productRepository = context.Service<ReviewRepository>();
                   return productRepository.GetReview(id);
               });
        }
    }
}