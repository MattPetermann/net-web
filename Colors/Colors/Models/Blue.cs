namespace Colors.Models
{
    public class Blue : PrimaryColor
    {
        public Blue()
        {
            Name = "BLUE";
            Hex = "#3498db";
        }

        public override IColor Add(IColor addition)
        {
            switch (addition.Name)
            {
                case "RED": return new Purple();
                case "BLUE": return new Blue();
                case "YELLOW": return new Green();
            }

            return null;
        }
    }
}