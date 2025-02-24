using BlazorApp8.Enums;
namespace BlazorApp8.Models;

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public Roles Role { get; set; }

    public User(string name, string surname, string patronymic, Roles role)
    {
        Name = name;
        Surname = surname;
        Patronymic = patronymic;
        Role = role;
    }
    public User(Roles role) : this("None", "None", "None", role)
    {
        Role = role;
    }

    public User(Credentials credentials) : this("None", "None", "None", credentials.Role)
    {
        
    }
}