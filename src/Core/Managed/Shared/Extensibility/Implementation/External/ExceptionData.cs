﻿#if NET45
    // .Net 4.5 has a custom implementation of RichPayloadEventSource
#elif NETSTANDARD1_3
    // TODO: This file can be included once RichPayloadEventSource is in the netstandard1.3 project
#else
namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
    /// <summary>
    /// Partial class to add the EventData attribute and any additional customizations to the generated type.
    /// </summary>
#if NET40
    [Microsoft.Diagnostics.Tracing.EventData(Name = "PartB_ExceptionData")]
#else
    [System.Diagnostics.Tracing.EventData(Name = "PartB_ExceptionData")]
#endif
    internal partial class ExceptionData
    {
    }
}
#endif