// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.AI;

/// <summary>
/// Represents the type of a real-time client message.
/// This is used to identify the purpose of the message being sent to the model.
/// </summary>
[Experimental("MEAI001")]
public enum RealtimeClientMessageType
{
    /// <summary>
    /// Indicates that the response contains only raw content.
    /// </summary>
    /// <remarks>
    /// This response type is to support extensibility for supporting custom content types not natively supported by the SDK.
    /// </remarks>
    RawContentOnly,

    /// <summary>
    /// Indicates the creation of a conversation item.
    /// </summary>
    /// <remarks>
    /// The type <ref name="RealtimeClientConversationItemCreateMessage"/> is used with this message type.
    /// </remarks>
    ConversationItemCreation,

    /// <summary>
    /// Indicates the creation of a response.
    /// </summary>
    /// <remarks>
    /// The type <ref name="RealtimeClientResponseCreateMessage"/> is used with this message type.
    /// </remarks>
    ResponseCreate,

    /// <summary>
    /// Indicates the appending of audio data to an input buffer.
    /// </summary>
    /// <remarks>
    /// The type <ref name="RealtimeClientInputAudioBufferAppendMessage"/> is used with this message type.
    /// </remarks>
    InputAudioBufferAppend,

    /// <summary>
    /// Indicates the committing of an input audio buffer.
    /// </summary>
    /// <remarks>
    /// The type <ref name="RealtimeClientInputAudioBufferCommitMessage"/> is used with this message type.
    /// </remarks>
    RealtimeInputAudioBufferCommit,
}
