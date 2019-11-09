using System.Collections.Generic;


namespace CSharp_Arduino_CLI.Domain
{
    public class BoardDetail
    {
        public List<BoardOption> Options { get; set; } = new List<BoardOption>();
    }

    public class BoardOption
    {
        public string Option { get; set; }
        public string Option_Label { get; set; }
        public List<BoardOptionValue> Values { get; set; } = new List<BoardOptionValue>();
    }


    public class BoardOptionValue
    {
        public string Value { get; set; }
        public string Value_Label { get; set; }
        public bool Selected { get; set; }
    }
}
