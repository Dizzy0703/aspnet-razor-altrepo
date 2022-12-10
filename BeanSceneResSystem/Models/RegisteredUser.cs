using System.ComponentModel.DataAnnotations;

namespace BeanSceneResSystem.Models
{
    /// <summary>
    /// Represents a login-able user (Bean Scene staff).
    /// </summary>
    public class RegisteredUser
    {
        [Key]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
