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
 * Do not modify this file. This file is generated from the profile-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Profile.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Profile.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteDomain Request Marshaller
    /// </summary>       
    public class DeleteDomainRequestMarshaller : IMarshaller<IRequest, DeleteDomainRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteDomainRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteDomainRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Profile");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-15";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetDomainName())
                throw new AmazonProfileException("Request object does not have required field DomainName set");
            request.AddPathResource("{DomainName}", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/domains/{DomainName}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DeleteDomainRequestMarshaller _instance = new DeleteDomainRequestMarshaller();        

        internal static DeleteDomainRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteDomainRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}