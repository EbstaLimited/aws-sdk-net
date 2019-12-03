/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// This is the response object from the StartHumanLoop operation.
    /// </summary>
    public partial class StartHumanLoopResponse : AmazonWebServiceResponse
    {
        private HumanLoopActivationResults _humanLoopActivationResults;
        private string _humanLoopArn;

        /// <summary>
        /// Gets and sets the property HumanLoopActivationResults. 
        /// <para>
        /// An object containing information about the human loop activation.
        /// </para>
        /// </summary>
        public HumanLoopActivationResults HumanLoopActivationResults
        {
            get { return this._humanLoopActivationResults; }
            set { this._humanLoopActivationResults = value; }
        }

        // Check to see if HumanLoopActivationResults property is set
        internal bool IsSetHumanLoopActivationResults()
        {
            return this._humanLoopActivationResults != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the human loop.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string HumanLoopArn
        {
            get { return this._humanLoopArn; }
            set { this._humanLoopArn = value; }
        }

        // Check to see if HumanLoopArn property is set
        internal bool IsSetHumanLoopArn()
        {
            return this._humanLoopArn != null;
        }

    }
}