namespace QuizCreator.Part6
{
    public class CoreWord
    {
        public string Word {get;set;}
        public string WordType {get;set;}
        public string Definition {get;set;}

        public CoreWord() {
            this.Word = "";
            this.WordType = "unknown";
            this.Definition = "Unknown";
        }

        public CoreWord(string word) : this() {
            this.Word = word;
        }
    }
}