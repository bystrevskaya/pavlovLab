namespace lab1.Models

{
    public class Flat
    {
        public string Address { get; set; }
        public int Area { get; set; }
        public int NumberOfRooms { get; set; }
        public int Floor { get; set; }
        public BaseModelValidationResult Validate()
        {
            var validationResult = new BaseModelValidationResult();
            if (string.IsNullOrWhiteSpace(Address)) validationResult.Append($"Address can't be empty");
            if (Area < 10) validationResult.Append($"Area can't be less than 10 sq.m.");
            if (NumberOfRooms == 0) validationResult.Append($"Number of rooms can't be 0");

            return validationResult;
        }
        public override string ToString()
        {
            return $"Flat at the address {Address}, {Area} sq.m., {NumberOfRooms} rooms, {Floor} floor";
        }
    }
}