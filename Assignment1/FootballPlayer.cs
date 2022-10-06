namespace Assignment1
{
    public class FootballPlayer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }


        public void ValidateName()
        {
            if (Name.Length < 2)
            {
                throw new ArgumentOutOfRangeException("Name is too short");
            }
        }

        public void ValidateAge()
        {
            if (Age < 1)
            {
                throw new ArgumentException("Player can't be that young");
            }
        }

        public void ValidateShirtNumber()
        {
            if(ShirtNumber < 1)
            {
                throw new ArgumentException("Shirt number must be between 1 and 99");
            }
            if (ShirtNumber > 99)
            {
                throw new ArgumentException("Shirt number must be between 1 and 99");
            }
        }

        public void Validate()
        {
            ValidateName();
            ValidateAge();
            ValidateShirtNumber();
        }

    }
}