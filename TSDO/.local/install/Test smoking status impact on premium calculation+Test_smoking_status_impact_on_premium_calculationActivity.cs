using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Runtime;
using System.Collections.Generic;
using System.Data;
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
    public class Test_smoking_status_impact_on_premium_calculationActivity : System.Activities.Activity
    {
        public Test_smoking_status_impact_on_premium_calculationActivity()
        {
            this.Implementation = () =>
            {
                return new Test_smoking_status_impact_on_premium_calculationActivityChild()
                {};
            };
        }
    }

    internal class Test_smoking_status_impact_on_premium_calculationActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public Test_smoking_status_impact_on_premium_calculationActivityChild()
        {
            DisplayName = "Test_smoking_status_impact_on_premium_calculation";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::TSDO.Test_smoking_status_impact_on_premium_calculation();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>()
            {UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints}), context);
            await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "Test smoking status impact on premium calculation.cs"});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                ControlledExecution.Run(() =>
                {
                    {
                        codedWorkflow.Execute();
                        newResult = new System.Collections.Generic.Dictionary<string, object>{};
                    }
                }, cancellationToken);
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "Test smoking status impact on premium calculation.cs", Exception = exception});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
            };
        }
    }
}