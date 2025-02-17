﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Microsoft.DotNet.UpgradeAssistant.Analysis
{
    public record AnalyzeResult
    {
        public string RuleId { get; init; } = string.Empty;

        public string RuleName { get; init; } = string.Empty;

        public int LineNumber { get; init; }

        public string FileLocation { get; init; } = string.Empty;

        public string ResultMessage { get; init; } = string.Empty;
    }
}
