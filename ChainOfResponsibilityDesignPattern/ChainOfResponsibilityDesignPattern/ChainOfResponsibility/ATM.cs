﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ATM
    {
        private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();
        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        private HundredHandler hundredHandler = new HundredHandler();

        public ATM()
        {
            // Prepare the chain of Handlers
            twoThousandHandler.nextHandler(fiveHundredHandler);
            fiveHundredHandler.nextHandler(twoHundredHandler);
            twoHundredHandler.nextHandler(hundredHandler);
        }
        public void withdraw(long requestedAmount)
        {
            twoThousandHandler.dispatchRs(requestedAmount);
        }
    }
}
