

namespace Entity
{
    public class User
    {
  
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
   
    }
        
    public class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        //public User User { get; set; } 
    }

    public class UserPayment
    {
        public static void Main(string[] args)
        {
            List<User> user = new List<User>()
            {
                new User()
                {
                    Id = 11,
                    FirstName = "Gabriel",
                    LastName = "paul",
                    Email = "gabrielp@gmail.com"
                },

                new User()
                {
                    Id = 12,
                    FirstName = "Jide",
                    LastName = "Shams",
                    Email = "drshams@gmail.com"
                },

                new User()
                {
                    Id = 13,
                    FirstName = "Victor",
                    LastName = "Emetole",
                    Email = "victoremetole@gmail.com"
                },
                new User()
                {
                    Id = 14,
                    FirstName = "Esther",
                    LastName = "Emetole",
                    Email = "estheremetole@gmail.com"
                },
                new User()
                {
                    Id = 15,
                    FirstName = "Gideon",
                    LastName = "Amope",
                    Email = "amopegiddy@gmail.com"
                }
            };
            List<Payment> payment = new List<Payment>()
             {
              new Payment(){Id = 11, UserId = 1011, Amount = 1500},
              new Payment(){Id = 12, UserId = 1012, Amount = 11500},
              new Payment(){Id = 13, UserId = 1013, Amount = 18050},
              new Payment(){Id = 14, UserId = 1014, Amount = 95000},
              new Payment(){Id = 15, UserId = 1015, Amount = 2000}
            };

            foreach (var person in user)
            {
                Console.WriteLine(" ID: " + person.Id + "\n Name: " + person.FirstName + "\n Surname: " + person.LastName + "\n Email " + person.Email);
                foreach (var paid in payment)
                {
                    if (paid.Id == person.Id)
                    {
                        Console.WriteLine(" UserID " + paid.UserId + "\n Amount Paid " + paid.Amount);
                        Console.WriteLine(); 
                    }
                }
            }
        }
    }
}


 
