using System;

namespace Reviews.Types
{
    public record Review(int Id, int AuthorId, int Upc, string Body);
}