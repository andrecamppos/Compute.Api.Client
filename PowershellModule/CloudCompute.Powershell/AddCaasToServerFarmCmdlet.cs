﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.Client;
using DD.CBU.Compute.Api.Client.VIP;
using DD.CBU.Compute.Api.Contracts.General;
using DD.CBU.Compute.Api.Contracts.Network;
using DD.CBU.Compute.Api.Contracts.Vip;

namespace DD.CBU.Compute.Powershell
{
     [Cmdlet(VerbsCommon.Add, "CaasToServerFarm")]
    public class AddCaasToServerFarmCmdlet:PsCmdletCaasBase
    {
        /// <summary>
        /// The network to manage the VIP settings
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The network to manage the VIP settings", ValueFromPipelineByPropertyName = true)]
        public NetworkWithLocationsNetwork Network { get; set; }

        /// <summary>
        /// The server farm that will get added a probe or real server
        /// </summary>
        [Parameter(Mandatory = true, HelpMessage = "The server farm that will get added a probe or real server", ValueFromPipeline = true)]
        public ServerFarm ServerFarm { get; set; }

        /// <summary>
        /// The real server to be added to the server farm
        /// </summary>
        [Parameter(Mandatory = true,ParameterSetName = "RealServer" ,HelpMessage = "The real server to be added to the server farm")]
        public RealServer RealServer { get; set; }


        /// <summary>
        /// The real server port to be added to the server farm
        /// </summary>
        [Parameter(Mandatory = false, ParameterSetName = "RealServer",HelpMessage = "The real server port to be added to the server farm")]
        [ValidateRange(1, 65535)]
        public int RealServerPort { get; set; }

        /// <summary>
        /// The probe to be added to the server farm
        /// </summary>
        [Parameter(Mandatory = true, ParameterSetName = "Probe", HelpMessage = "The probe to be added to the server farm")]
        public Probe Probe { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                Status status = null;
                if(ParameterSetName.Equals("RealServer"))
                    status = CaaS.ApiClient.AddRealServerToServerFarm(Network.id,ServerFarm.id, RealServer.id, RealServerPort).Result;
                else
                    status = CaaS.ApiClient.AddProbeToServerFarm(Network.id, ServerFarm.id,Probe.id).Result;


                if (status != null)
                    WriteDebug(
                        string.Format(
                            "{0} resulted in {1} ({2}): {3}",
                            status.operation,
                            status.result,
                            status.resultCode,
                            status.resultDetail));




            }
            catch (AggregateException ae)
            {
                ae.Handle(
                    e =>
                    {
                        if (e is ComputeApiException)
                        {
                            WriteError(new ErrorRecord(e, "-2", ErrorCategory.InvalidOperation, CaaS));
                        }
                        else //if (e is HttpRequestException)
                        {
                            ThrowTerminatingError(new ErrorRecord(e, "-1", ErrorCategory.ConnectionError, CaaS));
                        }
                        return true;
                    });
            }


        }

    }
}