using LanguageExt.Common;
using System;

namespace StackOverflow.Domain.Schema.Questions.AddQuestionOp
{
     
    public class QuestionTags
    {
        private string Value { get; }

        private QuestionTags( string value )
        {
            Value = value;
        }

        static int WordCount( string word )
        {
            int lubChar, countTags;
            lubChar = 0;
            countTags = 1;
            while (lubChar <= word.Length - 1)
            {
                if (word[lubChar] == ' ' || word[lubChar] == '\n' || word[lubChar] == '\t')
                {
                    countTags++;
                }
                else
                {
                    lubChar++;
                }
            }
            return countTags;
        }

        public static Result<QuestionTags> Create(string value)
        {
            int countTags;
            countTags = WordCount(value);

            if (countTags >= 1 && countTags <= 3)
            {
                return new QuestionTags(value);
            }
            else
            {
                return new Result<QuestionTags>(new ArgumentException());
            }
        }
    }
}