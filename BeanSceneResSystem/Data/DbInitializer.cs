using BeanSceneResSystem.Models;

namespace BeanSceneResSystem.Data
{
    public class DbInitializer
    {
        /// <summary>
        /// When called with the BeanSceneResSystemContext, checks to see if the database 
        /// contains any data in the User table. If there is none, it creates users, reservations 
        /// and a registered user login account with username "johns" and password "hello_js#7". 
        /// WARNING: when moving to production, REMOVE any calls to this function, as they represent 
        /// a security risk.
        /// </summary>
        /// <param name="context">The database context to use. Must be the current project to work.</param>
        public static void Initialize(BeanSceneResSystemContext context)
        {
            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User {FirstName = "John", LastName = "Smith", Email = "john.smith@gmail.com", PhoneNo = "0404604444", Type = "Me"},
                new User {FirstName = "Jack", LastName = "Smith", Email = "jack.smith@gmail.com", PhoneNo = "0404605555", Type = "Me"}
            };

            context.Users.AddRange(users);
            context.SaveChanges();

            var reservations = new Reservation[]
            {
                new Reservation { UserID = 1, Area = 'O', Date = DateTime.Today, Start = DateTime.Now, Duration = 60, NumOfGuests = 1, Source = "in-person", Sitting = 'B', TableNo = 1, Notes = "Under cover if possible" },
                new Reservation { UserID = 1, Area = 'O', Date = DateTime.Today, Start = DateTime.Now, Duration = 60, NumOfGuests = 1, Source = "email", Sitting = 'L', TableNo = 1, Notes = "Under cover if possible" },
                new Reservation { UserID = 1, Area = 'M', Date = DateTime.Today, Start = DateTime.Now, Duration = 60, NumOfGuests = 1, Source = "email", Sitting = 'D', TableNo = 1, Notes = "Away from other guest" }
            };

            context.Reservations.AddRange(reservations);
            context.SaveChanges();

            var registeredUsers = new RegisteredUser[]
            {
                new RegisteredUser { UserName = "johns", Password = "hello_js#7"}
            };

            context.RegisteredUsers.AddRange(registeredUsers);
            context.SaveChanges();
        }
    }
}
