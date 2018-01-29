using System;
using System.Collections.Generic;

namespace PermissionInfrastructure
{
    public interface IPermissionCalculator
    {
        bool ValidatePermission();

        string PermissionCriteria { get; set; }

        void SetPermissionAspects(IEnumerable<IPermissionAspect> aspects);
    }
}
