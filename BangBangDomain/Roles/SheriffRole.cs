using BangBangDomain.Roles.Enum;
using BangBangDomain.Roles.Interface;

namespace BangBangDomain.Roles
{
    public class SheriffRole : IRole
    {
        public RoleNameEnum RoleName { get; } = RoleNameEnum.Sheriff;
        public bool HasWon()
        {
            throw new System.NotImplementedException();
        }
    }
}