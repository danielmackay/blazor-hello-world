using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace BlazorHelloWorld.Models
{
    public class BlogPost
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(16)]
        public string Slug { get; set; }

        [Required]
        public string Content { get; set; }
    }

    public class BlogPostValidator : AbstractValidator<BlogPost>
    {
        public BlogPostValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Slug).NotEmpty().Length(3,16);
            RuleFor(x => x.Content).NotEmpty();
        }
    }
}
