// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServiceEndpointPolicyDefinitionsOperations.
    /// </summary>
    public static partial class ServiceEndpointPolicyDefinitionsOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified ServiceEndpoint policy definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the Service Endpoint Policy.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitionName'>
            /// The name of the service endpoint policy definition.
            /// </param>
            public static void Delete(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName)
            {
                operations.DeleteAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified ServiceEndpoint policy definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the Service Endpoint Policy.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitionName'>
            /// The name of the service endpoint policy definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get the specified service endpoint policy definitions from service endpoint
            /// policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy name.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitionName'>
            /// The name of the service endpoint policy definition name.
            /// </param>
            public static ServiceEndpointPolicyDefinition Get(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName)
            {
                return operations.GetAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified service endpoint policy definitions from service endpoint
            /// policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy name.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitionName'>
            /// The name of the service endpoint policy definition name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceEndpointPolicyDefinition> GetAsync(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a service endpoint policy definition in the specified
            /// service endpoint policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitionName'>
            /// The name of the service endpoint policy definition name.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitions'>
            /// Parameters supplied to the create or update service endpoint policy
            /// operation.
            /// </param>
            public static ServiceEndpointPolicyDefinition CreateOrUpdate(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinition serviceEndpointPolicyDefinitions)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a service endpoint policy definition in the specified
            /// service endpoint policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitionName'>
            /// The name of the service endpoint policy definition name.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitions'>
            /// Parameters supplied to the create or update service endpoint policy
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceEndpointPolicyDefinition> CreateOrUpdateAsync(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinition serviceEndpointPolicyDefinitions, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all service endpoint policy definitions in a service end point policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy name.
            /// </param>
            public static IPage<ServiceEndpointPolicyDefinition> ListByResourceGroup(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, serviceEndpointPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all service endpoint policy definitions in a service end point policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceEndpointPolicyDefinition>> ListByResourceGroupAsync(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified ServiceEndpoint policy definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the Service Endpoint Policy.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitionName'>
            /// The name of the service endpoint policy definition.
            /// </param>
            public static void BeginDelete(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified ServiceEndpoint policy definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the Service Endpoint Policy.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitionName'>
            /// The name of the service endpoint policy definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a service endpoint policy definition in the specified
            /// service endpoint policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitionName'>
            /// The name of the service endpoint policy definition name.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitions'>
            /// Parameters supplied to the create or update service endpoint policy
            /// operation.
            /// </param>
            public static ServiceEndpointPolicyDefinition BeginCreateOrUpdate(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinition serviceEndpointPolicyDefinitions)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a service endpoint policy definition in the specified
            /// service endpoint policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitionName'>
            /// The name of the service endpoint policy definition name.
            /// </param>
            /// <param name='serviceEndpointPolicyDefinitions'>
            /// Parameters supplied to the create or update service endpoint policy
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceEndpointPolicyDefinition> BeginCreateOrUpdateAsync(this IServiceEndpointPolicyDefinitionsOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string serviceEndpointPolicyDefinitionName, ServiceEndpointPolicyDefinition serviceEndpointPolicyDefinitions, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, serviceEndpointPolicyDefinitionName, serviceEndpointPolicyDefinitions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all service endpoint policy definitions in a service end point policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServiceEndpointPolicyDefinition> ListByResourceGroupNext(this IServiceEndpointPolicyDefinitionsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all service endpoint policy definitions in a service end point policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceEndpointPolicyDefinition>> ListByResourceGroupNextAsync(this IServiceEndpointPolicyDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}