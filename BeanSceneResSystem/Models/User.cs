namespace BeanSceneResSystem.Models
{
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
