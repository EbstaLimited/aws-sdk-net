/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetCommandInvocation operation.
    /// Returns detailed information about command execution for an invocation or plugin.
    /// 
    ///  
    /// <para>
    ///  <code>GetCommandInvocation</code> only gives the execution status of a plugin in
    /// a document. To get the command execution status on a specific managed node, use <a>ListCommandInvocations</a>.
    /// To get the command execution status across managed nodes, use <a>ListCommands</a>.
    /// </para>
    /// </summary>
    public partial class GetCommandInvocationRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _commandId;
        private string _instanceId;
        private string _pluginName;

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// (Required) The parent command ID of the invocation plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string CommandId
        {
            get { return this._commandId; }
            set { this._commandId = value; }
        }

        // Check to see if CommandId property is set
        internal bool IsSetCommandId()
        {
            return this._commandId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// (Required) The ID of the managed node targeted by the command. A <i>managed node</i>
        /// can be an Amazon Elastic Compute Cloud (Amazon EC2) instance, edge device, and on-premises
        /// server or VM in your hybrid environment that is configured for Amazon Web Services
        /// Systems Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property PluginName. 
        /// <para>
        /// The name of the plugin for which you want detailed results. If the document contains
        /// only one plugin, you can omit the name and details for that plugin. If the document
        /// contains more than one plugin, you must specify the name of the plugin for which you
        /// want to view details.
        /// </para>
        ///  
        /// <para>
        /// Plugin names are also referred to as <i>step names</i> in Systems Manager documents
        /// (SSM documents). For example, <code>aws:RunShellScript</code> is a plugin.
        /// </para>
        ///  
        /// <para>
        /// To find the <code>PluginName</code>, check the document content and find the name
        /// of the plugin. Alternatively, use <a>ListCommandInvocations</a> with the <code>CommandId</code>
        /// and <code>Details</code> parameters. The <code>PluginName</code> is the <code>Name</code>
        /// attribute of the <code>CommandPlugin</code> object in the <code>CommandPlugins</code>
        /// list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4)]
        public string PluginName
        {
            get { return this._pluginName; }
            set { this._pluginName = value; }
        }

        // Check to see if PluginName property is set
        internal bool IsSetPluginName()
        {
            return this._pluginName != null;
        }

    }
}