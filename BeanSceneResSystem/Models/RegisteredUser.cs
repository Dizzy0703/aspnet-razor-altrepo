using System.ComponentModel.DataAnnotations;

namespace BeanSceneResSystem.Models
{
    public class RegisteredUser
    {
        [Key]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
