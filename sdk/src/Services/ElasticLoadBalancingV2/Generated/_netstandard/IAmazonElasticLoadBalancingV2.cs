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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ElasticLoadBalancingV2.Model;

namespace Amazon.ElasticLoadBalancingV2
{
    /// <summary>
    /// Interface for accessing ElasticLoadBalancingV2
    ///
    /// Elastic Load Balancing 
    /// <para>
    /// A load balancer distributes incoming traffic across targets, such as your EC2 instances.
    /// This enables you to increase the availability of your application. The load balancer
    /// also monitors the health of its registered targets and ensures that it routes traffic
    /// only to healthy targets. You configure your load balancer to accept incoming traffic
    /// by specifying one or more listeners, which are configured with a protocol and port
    /// number for connections from clients to the load balancer. You configure a target group
    /// with a protocol and port number for connections from the load balancer to the targets,
    /// and with health check settings to be used when checking the health status of the targets.
    /// </para>
    ///  
    /// <para>
    /// Elastic Load Balancing supports the following types of load balancers: Application
    /// Load Balancers, Network Load Balancers, and Classic Load Balancers. This reference
    /// covers Application Load Balancers and Network Load Balancers.
    /// </para>
    ///  
    /// <para>
    /// An Application Load Balancer makes routing and load balancing decisions at the application
    /// layer (HTTP/HTTPS). A Network Load Balancer makes routing and load balancing decisions
    /// at the transport layer (TCP/TLS). Both Application Load Balancers and Network Load
    /// Balancers can route requests to one or more ports on each EC2 instance or container
    /// instance in your virtual private cloud (VPC). For more information, see the <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/userguide/">Elastic
    /// Load Balancing User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// All Elastic Load Balancing operations are idempotent, which means that they complete
    /// at most one time. If you repeat an operation, it succeeds.
    /// </para>
    /// </summary>
    public partial interface IAmazonElasticLoadBalancingV2 : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IElasticLoadBalancingV2PaginatorFactory Paginators { get; }
#endif
                
        #region  AddListenerCertificates



