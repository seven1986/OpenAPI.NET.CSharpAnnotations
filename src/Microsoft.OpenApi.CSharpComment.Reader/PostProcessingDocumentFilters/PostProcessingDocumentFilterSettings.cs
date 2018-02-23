﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using Microsoft.OpenApi.CSharpComment.Reader.Models;
using System.Collections.Generic;

namespace Microsoft.OpenApi.CSharpComment.Reader.PostProcessingDocumentFilters
{
    /// <summary>
    /// Settings for <see cref="IPostProcessingDocumentFilter"/>.
    /// </summary>
    public class PostProcessingDocumentFilterSettings
    {
        /// <summary>
        /// List of operation-level generation diagnostics.
        /// </summary>
        public IList<OperationGenerationDiagnostic> OperationGenerationDiagnostics { get; internal set; } =
            new List<OperationGenerationDiagnostic>();
    }
}