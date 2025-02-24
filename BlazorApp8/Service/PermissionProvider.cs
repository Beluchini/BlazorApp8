using BlazorApp8.Enums;
using BlazorApp8.Models;

namespace BlazorApp8.Service;

public class PermissionProvider
{
    public bool IsCanView(User user)
    {
        if (user.Role == Roles.Admin)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}