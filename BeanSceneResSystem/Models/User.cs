namespace BeanSceneResSystem.Models
{
    /// <summary>
    /// Represents a Member/Guest, which is linked to the Reservation object 
    /// if there are any reservations with the correct UserID.
    /// </summary>
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public string PhoneNo { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
