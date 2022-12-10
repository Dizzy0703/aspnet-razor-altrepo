using Microsoft.EntityFrameworkCore;
using BeanSceneReservationSystem.Data;

namespace BeanSceneReservationSystem.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BeanSceneReservationSystemContext(serviceProvider.GetRequiredService<DbContextOptions<BeanSceneReservationSystemContext>>()))
        {
            if (context == null || context.User == null || context.Reservation == null)
            {
                throw new ArgumentNullException("Null BeanSceneReservationSystemContext");
            }

            // Look for any Users or Reservations - if there are any, then the database has been seeded and 
            // nothing further needs to be done.
            if (context.User.Any() || context.Reservation.Any())
            {
                return;
            }

            context.User.AddRange(
                new User
                {
                    User_FirstName = "John",
                    User_LastName = "Smith",
                    User_Email = "john.smith@gmail.com",
                    User_PhoneNo = "0404060404",
                    User_Type = "Me"
                }
            );

            context.Reservation.AddRange(
                new Reservation
                {
                    UserId = 2,
                    Reservation_Sitting = 'B',
                    Reservation_Area = 'O',
                    Reservation_Start = new DateTime(2, 1, 1, 7, 0, 0),
                    Reservation_Date = new DateTime(2022, 12, 28),
                    Reservation_Duration = 60,
                    Reservation_NumOfGuests = 1,
                    Reservation_Source = "in-person",
                    Reservation_Status = "pending",
                    Reservation_TableNo = 1,
                    Reservation_Notes = "Under cover, if possible"
                }
            );
            context.SaveChanges();
        }
    }
}
