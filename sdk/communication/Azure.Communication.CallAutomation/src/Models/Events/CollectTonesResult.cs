﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    [CodeGenModel("CollectTonesResult", Usage = new string[] { "output" }, Formats = new string[] { "json" })]
    public partial class CollectTonesResult : RecognizeResult
    {
        /// <summary>
        /// The Tones colelcted.
        /// </summary>
        [CodeGenMember("Tones")]
        public IReadOnlyList<DtmfTone> Tones { get; }

        /// <summary>
        /// Convert the collection of tones to a string like "12345#".
        /// </summary>
        public string ConvertToString()
        {
            return string.Join("", Tones.Select(x => x.ToChar()));
        }
    }
}
