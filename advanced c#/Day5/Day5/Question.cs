using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Question
    {
        public int id { get; set; }
        public string header { get; set; }
        public string body { get; set; }

        public Question(int id , string header , string body)
        {
            this.id = id;
            this.header = header;
            this.body= body;
        }

        public override string ToString()
        {
            return $"{header}.{id}\n{body} ";
        }
    }
}
