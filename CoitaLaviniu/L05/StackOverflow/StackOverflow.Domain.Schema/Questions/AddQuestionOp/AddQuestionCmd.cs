using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StackOverflow.Domain.Schema.Questions.AddQuestionOp
{
    public class AddQuestionCmd
    {
        public AddQuestionCmd( string title, QuestionLength body, QuestionTags tags)
        {
            Title = title;
            Body = body;
            Tags = tags;
        }

        [Required]
        public string Title { get; }
        [Required]
        [MaxLength(1000)]
        public QuestionLength Body { get; }
        [Required]
        [MinLength(1)]
        [MaxLength(3)]
        public QuestionTags Tags { get; }
    }
}
