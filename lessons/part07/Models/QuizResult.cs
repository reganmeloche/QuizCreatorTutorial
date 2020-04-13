using System.Collections.Generic;

namespace QuizCreator.Part7
{
    public class QuizResult
    {
        public string QuizText;
        public List<string> AnswerKey;
        
        public QuizResult() {
            AnswerKey = new List<string>();
        }
    }
}