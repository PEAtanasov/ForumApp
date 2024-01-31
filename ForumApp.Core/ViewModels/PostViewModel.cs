namespace ForumApp.Core.ViewModels;

using System.ComponentModel.DataAnnotations;
using static ForumApp.Common.Validations.EntityValidations.PostConstants;

public class PostViewModel
{
    /// <summary>
    /// PostViewModel Identifier
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Title
    /// </summary>
    [Required(ErrorMessage = Required)]
    [StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = TitleErrorMessage)]
    [Display(Name = "Post title")]
    public string Title { get; set; } = null!;
    /// <summary>
    /// Content
    /// </summary>
    [Required(ErrorMessage = Required)]
    [StringLength(ContentMaxLength, MinimumLength = ContentMinLength, ErrorMessage = ContentErrorMessage)]
    [Display(Name = "Post content")]
    public string Content { get; set; } = null!;
}
