// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    /// <summary>
    /// The Resource Manager API includes operations for triggering and
    /// managing the backups of items protected by your Recovery Services
    /// Vault.
    /// </summary>
    public partial interface IBackupOperations
    {
        /// <summary>
        /// The Trigger Backup Operation starts an operation in the service
        /// which triggers the backup of the specified item in the specified
        /// container in your Recovery Services Vault. This is an asynchronous
        /// operation. To determine whether the backend service has finished
        /// processing the request, call Get Protected Item Operation Result
        /// API.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Name of your recovery services vault.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Request header parameters.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name of the protected item.
        /// </param>
        /// <param name='containerName'>
        /// Name of the container where the protected item belongs to.
        /// </param>
        /// <param name='protectedItemName'>
        /// Name of the protected item which has to be backed up.
        /// </param>
        /// <param name='request'>
        /// Backup request for the backup item.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Base recovery job response for all the asynchronous operations.
        /// </returns>
        Task<BaseRecoveryServicesJobResponse> TriggerBackupAsync(string resourceGroupName, string resourceName, CustomRequestHeaders customRequestHeaders, string fabricName, string containerName, string protectedItemName, TriggerBackupRequest request, CancellationToken cancellationToken);
    }
}