using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace TSDO
{
    public class Test_transfer_execution : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {
           Log("Open UiBank Web app");
            Log("navigate to 'Transfers'");
            Log("click on 'transfer money");
            Log("type '1000' into 'transfer sum'");
            Log("type 'Jane Doe' into 'recipent'");
             Log("Click on 'transfer'");
             Log("verify successful transfer");
            testing.VerifyExpression("1000 $ have successfully been transfered from your account to Jane Doe" == "1000 $ have successfully been transfered from your account to Jane Doe" );

            
        }
    }
}