﻿using Microsoft.WindowsAzure.ServiceRuntime;
using Orleans.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication
{
    public class WebRole : RoleEntryPoint
    {
        Orleans.Host.OrleansAzureSilo silo;
        public override bool OnStart()
        {
            // Do other silo initialization – for example: Azure diagnostics, etc 

            silo = new OrleansAzureSilo();
            return silo.Start(RoleEnvironment.DeploymentId, RoleEnvironment.CurrentRoleInstance);
        }
        public override void OnStop()
        {
            silo.Stop();
        }

        public override void Run()
        {
            silo.Run();
        }
    }
}