using BangBangDomain.Roles.Enum;
using BangBangDomain.Roles.Interface;

namespace BangBangDomain.Roles
{
    public class RenegadeRole : IRole
    {
        public RoleNameEnum RoleName { get; } = RoleNameEnum.Renegade;
        public bool HasWon()
        {
            throw new System.NotImplementedException();
        }
    }
}