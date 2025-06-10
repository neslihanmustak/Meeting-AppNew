using System.ComponentModel.DataAnnotations;

namespace MeetingAppNew.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunlu")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon alanı zorunlu")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Mail alanı zorunlu")]
        [EmailAddress(ErrorMessage = "Mail formatı yanlış")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım alanı zorunlu")]
        public bool? WillAttend { get; set; }


    }
}
