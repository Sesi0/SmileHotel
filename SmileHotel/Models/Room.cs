namespace SmileHotel.Models
{
    public class Room
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public int Capacity { get; set; }

        public float PricePerNight { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(this.Number) ||
                this.Capacity <= 0 ||
                this.PricePerNight <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
