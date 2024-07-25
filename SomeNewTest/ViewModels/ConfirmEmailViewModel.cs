using System.ComponentModel.DataAnnotations;
namespace SomeNewTest.ViewModels
{
    public class ConfirmEmailViewModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string ConfirmationCode { get; set; }

        public ConfirmEmailStatus Status { get; set; }

        public string Email { get; set; }

        public bool IsSuccess { get; set; }
    }

    public enum ConfirmEmailStatus
    {
        ConfirmationSuccess,
        ConfirmationError
    }
}