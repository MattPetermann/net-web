namespace Colors.Models
{
    public abstract class PrimaryColor : IColor
    {
        public string Name { get; set; }
        public string Hex { get; set; }

        public abstract IColor Add(IColor addition);
    }
}