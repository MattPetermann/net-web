namespace Colors.Models
{
    public class Red : PrimaryColor
    {
        public Red()
        {
            Name = "RED";
            Hex = "#e74c3c";
        }

        public override IColor Add(IColor addition)
        {
            switch (addition.Name)
            {
                case "RED": return new Red();
                case "BLUE": return new Purple();
                case "YELLOW": return new Orange();
            }

            return null;
        }
    }
}