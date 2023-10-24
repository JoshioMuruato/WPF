namespace Prueba
{
    internal class classappiresult
    {
        public bool success { get; set; }
        public string terms { get; set; }
        public string privacy { get; set; }
        public int timestamp { get; set; }
        public string source { get; set; }
        public subclassappiresult quotes { get; set; }

    }

        internal class subclassappiresult
        {
        public double USDMXN { get; set; }
    }


}