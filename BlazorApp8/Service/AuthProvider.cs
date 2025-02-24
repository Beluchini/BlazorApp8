using BlazorApp8.Enums;
using BlazorApp8.Models;
namespace BlazorApp8.Service;


public class AuthProvider
{
    public User currentUser { get; private set; }

    public void Login(Credentials credentials)
    {
        if(string.IsNullOrEmpty(credentials.Login) || string.IsNullOrEmpty(credentials.Password))return;
        User newUeer = new User(credentials);
        currentUser = newUeer;
    }

    public void Logout()
    {
        currentUser = null;
    }
}