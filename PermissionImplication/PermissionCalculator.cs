using PermissionInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PermissionImplement
{
    public class PermissionCalculator : IPermissionCalculator
    {
        public string PermissionCriteria { get; set; }

        private IEnumerable<IPermissionAspect> _aspects;

        public bool ValidatePermission()
        {
            var sortedAspects = _aspects.ToList();
            sortedAspects.Sort();
            foreach (var item in sortedAspects)
            {
                if (item.ContainPermission(PermissionCriteria))
                {
                    return true;
                }
            }
            return false;
        }

        public void SetPermissionAspects(IEnumerable<IPermissionAspect> aspects)
        {
            _aspects = aspects;
        }

        public PermissionCalculator(string right)
        {
            PermissionCriteria = right;
        }
    }

}
