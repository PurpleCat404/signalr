using System;
using System.Collections.Generic;

namespace BadNews.Repositories.Comments;

public interface ICommentsRepository
{
    IReadOnlyCollection<Comment> GetComments(Guid newsId);
}