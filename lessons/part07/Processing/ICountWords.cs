using System.Collections.Generic;

namespace QuizCreator.Part7
{
    public interface ICountWords
    {
        Dictionary<string, int> CountWords(string text);
    }
}