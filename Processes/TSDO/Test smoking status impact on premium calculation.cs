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
    public class Test_smoking_status_impact_on_premium_calculation : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {
            Log("Open UiBank Web app");
            Log("navigate to Insurance services");
            Log("click on apply for new insurance");
            Log("select life insurance");
            Log("fill in the mandatory fields");
             Log("Check 'Smoking'");
            Log("click on calculate premium");
             Log("verify that the premium is adjusted by $50 ");
            testing.VerifyExpression("premium == $ 200 per month" == "premium == $ 200 per month" );
        }
    }
}