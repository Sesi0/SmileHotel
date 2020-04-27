namespace SmileHotel.Models
{
    public class Room
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public int Capacity { get; set; }

        public float PricePerNight { get; set; }

        public bool IsValid()
        {
            if (this.Number <= 0 ||
                this.Capacity <= 0 ||
                this.PricePerNight <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
