using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionInfrastructure
{
    public interface IPermissionProvider:IList
    {
        IEnumerable<string> GetPermissionList();
    }
}
