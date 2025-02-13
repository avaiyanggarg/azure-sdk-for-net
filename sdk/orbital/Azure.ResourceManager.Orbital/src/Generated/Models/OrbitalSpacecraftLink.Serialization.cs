// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class OrbitalSpacecraftLink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("centerFrequencyMHz"u8);
            writer.WriteNumberValue(CenterFrequencyMHz);
            writer.WritePropertyName("bandwidthMHz"u8);
            writer.WriteNumberValue(BandwidthMHz);
            writer.WritePropertyName("direction"u8);
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("polarization"u8);
            writer.WriteStringValue(Polarization.ToString());
            writer.WriteEndObject();
        }

        internal static OrbitalSpacecraftLink DeserializeOrbitalSpacecraftLink(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            float centerFrequencyMHz = default;
            float bandwidthMHz = default;
            OrbitalLinkDirection direction = default;
            OrbitalLinkPolarization polarization = default;
            Optional<IReadOnlyList<AuthorizedGroundStation>> authorizations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("centerFrequencyMHz"u8))
                {
                    centerFrequencyMHz = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bandwidthMHz"u8))
                {
                    bandwidthMHz = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("direction"u8))
                {
                    direction = new OrbitalLinkDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("polarization"u8))
                {
                    polarization = new OrbitalLinkPolarization(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AuthorizedGroundStation> array = new List<AuthorizedGroundStation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizedGroundStation.DeserializeAuthorizedGroundStation(item));
                    }
                    authorizations = array;
                    continue;
                }
            }
            return new OrbitalSpacecraftLink(name, centerFrequencyMHz, bandwidthMHz, direction, polarization, Optional.ToList(authorizations));
        }
    }
}
