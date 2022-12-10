using System.ComponentModel.DataAnnotations;

namespace BeanSceneReservationSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string User_FirstName { get; set; }
        public string User_LastName { get; set; }
        public string User_Email { get; set; }
        public string User_PhoneNo { get; set; }
        public string User_Type { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