        /// <summary>
        /// Adds the specified SSL server certificate to the certificate list for the specified
        /// HTTPS or TLS listener.
        /// 
        ///  
        /// <para>
        /// If the certificate in already in the certificate list, the call is successful but
        /// the certificate is not added again.
        /// </para>
        ///  
        /// <para>
        /// To get the certificate list for a listener, use <a>DescribeListenerCertificates</a>.
        /// To remove certificates from the certificate list for a listener, use <a>RemoveListenerCertificates</a>.
        /// To replace the default certificate for a listener, use <a>ModifyListener</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/create-https-listener.html#https-listener-certificates">SSL
        /// Certificates</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddListenerCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddListenerCertificates service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CertificateNotFoundException">
        /// The specified certificate does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyCertificatesException">
        /// You've reached the limit on the number of certificates per load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddListenerCertificates">REST API Reference for AddListenerCertificates Operation</seealso>
        Task<AddListenerCertificatesResponse> AddListenerCertificatesAsync(AddListenerCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddTags



        /// <summary>
        /// Adds the specified tags to the specified Elastic Load Balancing resource. You can
        /// tag your Application Load Balancers, Network Load Balancers, target groups, listeners,
        /// and rules.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a resource already has a tag
        /// with the same key, <code>AddTags</code> updates its value.
        /// </para>
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>DescribeTags</a>. To remove tags
        /// from your resources, use <a>RemoveTags</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddTags">REST API Reference for AddTags Operation</seealso>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateListener



        /// <summary>
        /// Creates a listener for the specified Application Load Balancer or Network Load Balancer.
        /// 
        ///  
        /// <para>
        /// To update a listener, use <a>ModifyListener</a>. When you are finished with a listener,
        /// you can delete it using <a>DeleteListener</a>. If you are finished with both the listener
        /// and the load balancer, you can delete them both using <a>DeleteLoadBalancer</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent, which means that it completes at most one time. If you
        /// attempt to create multiple listeners with the same settings, each call succeeds.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-listeners.html">Listeners
        /// for Your Application Load Balancers</a> in the <i>Application Load Balancers Guide</i>
        /// and <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-listeners.html">Listeners
        /// for Your Network Load Balancers</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateListener service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ALPNPolicyNotSupportedException">
        /// The specified ALPN policy is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CertificateNotFoundException">
        /// The specified certificate does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateListenerException">
        /// A listener with the specified port already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SSLPolicyNotFoundException">
        /// The specified SSL policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyCertificatesException">
        /// You've reached the limit on the number of certificates per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyListenersException">
        /// You've reached the limit on the number of listeners per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateListener">REST API Reference for CreateListener Operation</seealso>
        Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLoadBalancer



        /// <summary>
        /// Creates an Application Load Balancer or a Network Load Balancer.
        /// 
        ///  
        /// <para>
        /// When you create a load balancer, you can specify security groups, public subnets,
        /// IP address type, and tags. Otherwise, you could do so later using <a>SetSecurityGroups</a>,
        /// <a>SetSubnets</a>, <a>SetIpAddressType</a>, and <a>AddTags</a>.
        /// </para>
        ///  
        /// <para>
        /// To create listeners for your load balancer, use <a>CreateListener</a>. To describe
        /// your current load balancers, see <a>DescribeLoadBalancers</a>. When you are finished
        /// with a load balancer, you can delete it using <a>DeleteLoadBalancer</a>.
        /// </para>
        ///  
        /// <para>
        /// For limit information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-limits.html">Limits
        /// for Your Application Load Balancer</a> in the <i>Application Load Balancers Guide</i>
        /// and <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-limits.html">Limits
        /// for Your Network Load Balancer</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent, which means that it completes at most one time. If you
        /// attempt to create multiple load balancers with the same settings, each call succeeds.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/application-load-balancers.html">Application
        /// Load Balancers</a> in the <i>Application Load Balancers Guide</i> and <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/network-load-balancers.html">Network
        /// Load Balancers</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AllocationIdNotFoundException">
        /// The specified allocation ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AvailabilityZoneNotSupportedException">
        /// The specified Availability Zone is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateLoadBalancerNameException">
        /// A load balancer with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSchemeException">
        /// The requested scheme is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSecurityGroupException">
        /// The specified security group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSubnetException">
        /// The specified subnet is out of available addresses.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SubnetNotFoundException">
        /// The specified subnet does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyLoadBalancersException">
        /// You've reached the limit on the number of load balancers for your AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRule



        /// <summary>
        /// Creates a rule for the specified listener. The listener must be associated with an
        /// Application Load Balancer.
        /// 
        ///  
        /// <para>
        /// Each rule consists of a priority, one or more actions, and one or more conditions.
        /// Rules are evaluated in priority order, from the lowest value to the highest value.
        /// When the conditions for a rule are met, its actions are performed. If the conditions
        /// for no rules are met, the actions for the default rule are performed. For more information,
        /// see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-listeners.html#listener-rules">Listener
        /// Rules</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To view your current rules, use <a>DescribeRules</a>. To update a rule, use <a>ModifyRule</a>.
        /// To set the priorities of your rules, use <a>SetRulePriorities</a>. To delete a rule,
        /// use <a>DeleteRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.PriorityInUseException">
        /// The specified priority is in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRulesException">
        /// You've reached the limit on the number of rules per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetGroupsException">
        /// You've reached the limit on the number of target groups for your AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateRule">REST API Reference for CreateRule Operation</seealso>
        Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTargetGroup



        /// <summary>
        /// Creates a target group.
        /// 
        ///  
        /// <para>
        /// To register targets with the target group, use <a>RegisterTargets</a>. To update the
        /// health check settings for the target group, use <a>ModifyTargetGroup</a>. To monitor
        /// the health of targets in the target group, use <a>DescribeTargetHealth</a>.
        /// </para>
        ///  
        /// <para>
        /// To route traffic to the targets in a target group, specify the target group in an
        /// action using <a>CreateListener</a> or <a>CreateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To delete a target group, use <a>DeleteTargetGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent, which means that it completes at most one time. If you
        /// attempt to create multiple target groups with the same settings, each call succeeds.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-target-groups.html">Target
        /// Groups for Your Application Load Balancers</a> in the <i>Application Load Balancers
        /// Guide</i> or <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html">Target
        /// Groups for Your Network Load Balancers</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTargetGroupNameException">
        /// A target group with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetGroupsException">
        /// You've reached the limit on the number of target groups for your AWS account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        Task<CreateTargetGroupResponse> CreateTargetGroupAsync(CreateTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteListener



        /// <summary>
        /// Deletes the specified listener.
        /// 
        ///  
        /// <para>
        /// Alternatively, your listener is deleted when you delete the load balancer to which
        /// it is attached, using <a>DeleteLoadBalancer</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteListener service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLoadBalancer



        /// <summary>
        /// Deletes the specified Application Load Balancer or Network Load Balancer and its attached
        /// listeners.
        /// 
        ///  
        /// <para>
        /// You can't delete a load balancer if deletion protection is enabled. If the load balancer
        /// does not exist or has already been deleted, the call succeeds.
        /// </para>
        ///  
        /// <para>
        /// Deleting a load balancer does not affect its registered targets. For example, your
        /// EC2 instances continue to run and are still registered to their target groups. If
        /// you no longer need these EC2 instances, you can stop or terminate them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRule



        /// <summary>
        /// Deletes the specified rule.
        /// 
        ///  
        /// <para>
        /// You can't delete the default rule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTargetGroup



        /// <summary>
        /// Deletes the specified target group.
        /// 
        ///  
        /// <para>
        /// You can delete a target group if it is not referenced by any actions. Deleting a target
        /// group also deletes any associated health checks.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        Task<DeleteTargetGroupResponse> DeleteTargetGroupAsync(DeleteTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterTargets



        /// <summary>
        /// Deregisters the specified targets from the specified target group. After the targets
        /// are deregistered, they no longer receive traffic from the load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTargets service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist, is not in the same VPC as the target group, or
        /// has an unsupported instance type.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        Task<DeregisterTargetsResponse> DeregisterTargetsAsync(DeregisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountLimits



        /// <summary>
        /// Describes the current Elastic Load Balancing resource limits for your AWS account.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-limits.html">Limits
        /// for Your Application Load Balancers</a> in the <i>Application Load Balancer Guide</i>
        /// or <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-limits.html">Limits
        /// for Your Network Load Balancers</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeListenerCertificates



        /// <summary>
        /// Describes the default certificate and the certificate list for the specified HTTPS
        /// or TLS listener.
        /// 
        ///  
        /// <para>
        /// If the default certificate is also in the certificate list, it appears twice in the
        /// results (once with <code>IsDefault</code> set to true and once with <code>IsDefault</code>
        /// set to false).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/create-https-listener.html#https-listener-certificates">SSL
        /// Certificates</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeListenerCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeListenerCertificates service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListenerCertificates">REST API Reference for DescribeListenerCertificates Operation</seealso>
        Task<DescribeListenerCertificatesResponse> DescribeListenerCertificatesAsync(DescribeListenerCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeListeners



        /// <summary>
        /// Describes the specified listeners or the listeners for the specified Application Load
        /// Balancer or Network Load Balancer. You must specify either a load balancer or one
        /// or more listeners.
        /// 
        ///  
        /// <para>
        /// For an HTTPS or TLS listener, the output includes the default certificate for the
        /// listener. To describe the certificate list for the listener, use <a>DescribeListenerCertificates</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeListeners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeListeners service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListeners">REST API Reference for DescribeListeners Operation</seealso>
        Task<DescribeListenersResponse> DescribeListenersAsync(DescribeListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoadBalancerAttributes



        /// <summary>
        /// Describes the attributes for the specified Application Load Balancer or Network Load
        /// Balancer.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/application-load-balancers.html#load-balancer-attributes">Load
        /// Balancer Attributes</a> in the <i>Application Load Balancers Guide</i> or <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/network-load-balancers.html#load-balancer-attributes">Load
        /// Balancer Attributes</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancerAttributes">REST API Reference for DescribeLoadBalancerAttributes Operation</seealso>
        Task<DescribeLoadBalancerAttributesResponse> DescribeLoadBalancerAttributesAsync(DescribeLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoadBalancers



        /// <summary>
        /// Describes the specified load balancers or all of your load balancers.
        /// 
        ///  
        /// <para>
        /// To describe the listeners for a load balancer, use <a>DescribeListeners</a>. To describe
        /// the attributes for a load balancer, use <a>DescribeLoadBalancerAttributes</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRules



        /// <summary>
        /// Describes the specified rules or the rules for the specified listener. You must specify
        /// either a listener or one or more rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRules service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeRules">REST API Reference for DescribeRules Operation</seealso>
        Task<DescribeRulesResponse> DescribeRulesAsync(DescribeRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSSLPolicies



        /// <summary>
        /// Describes the specified policies or all policies used for SSL negotiation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/create-https-listener.html#describe-ssl-policies">Security
        /// Policies</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSSLPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSSLPolicies service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SSLPolicyNotFoundException">
        /// The specified SSL policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeSSLPolicies">REST API Reference for DescribeSSLPolicies Operation</seealso>
        Task<DescribeSSLPoliciesResponse> DescribeSSLPoliciesAsync(DescribeSSLPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTags



        /// <summary>
        /// Describes the tags for the specified Elastic Load Balancing resources. You can describe
        /// the tags for one or more Application Load Balancers, Network Load Balancers, target
        /// groups, listeners, or rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTargetGroupAttributes



        /// <summary>
        /// Describes the attributes for the specified target group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-target-groups.html#target-group-attributes">Target
        /// Group Attributes</a> in the <i>Application Load Balancers Guide</i> or <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html#target-group-attributes">Target
        /// Group Attributes</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroupAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTargetGroupAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroupAttributes">REST API Reference for DescribeTargetGroupAttributes Operation</seealso>
        Task<DescribeTargetGroupAttributesResponse> DescribeTargetGroupAttributesAsync(DescribeTargetGroupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTargetGroups



        /// <summary>
        /// Describes the specified target groups or all of your target groups. By default, all
        /// target groups are described. Alternatively, you can specify one of the following to
        /// filter the results: the ARN of the load balancer, the names of one or more target
        /// groups, or the ARNs of one or more target groups.
        /// 
        ///  
        /// <para>
        /// To describe the targets for a target group, use <a>DescribeTargetHealth</a>. To describe
        /// the attributes of a target group, use <a>DescribeTargetGroupAttributes</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTargetGroups service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroups">REST API Reference for DescribeTargetGroups Operation</seealso>
        Task<DescribeTargetGroupsResponse> DescribeTargetGroupsAsync(DescribeTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTargetHealth



        /// <summary>
        /// Describes the health of the specified targets or all of your targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTargetHealth service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.HealthUnavailableException">
        /// The health of the specified targets could not be retrieved due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist, is not in the same VPC as the target group, or
        /// has an unsupported instance type.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetHealth">REST API Reference for DescribeTargetHealth Operation</seealso>
        Task<DescribeTargetHealthResponse> DescribeTargetHealthAsync(DescribeTargetHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyListener



        /// <summary>
        /// Replaces the specified properties of the specified listener. Any properties that you
        /// do not specify remain unchanged.
        /// 
        ///  
        /// <para>
        /// Changing the protocol from HTTPS to HTTP, or from TLS to TCP, removes the security
        /// policy and default certificate properties. If you change the protocol from HTTP to
        /// HTTPS, or from TCP to TLS, you must add the security policy and default certificate
        /// properties.
        /// </para>
        ///  
        /// <para>
        /// To add an item to a list, remove an item from a list, or update an item in a list,
        /// you must provide the entire list. For example, to add an action, specify a list with
        /// the current actions plus the new action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyListener service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ALPNPolicyNotSupportedException">
        /// The specified ALPN policy is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CertificateNotFoundException">
        /// The specified certificate does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateListenerException">
        /// A listener with the specified port already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SSLPolicyNotFoundException">
        /// The specified SSL policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyCertificatesException">
        /// You've reached the limit on the number of certificates per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyListenersException">
        /// You've reached the limit on the number of listeners per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyListener">REST API Reference for ModifyListener Operation</seealso>
        Task<ModifyListenerResponse> ModifyListenerAsync(ModifyListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyLoadBalancerAttributes



        /// <summary>
        /// Modifies the specified attributes of the specified Application Load Balancer or Network
        /// Load Balancer.
        /// 
        ///  
        /// <para>
        /// If any of the specified attributes can't be modified as requested, the call fails.
        /// Any existing attributes that you do not modify retain their current values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyLoadBalancerAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyLoadBalancerAttributes">REST API Reference for ModifyLoadBalancerAttributes Operation</seealso>
        Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributesAsync(ModifyLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyRule



        /// <summary>
        /// Replaces the specified properties of the specified rule. Any properties that you do
        /// not specify are unchanged.
        /// 
        ///  
        /// <para>
        /// To add an item to a list, remove an item from a list, or update an item in a list,
        /// you must provide the entire list. For example, to add an action, specify a list with
        /// the current actions plus the new action.
        /// </para>
        ///  
        /// <para>
        /// To modify the actions for the default rule, use <a>ModifyListener</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyRule">REST API Reference for ModifyRule Operation</seealso>
        Task<ModifyRuleResponse> ModifyRuleAsync(ModifyRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyTargetGroup



        /// <summary>
        /// Modifies the health checks used when evaluating the health state of the targets in
        /// the specified target group.
        /// 
        ///  
        /// <para>
        /// To monitor the health of the targets, use <a>DescribeTargetHealth</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroup">REST API Reference for ModifyTargetGroup Operation</seealso>
        Task<ModifyTargetGroupResponse> ModifyTargetGroupAsync(ModifyTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ModifyTargetGroupAttributes



        /// <summary>
        /// Modifies the specified attributes of the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroupAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTargetGroupAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroupAttributes">REST API Reference for ModifyTargetGroupAttributes Operation</seealso>
        Task<ModifyTargetGroupAttributesResponse> ModifyTargetGroupAttributesAsync(ModifyTargetGroupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterTargets



        /// <summary>
        /// Registers the specified targets with the specified target group.
        /// 
        ///  
        /// <para>
        /// If the target is an EC2 instance, it must be in the <code>running</code> state when
        /// you register it.
        /// </para>
        ///  
        /// <para>
        /// By default, the load balancer routes requests to registered targets using the protocol
        /// and port for the target group. Alternatively, you can override the port for a target
        /// when you register it. You can register each EC2 instance or IP address with the same
        /// target group multiple times using different ports.
        /// </para>
        ///  
        /// <para>
        /// With a Network Load Balancer, you cannot register instances by instance ID if they
        /// have the following instance types: C1, CC1, CC2, CG1, CG2, CR1, CS1, G1, G2, HI1,
        /// HS1, M1, M2, M3, and T1. You can register instances of these types by IP address.
        /// </para>
        ///  
        /// <para>
        /// To remove a target from a target group, use <a>DeregisterTargets</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTargets service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist, is not in the same VPC as the target group, or
        /// has an unsupported instance type.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        Task<RegisterTargetsResponse> RegisterTargetsAsync(RegisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveListenerCertificates



        /// <summary>
        /// Removes the specified certificate from the certificate list for the specified HTTPS
        /// or TLS listener.
        /// 
        ///  
        /// <para>
        /// You can't remove the default certificate for a listener. To replace the default certificate,
        /// call <a>ModifyListener</a>.
        /// </para>
        ///  
        /// <para>
        /// To list the certificates for your listener, use <a>DescribeListenerCertificates</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveListenerCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveListenerCertificates service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveListenerCertificates">REST API Reference for RemoveListenerCertificates Operation</seealso>
        Task<RemoveListenerCertificatesResponse> RemoveListenerCertificatesAsync(RemoveListenerCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveTags



        /// <summary>
        /// Removes the specified tags from the specified Elastic Load Balancing resources. You
        /// can remove the tags for one or more Application Load Balancers, Network Load Balancers,
        /// target groups, listeners, or rules.
        /// 
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>DescribeTags</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetIpAddressType



        /// <summary>
        /// Sets the type of IP addresses used by the subnets of the specified Application Load
        /// Balancer or Network Load Balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIpAddressType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetIpAddressType service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSubnetException">
        /// The specified subnet is out of available addresses.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetIpAddressType">REST API Reference for SetIpAddressType Operation</seealso>
        Task<SetIpAddressTypeResponse> SetIpAddressTypeAsync(SetIpAddressTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetRulePriorities



        /// <summary>
        /// Sets the priorities of the specified rules.
        /// 
        ///  
        /// <para>
        /// You can reorder the rules as long as there are no priority conflicts in the new order.
        /// Any existing rules that you do not specify retain their current priority.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetRulePriorities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetRulePriorities service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.PriorityInUseException">
        /// The specified priority is in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetRulePriorities">REST API Reference for SetRulePriorities Operation</seealso>
        Task<SetRulePrioritiesResponse> SetRulePrioritiesAsync(SetRulePrioritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetSecurityGroups



        /// <summary>
        /// Associates the specified security groups with the specified Application Load Balancer.
        /// The specified security groups override the previously associated security groups.
        /// 
        ///  
        /// <para>
        /// You can't specify a security group for a Network Load Balancer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetSecurityGroups service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSecurityGroupException">
        /// The specified security group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSecurityGroups">REST API Reference for SetSecurityGroups Operation</seealso>
        Task<SetSecurityGroupsResponse> SetSecurityGroupsAsync(SetSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetSubnets



        /// <summary>
        /// Enables the Availability Zones for the specified public subnets for the specified
        /// load balancer. The specified subnets replace the previously enabled subnets.
        /// 
        ///  
        /// <para>
        /// When you specify subnets for a Network Load Balancer, you must include all subnets
        /// that were enabled previously, with their existing configurations, plus any additional
        /// subnets.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSubnets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetSubnets service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AllocationIdNotFoundException">
        /// The specified allocation ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AvailabilityZoneNotSupportedException">
        /// The specified Availability Zone is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSubnetException">
        /// The specified subnet is out of available addresses.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SubnetNotFoundException">
        /// The specified subnet does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSubnets">REST API Reference for SetSubnets Operation</seealso>
        Task<SetSubnetsResponse> SetSubnetsAsync(SetSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}