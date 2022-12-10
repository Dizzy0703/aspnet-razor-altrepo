using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeanSceneReservationSystem.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public char Reservation_Sitting { get; set; }
        [DataType(DataType.Date)]
        public DateTime Reservation_Date { get; set; }
        [DataType(DataType.Time)]
        public DateTime Reservation_Start { get; set; }
        public int Reservation_Duration { get; set; }
        public int Reservation_NumOfGuests { get; set; }
        public char Reservation_Area { get; set; }
        public int Reservation_TableNo { get; set; }
        public string Reservation_Source { get; set; }
        public string Reservation_Notes { get; set; }
        public string Reservation_Status { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
