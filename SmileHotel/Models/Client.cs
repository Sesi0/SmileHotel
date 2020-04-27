using System.Text.RegularExpressions;

namespace SmileHotel.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PersonalDocNumber { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(this.Name) ||
                string.IsNullOrEmpty(this.PersonalDocNumber) ||
                string.IsNullOrEmpty(this.PhoneNumber) ||
                !Regex.IsMatch(this.PhoneNumber, @"(^\+|0{1})\d{8,9}$"))
            {
                return false;
            }

            return true;
        }
    }
}
