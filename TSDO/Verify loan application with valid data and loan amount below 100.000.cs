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
    public class Verify_loan_application_with_valid_data_and_loan_amount_below_100_000 : CodedWorkflow
    {
        [TestCase]
        public void Execute()
        {
            Log("Test run started for Verify_loan_application_with_valid_data_and_loan_amount_below_100_000.");

            
        }
    }
}