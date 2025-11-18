using System;
using System.Linq;
using BadNews.Models.Comments;
using BadNews.Repositories.Comments;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class CommentsController : ControllerBase
{
    private readonly CommentsRepository commentsRepository;

    public CommentsController(CommentsRepository commentsRepository)
    {
        this.commentsRepository = commentsRepository;
    }

    // GET
    [HttpGet("api/news/{id}/comments")]
    public ActionResult<CommentsDto> GetCommentsForNews(Guid newsId)
    {
        // TODO
        throw new NotImplementedException();
    }
}
