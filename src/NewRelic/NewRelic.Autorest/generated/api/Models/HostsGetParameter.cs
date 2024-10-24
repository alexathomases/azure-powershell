// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Extensions;

    /// <summary>Host Get Parameter specification.</summary>
    public partial class HostsGetParameter :
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IHostsGetParameter,
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IHostsGetParameterInternal
    {

        /// <summary>Internal Acessors for Request</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IHostsGetRequest Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IHostsGetParameterInternal.Request { get => (this._request = this._request ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.HostsGetRequest()); set { {_request = value;} } }

        /// <summary>Backing field for <see cref="Request" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IHostsGetRequest _request;

        /// <summary>The details of the Hosts get request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IHostsGetRequest Request { get => (this._request = this._request ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.HostsGetRequest()); set => this._request = value; }

        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string RequestUserEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IHostsGetRequestInternal)Request).UserEmail; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IHostsGetRequestInternal)Request).UserEmail = value ; }

        /// <summary>VM resource IDs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> RequestVMId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IHostsGetRequestInternal)Request).VMId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IHostsGetRequestInternal)Request).VMId = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="HostsGetParameter" /> instance.</summary>
        public HostsGetParameter()
        {

        }
    }
    /// Host Get Parameter specification.
    public partial interface IHostsGetParameter :
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.IJsonSerializable
    {
        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User Email",
        SerializedName = @"userEmail",
        PossibleTypes = new [] { typeof(string) })]
        string RequestUserEmail { get; set; }
        /// <summary>VM resource IDs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"VM resource IDs",
        SerializedName = @"vmIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> RequestVMId { get; set; }

    }
    /// Host Get Parameter specification.
    internal partial interface IHostsGetParameterInternal

    {
        /// <summary>The details of the Hosts get request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IHostsGetRequest Request { get; set; }
        /// <summary>User Email</summary>
        string RequestUserEmail { get; set; }
        /// <summary>VM resource IDs</summary>
        System.Collections.Generic.List<string> RequestVMId { get; set; }

    }
}