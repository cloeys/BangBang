using BangBangDomain.Roles.Enum;
using BangBangDomain.Roles.Interface;

namespace BangBangDomain.Roles
{
    public class BanditRole : IRole
    {
        public RoleNameEnum RoleName { get; } = RoleNameEnum.Bandit;
        public bool HasWon()
        {
            throw new System.NotImplementedException();
        }
    }
}