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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SearchForTextResult Object
    /// </summary>  
    public class SearchForTextResultUnmarshaller : IUnmarshaller<SearchForTextResult, XmlUnmarshallerContext>, IUnmarshaller<SearchForTextResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SearchForTextResult IUnmarshaller<SearchForTextResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SearchForTextResult Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SearchForTextResult unmarshalledObject = new SearchForTextResult();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Distance", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Distance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Place", targetDepth))
                {
                    var unmarshaller = PlaceUnmarshaller.Instance;
                    unmarshalledObject.Place = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Relevance", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Relevance = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SearchForTextResultUnmarshaller _instance = new SearchForTextResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SearchForTextResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}