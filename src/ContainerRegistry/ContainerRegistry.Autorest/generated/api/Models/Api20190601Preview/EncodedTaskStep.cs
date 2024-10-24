// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The properties of a encoded task step.</summary>
    public partial class EncodedTaskStep :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IEncodedTaskStep,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IEncodedTaskStepInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepProperties __taskStepProperties = new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.TaskStepProperties();

        /// <summary>List of base image dependencies for a step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageDependency[] BaseImageDependency { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepPropertiesInternal)__taskStepProperties).BaseImageDependency; }

        /// <summary>
        /// The token (git PAT or SAS token of storage account blob) associated with the context for a step.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public string ContextAccessToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepPropertiesInternal)__taskStepProperties).ContextAccessToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepPropertiesInternal)__taskStepProperties).ContextAccessToken = value ?? null; }

        /// <summary>The URL(absolute or relative) of the source context for the task step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public string ContextPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepPropertiesInternal)__taskStepProperties).ContextPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepPropertiesInternal)__taskStepProperties).ContextPath = value ?? null; }

        /// <summary>Backing field for <see cref="EncodedTaskContent" /> property.</summary>
        private string _encodedTaskContent;

        /// <summary>Base64 encoded value of the template/definition file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string EncodedTaskContent { get => this._encodedTaskContent; set => this._encodedTaskContent = value; }

        /// <summary>Backing field for <see cref="EncodedValuesContent" /> property.</summary>
        private string _encodedValuesContent;

        /// <summary>Base64 encoded value of the parameters/values file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string EncodedValuesContent { get => this._encodedValuesContent; set => this._encodedValuesContent = value; }

        /// <summary>Internal Acessors for BaseImageDependency</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IBaseImageDependency[] Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepPropertiesInternal.BaseImageDependency { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepPropertiesInternal)__taskStepProperties).BaseImageDependency; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepPropertiesInternal)__taskStepProperties).BaseImageDependency = value; }

        /// <summary>The type of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.StepType Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepPropertiesInternal)__taskStepProperties).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepPropertiesInternal)__taskStepProperties).Type = value ; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISetValue[] _value;

        /// <summary>The collection of overridable values that can be passed when running a task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISetValue[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="EncodedTaskStep" /> instance.</summary>
        public EncodedTaskStep()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__taskStepProperties), __taskStepProperties);
            await eventListener.AssertObjectIsValid(nameof(__taskStepProperties), __taskStepProperties);
        }
    }
    /// The properties of a encoded task step.
    public partial interface IEncodedTaskStep :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepProperties
    {
        /// <summary>Base64 encoded value of the template/definition file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Base64 encoded value of the template/definition file content.",
        SerializedName = @"encodedTaskContent",
        PossibleTypes = new [] { typeof(string) })]
        string EncodedTaskContent { get; set; }
        /// <summary>Base64 encoded value of the parameters/values file content.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Base64 encoded value of the parameters/values file content.",
        SerializedName = @"encodedValuesContent",
        PossibleTypes = new [] { typeof(string) })]
        string EncodedValuesContent { get; set; }
        /// <summary>The collection of overridable values that can be passed when running a task.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The collection of overridable values that can be passed when running a task.",
        SerializedName = @"values",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISetValue) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISetValue[] Value { get; set; }

    }
    /// The properties of a encoded task step.
    internal partial interface IEncodedTaskStepInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepPropertiesInternal
    {
        /// <summary>Base64 encoded value of the template/definition file content.</summary>
        string EncodedTaskContent { get; set; }
        /// <summary>Base64 encoded value of the parameters/values file content.</summary>
        string EncodedValuesContent { get; set; }
        /// <summary>The collection of overridable values that can be passed when running a task.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISetValue[] Value { get; set; }

    }
}