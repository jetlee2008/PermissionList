using PermissionInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionImplement
{
    public class APermission : IPermissionProvider, IPriorityProvider
    {
        private IEnumerable<string> _permissionList;

        public IEnumerable<string> GetPermissionList()
        {
            if (_permissionList == null)
            {
                return new List<string> { "401", "402" };
            }
            return _permissionList;
        }

        public int GetPermissionPriority()
        {
            return 1;
        }

        public APermission(IEnumerable<string> permissionList)
        {
            this._permissionList = permissionList;
        }
    }
}
