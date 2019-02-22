namespace Colors.Helpers
{
    public class Color
    {
        public string Name { get; set; }
        public string Hex { get; set; }

        public Color(string color, string hex)
        {
            Name = color;
            Hex = hex;
        }
    }
}