using BlazorApp8.Enums;
using BlazorApp8.Models;

namespace BlazorApp8.Service;

public class PermissionProvider
{
    public bool IsCanView(Roles _role)
    {
        if (_role == Roles.Admin)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}