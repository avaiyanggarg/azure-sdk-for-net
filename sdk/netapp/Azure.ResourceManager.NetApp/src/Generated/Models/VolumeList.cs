// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> List of volume resources. </summary>
    internal partial class VolumeList
    {
        /// <summary> Initializes a new instance of VolumeList. </summary>
        internal VolumeList()
        {
            Value = new ChangeTrackingList<NetAppVolumeData>();
        }

        /// <summary> Initializes a new instance of VolumeList. </summary>
        /// <param name="value"> List of volumes. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        internal VolumeList(IReadOnlyList<NetAppVolumeData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of volumes. </summary>
        public IReadOnlyList<NetAppVolumeData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
