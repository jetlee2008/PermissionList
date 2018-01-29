using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionInfrastructure
{
    public interface IPermissionAspect : IPriorityProvider, IPermissionProvider, IComparable<IPriorityProvider>
    {
        bool ContainPermission(string right);
    }
}
