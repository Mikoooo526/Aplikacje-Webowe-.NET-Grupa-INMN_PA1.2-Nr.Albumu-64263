namespace AppRestaurantMM.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public Contact(string firstName, string lastName, string email, string message)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Message = message;
        }

        public Contact() {
        }
    }
}
