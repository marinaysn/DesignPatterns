using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproveLeave
{
    public class DeliveryManager : Approver
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
            if (numberOfLeaves > 10 && numberOfLeaves <= 15)
            {
                return true;
            }
            return false;
        }
    }
}
