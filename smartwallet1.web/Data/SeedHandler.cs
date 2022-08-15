using smartwallet1.web.Data.Entities;

namespace smartwallet1.web.Data
{
    public class    SeedHandler
    {
        public static async Task Seed(ApplicationDbContext context)
        {
            //Check if the database is populated
            if (!context.Customers.Any())
            {
                //Create Sample Data
                context.Customers.Add(new Customer
                {
                    FirstName = "Aleakhue",
                    LastName = "Solomon",
                    MiddleName  = "Imokhai",
                    Country = "Nigeria",
                    State  = "Lagos",
                    City = "Surulere",
                    BirthDate = DateTime.Now.AddYears(-2),
                    Gender = Gender.Male,
                    Status = MaritalStatus.single,
                   
                });

                
                await context.SaveChangesAsync();
            }

           

            
        }
    }
}

