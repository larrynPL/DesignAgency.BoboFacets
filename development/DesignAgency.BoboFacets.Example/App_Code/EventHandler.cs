using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Logging;

namespace DesignAgency.BoboFacets.Example.App_Code
{
/*    public class VerifyCe : ApplicationEventHandler
    {
        protected override bool ExecuteWhenApplicationNotConfigured
        {
            get { return true; }
        }

        protected override bool ExecuteWhenDatabaseNotConfigured
        {
            get { return true; }
        }

        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            LogHelper.Info<VerifyCe>("Verifying SqlCE!");

            const string cstr = @"Data Source=|DataDirectory|\Umbraco.sdf;Flush Interval=1;";

            var engine = new SqlCeEngine(cstr);
            try
            {
                var verified = engine.Verify(VerifyOption.Enhanced);
                LogHelper.Info<VerifyCe>("VERIFIED: " + verified);

                if (!verified)
                {
                    LogHelper.Info<VerifyCe>("REPAIRING");
                    engine.Repair(cstr, RepairOption.RecoverAllOrFail);
                    engine.Compact(cstr);

                    verified = engine.Verify(VerifyOption.Enhanced);
                    LogHelper.Info<VerifyCe>("VERIFIED: " + verified);
                }
            }
            finally
            {
                engine.Dispose();
            }
        }
    }*/
}