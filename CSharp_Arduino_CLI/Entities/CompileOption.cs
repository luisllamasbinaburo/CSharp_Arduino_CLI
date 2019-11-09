namespace CSharp_Arduino_CLI.Entities
{
    public class CompileOption
    {
        public string Option { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{Option}={Value}";
        }
    }
}
