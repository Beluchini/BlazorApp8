using BlazorApp8.Enums;

namespace BlazorApp8.Models;

public class Credentials
{
    public string Login { get; set; }
    public string Password { get; set; }
    public Roles Role { get; set; }
}