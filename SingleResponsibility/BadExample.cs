// /*
//     SingleResponsibility - Dåligt Exempel

//     Ett program där man kan skapa en användare, spara den i en "databas", och skicka ett välkomstmail.

//     Detta är ett exempel på dålig kod, eftersom klassen User har flera ansvarsområden.
//     Den har ansvar för att spara användardata till en databas, och den har ansvar för att skicka ett välkomstmail.
//     Klassen User bör endast ha ansvar för att hålla användardata.
//  */

// using System;
// class User
// {
//     private string name;
//     private string email;

//     public User(string name, string email)
//     {
//         this.name = name;
//         this.email = email;
//     }

//     public void SaveUserData()
//     {
//         // Code to save user data to a database
//         Console.WriteLine("User data saved to the database.");
//     }

//     public void SendEmail()
//     {
//         // Code to send a welcome email to the user
//         Console.WriteLine("Welcome email sent.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         User user = new User("john_doe", "john@example.com");
//         user.SaveUserData();
//         user.SendEmail();
//     }
// }
