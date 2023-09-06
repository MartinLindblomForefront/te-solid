using System;

/*
    SingleResponsibility - Bra Exempel

    I detta exempel har vi samma funktionalitet som i det dåliga exemplet.
    Detta är ett proram där man kan skapa en användare, spara den till en "databas" och skicka ett välkomstmail.

    Detta är ett exempel på bra kod, eftersom vi har separerat de olika ansvarsområdena i olika klasser.

    Klassen User har ansvar för att hålla användardata.
    Klassen UserRepository har ansvar för att spara användardata till en databas.
    Klassen EmailService har ansvar för att skicka ett välkomstmail till användaren.

    Detta gör att vi kan ändra på hur vi sparar användardata, eller hur vi skickar välkomstmailet, utan att behöva ändra på koden i klassen User.

    Notera att koden i detta exempel är lite längre än i det dåliga exemplet. 
    Kortare kod är inte alltid bättre kod. Tydlighet, läsbarhet och underhållbarhet är viktigare.
*/


class User
{
    private string name;
    private string email;

    public User(string name, string email)
    {
        this.name = name;
        this.email = email;
    }
}

class UserRepository
{
    public void SaveUser(User user)
    {
        // Code to save user data to a database
        Console.WriteLine("User data saved to the database.");
    }
}

class EmailService
{
    public void SendWelcomeEmail(User user)
    {
        // Code to send a welcome email to the user
        Console.WriteLine("Welcome email sent.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        User user = new User("john_doe", "john@example.com");

        UserRepository userRepository = new UserRepository();
        userRepository.SaveUser(user);

        EmailService emailService = new EmailService();
        emailService.SendWelcomeEmail(user);
    }
}


