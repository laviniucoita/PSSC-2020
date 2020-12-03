﻿using System.Collections.Generic;
using StackUnderflow.EF.Models;

namespace StackUnderflow.Domain.Core.Contexts.Question
{
    public class QuestionWrite
    {
        public ICollection<Post> questions_ { get; }

        public QuestionWrite(ICollection<Post> questionSummary)
        {
            questions_ = questionSummary ?? new List<Post>(0);
        }
    }
}
