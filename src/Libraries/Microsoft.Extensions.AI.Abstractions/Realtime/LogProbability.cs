// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.AI;

/// <summary>
/// The log of the model’s confidence in generating a token. Higher values mean the token was more likely according to the model.
/// </summary>
[Experimental("MEAI001")]
public class LogProbability
{
    /// <summary>
    /// Gets or sets the bytes that were used to generate the log probability.
    /// </summary>
    public IEnumerable<byte>? Bytes { get; set; }

    /// <summary>
    /// Gets or sets the log probability value.
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// Gets or sets the token associated with the log probability.
    /// </summary>
    public string? Token { get; set; }
}
