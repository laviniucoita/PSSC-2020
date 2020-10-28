using LanguageExt.Common;
using System;

namespace StackOverflow.Domain.Schema.Questions.AddQuestionOp
{
    public class QuestionLength
    {
        public string Value { get; }

        private QuestionLength( string value )
        {
            Value = value;
        }

        public static Result<QuestionLength> Create( string value )
        {
            if( value.Length <= 100 )
            {
                return new QuestionLength(value);
            }
            else
            {
                return new Result<QuestionLength>(new ArgumentException());
            }
        }
    }
}