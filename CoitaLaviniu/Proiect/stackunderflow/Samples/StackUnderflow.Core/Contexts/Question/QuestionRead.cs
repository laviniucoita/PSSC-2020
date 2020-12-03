using System.Collections.Generic;
using StackUnderflow.EF.Models;

namespace StackUnderflow.Domain.Core.Contexts.Question
{
    class QuestionRead
    {
        public IEnumerable<Post> questions_ { get; }

        public QuestionRead(IEnumerable<Post> questions)
        {
            questions_ = questions;
        }
    }
}
