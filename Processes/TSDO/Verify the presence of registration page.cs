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
    public class Verify_the_presence_of_registration_page : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {
            Log("Open UiBank Web app");
            Log("Click on 'register new user'");
            Log("type in username: 'john@doe.com");
            Log("type in password: 'Test123");
             Log("Set policy term to 10 years");
            Log("click on 'register'");
             Log("verify that registration fails due to missing special character in password");
            testing.VerifyExpression("Please include a special character in your password" == "Please include a special character in your password" );

            
        }
    }
}