using System.ComponentModel.DataAnnotations;

namespace GMSFramework.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}