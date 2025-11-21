// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.AI;

/// <summary>
/// Represents a reusable prompts that you can use in requests, rather than specifying the content of prompts in code.
/// </summary>
[Experimental("MEAI001")]
public class PromptTemplate
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PromptTemplate"/> class.
    /// </summary>
    /// <param name="id">The unique identifier of your prompt.</param>
    /// <param name="version">An optional specific version of the prompt.</param>
    /// <param name="variables">An optional map of values to substitute in for variables in your prompt.</param>
    public PromptTemplate(string id, string? version = null, AdditionalPropertiesDictionary? variables = null)
    {
        Id = id;
        Version = version;
        Variables = variables;
    }

    /// <summary>
    /// Gets or sets the unique identifier of your prompt.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets an optional version of the prompt.
    /// </summary>
    public string? Version { get; set; }

    /// <summary>
    /// Gets or sets an optional map of values to substitute in for variables in your prompt.
    /// </summary>
    public AdditionalPropertiesDictionary? Variables { get; set; }
}

