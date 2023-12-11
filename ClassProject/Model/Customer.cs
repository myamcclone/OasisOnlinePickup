using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Model
{
    public class Customer
    {
public string Username { get; set; }
 // declaring username variable and calling getter and setter to be invoked in main method
 public string Password { get; set; }
 // declaring password variable and calling getter and setter to be invoked in main method
 public string FirstName { get; set; }
 // declaring first name variable and calling getter and setter to be invoked in main method
 public string LastName { get; set; }
 // declaring last name variable and calling getter and setter to be invoked in main method
 public string Email { get; set; }
 // declaring email variable and calling getter and setter to be invoked in main method
 public int PhoneNumber { get; set; }
 // declaring phone number  variable and calling getter and setter to be invoked in main method

 public Customer()  // no arg constructor to create a customer object 
 {

 }
    }
}
