using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproveLeave
{
    public class ProjectLead : Approver
    {
        public override void ApproveLeave(int numberOfLeaves)
        {
            if (CanApprove(numberOfLeaves))
            {
                Util.PrintLeaveMessage(this.GetType().Name, numberOfLeaves);
            }
            else
            {
                Util.SetNextApproverElsePrint(this, numberOfLeaves);
            }
        }


        protected override bool CanApprove(int numberOfLeaves)
        {
            if (numberOfLeaves > 3 && numberOfLeaves <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
