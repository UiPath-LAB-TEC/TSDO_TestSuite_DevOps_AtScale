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
    public class Test_successful_registration : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {
           Log("Open UiBank Web app");
            Log("navigate to register new user");
            Log("type into username 'username'");
            Log("type into email 'username@lastname.com'");
             Log("click on 'register'");
             Log("verify registation message");
            testing.VerifyExpressionWithOperator("successfully registered",Comparison.Equality, "registation failed",null,true,null,true,true);

            
        }
    }
}