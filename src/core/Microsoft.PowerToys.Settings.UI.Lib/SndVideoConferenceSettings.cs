﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Lib
{
    public class SndVideoConferenceSettings
    {
        [JsonPropertyName("Video Conference")]
        public VideoConferenceSettings VideoConference { get; set; }

        public SndVideoConferenceSettings(VideoConferenceSettings settings)
        {
            VideoConference = settings;
        }

        public string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
