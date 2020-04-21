namespace SmileHotel.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(this.Name) ||
                string.IsNullOrEmpty(this.PhoneNumber))
            {
                return false;
            }

            return true;
        }
    }
}
