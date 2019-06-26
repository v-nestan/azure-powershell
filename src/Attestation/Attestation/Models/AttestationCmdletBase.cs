﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

// TODO: Remove IfDef
#if NETSTANDARD
using Microsoft.Azure.Graph.RBAC.Version1_6.ActiveDirectory;
#else
using Microsoft.Azure.ActiveDirectory.GraphClient;
#endif
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Attestation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Internal.Resources;
using Microsoft.Azure.Management.Internal.Resources.Models;
using Microsoft.Azure.Management.Internal.Resources.Utilities;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using Microsoft.Rest.Azure;
using Microsoft.Azure.Commands.Attestation.Properties;
using Microsoft.Azure.Commands.ResourceManager.Common.Paging;

namespace Microsoft.Azure.Commands.Attestation.Models
{
    public class AttestationManagementCmdletBase : AzureRMCmdlet
    {
        private AttestationClient attestationClient;


        public AttestationClient AttestationClient
        {
            get
            {
                if (attestationClient == null)
                {
                    attestationClient = new AttestationClient(DefaultContext);
                }
                return attestationClient;
            }
            set { attestationClient = value; }
        }

    }
}
