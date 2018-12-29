namespace HelloSecrets
{
    public class MySecrets
    {
        public string Codeword { get; set; }

        public NestedSecrets NestedSecrets { get; set; }
    }

    public class NestedSecrets
    {
        public string OtherCode { get; set; }
    }
}