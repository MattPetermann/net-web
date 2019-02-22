namespace Colors.Models
{
    public class Yellow : PrimaryColor
    {
        public Yellow()
        {
            Name = "YELLOW";
            Hex = "#f1c40f";
        }

        public override IColor Add(IColor addition)
        {
            switch (addition.Name)
            {
                case "RED": return new Orange();
                case "BLUE": return new Green();
                case "YELLOW": return new Yellow();
            }

            return null;
        }
    }
}