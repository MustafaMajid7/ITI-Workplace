
namespace Day5
{
    internal class Answer
    {
        public int id { get; set; }
        public string answer { get; set; }

        public Answer(int id , string answer )
        {
            this.id = id ;
            this.answer = answer ;
        }

        public override string ToString()
        {
            return $"{id}- {answer} ";
        }

    }
}
