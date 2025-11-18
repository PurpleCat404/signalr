using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BadNews.Models.Comments;
using BadNews.Repositories.Comments;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class CommentsController : ControllerBase
{
    private readonly ICommentsRepository commentsRepository;
    private readonly IMapper mapper;

    public CommentsController(ICommentsRepository commentsRepository, IMapper mapper)
    {
        this.commentsRepository = commentsRepository;
        this.mapper = mapper;
    }

    // GET
    [HttpGet("api/news/{id}/comments")]
    public ActionResult<CommentsDto> GetCommentsForNews(Guid newsId)
    {
        var comments = commentsRepository.GetComments(newsId);
        var dtoComments = mapper.Map<IReadOnlyCollection<CommentDto>>(comments);
        var dto = new CommentsDto() { NewsId = newsId, Comments = dtoComments };
        return dto;
    }
}
