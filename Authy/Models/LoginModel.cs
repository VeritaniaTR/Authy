using System.ComponentModel.DataAnnotations;

namespace Authy.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Ім'я є обов'язковим.")]
        [RegularExpression(@"^[А-ЯA-Z][а-яa-zА-Яа-яіІїЇєЄґҐa-zA-Z]+$", ErrorMessage = "Має починатися з великої літери і містити лише букви.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Прізвище є обов'язковим.")]
        [RegularExpression(@"^[А-ЯA-Z][а-яa-zА-Яа-яіІїЇєЄґҐa-zA-Z]+$", ErrorMessage = "Має починатися з великої літери і містити лише букви.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Електронна пошта є обов'язковою.")]
        [EmailAddress(ErrorMessage = "Невірний формат e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пароль є обов'язковим.")]
        [MinLength(8, ErrorMessage = "Пароль має бути не менше 8 символів.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*]).+$",
            ErrorMessage = "Пароль має містити велику літеру, маленьку літеру, цифру та спеціальний символ.")]
        public string Password { get; set; }
    }
}
