using BangBangDomain.Roles.Enum;
using BangBangDomain.Roles.Interface;

namespace BangBangDomain.Roles
{
    public class DeputyRole : IRole
    {
        public RoleNameEnum RoleName { get; } = RoleNameEnum.Deputy;
        public bool HasWon()
        {
            throw new System.NotImplementedException();
        }
    }
}