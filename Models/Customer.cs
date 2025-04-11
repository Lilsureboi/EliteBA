using System.Text.RegularExpressions;

namespace Models;

public class Customer
{
    private string _email;
    private string _phoneNumber;
    
    public required string FirstName { get; set; }
    public required string LastName { get; set; }

    public required string Email
    {
        get => _email;
        set
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                Console.WriteLine("Invalid email format.Please try again.");
                return;
            }

            _email = value;
        }
    }

    public required string PhoneNumber
    {
        get => _phoneNumber;
        set
        {
            if (!Regex.IsMatch(value, @"^0(70[1-9]|80[2-9]|81[0-9]|90[1-9])[0-9]{7}$"))
            {
                Console.WriteLine("Invalid phone number format.Please use acceptable Nigerian format.");
            }
        }
    }
    
    public string? Address { get; set; }
    
    public int AccountId { get; set; }
}