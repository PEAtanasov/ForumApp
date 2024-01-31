using static ForumApp.Common.Validations.EntityValidations.PostConstants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForumApp.Data.Models;

public class Post
{
    /// <summary>
    /// Constructor for post class. Providing guid id when new entity initializing.
    /// </summary>
    public Post()
    {
        Id = Guid.NewGuid();
    }
    /// <summary>
    /// Post identifier
    /// </summary>
    [Key]
    [Comment("Post identifier")]
    public Guid Id { get; init; }
    /// <summary>
    /// Title of the post
    /// </summary>
    [Required]
    [MaxLength(TitleMaxLength)]
    [Comment("Post title")]
    public string Title { get; set; } = null!;
    /// <summary>
    /// Content of the post
    /// </summary>
    [Required]
    [MaxLength(ContentMaxLength)]
    [Comment("Post content")]
    public string Content { get; set; } = null!;
}
