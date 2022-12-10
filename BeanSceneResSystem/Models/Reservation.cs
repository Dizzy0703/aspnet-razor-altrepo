using System.ComponentModel.DataAnnotations;

namespace BeanSceneResSystem.Models
{
    /// <summary>
    /// Represents a reservation object, linked to the User object with a foreign key 
    /// relationship.
    /// </summary>
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int UserID { get; set; }
        public char Sitting { get; set; }
        public char Area { get; set; }
        [DataType(DataType.Time)]
        public DateTime Start { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int NumOfGuests { get; set; }
        public int TableNo { get; set; }
        public int Duration { get; set; }
        public string Source { get; set; }
        public string Notes { get; set; }
        public User User { get; set; }
    }
}
