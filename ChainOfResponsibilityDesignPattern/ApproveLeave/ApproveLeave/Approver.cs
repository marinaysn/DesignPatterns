using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproveLeave
{
    public abstract class Approver
    {

        public Approver NextApprover { get; set; }
        public abstract void ApproveLeave(int numberOfLeaves);
        public void SetNextApprover(Approver nextApprover)
        {
            this.NextApprover = nextApprover;
        }
        protected abstract bool CanApprove(int numberOfLeaves);

    }
}
