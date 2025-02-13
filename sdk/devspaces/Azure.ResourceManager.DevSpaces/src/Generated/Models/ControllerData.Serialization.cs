// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevSpaces.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevSpaces
{
    public partial class ControllerData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("targetContainerHostResourceId"u8);
            writer.WriteStringValue(TargetContainerHostResourceId);
            writer.WritePropertyName("targetContainerHostCredentialsBase64"u8);
            writer.WriteStringValue(TargetContainerHostCredentialsBase64);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ControllerData DeserializeControllerData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DevSpacesSku sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> hostSuffix = default;
            Optional<string> dataPlaneFqdn = default;
            Optional<string> targetContainerHostApiServerFqdn = default;
            string targetContainerHostResourceId = default;
            string targetContainerHostCredentialsBase64 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = DevSpacesSku.DeserializeDevSpacesSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hostSuffix"u8))
                        {
                            hostSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataPlaneFqdn"u8))
                        {
                            dataPlaneFqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetContainerHostApiServerFqdn"u8))
                        {
                            targetContainerHostApiServerFqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetContainerHostResourceId"u8))
                        {
                            targetContainerHostResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetContainerHostCredentialsBase64"u8))
                        {
                            targetContainerHostCredentialsBase64 = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ControllerData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku, Optional.ToNullable(provisioningState), hostSuffix.Value, dataPlaneFqdn.Value, targetContainerHostApiServerFqdn.Value, targetContainerHostResourceId, targetContainerHostCredentialsBase64);
        }
    }
}
