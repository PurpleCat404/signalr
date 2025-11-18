using System;
using System.Linq;
using BadNews.Models.Comments;
using BadNews.Repositories.Comments;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class CommentsController : ControllerBase
{
    private readonly ICommentsRepository commentsRepository;

    public CommentsController(ICommentsRepository commentsRepository, IMapper mapper)
    {
        this.commentsRepository = commentsRepository;
    }

    // GET
    [HttpGet("api/news/{id}/comments")]
    public ActionResult<CommentsDto> GetCommentsForNews(Guid newsId)
    {
        var result = commentsRepository.GetComments(newsId)
            .Select(x => new CommentDto
            {
                User = x.User,
                Value = x.Value,
            }
            );
        return new ActionResult<CommentsDto>(new CommentsDto
        {
            Comments = result.ToList(),
            NewsId = newsId
        });
    }
}
