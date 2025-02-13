// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    internal partial class MySqlDatabaseListResult
    {
        internal static MySqlDatabaseListResult DeserializeMySqlDatabaseListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MySqlDatabaseData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MySqlDatabaseData> array = new List<MySqlDatabaseData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlDatabaseData.DeserializeMySqlDatabaseData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MySqlDatabaseListResult(Optional.ToList(value));
        }
    }
}
