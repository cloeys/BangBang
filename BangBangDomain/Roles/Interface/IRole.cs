using BangBangDomain.Roles.Enum;

namespace BangBangDomain.Roles.Interface
{
    public interface IRole
    {
        RoleNameEnum RoleName { get; }
        bool HasWon();
    }
}