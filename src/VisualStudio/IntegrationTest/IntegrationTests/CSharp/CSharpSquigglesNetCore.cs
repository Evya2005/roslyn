﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.VisualStudio.IntegrationTest.Utilities;
using Xunit;

namespace Roslyn.VisualStudio.IntegrationTests.CSharp
{
    [Collection(nameof(SharedIntegrationHostFixture))]
    public class CSharpSquigglesNetCore : CSharpSquigglesCommon
    {
        public CSharpSquigglesNetCore(VisualStudioInstanceFactory instanceFactory)
            :base(instanceFactory, WellKnownProjectTemplates.CSharpNetCoreClassLibrary)
        {
        }

        [Fact, Trait(Traits.Feature, Traits.Features.ErrorSquiggles)]
        public override void VerifySyntaxErrorSquiggles()
        {
            base.VerifySyntaxErrorSquiggles();
        }

        [Fact, Trait(Traits.Feature, Traits.Features.ErrorSquiggles)]
        public override void VerifySemanticErrorSquiggles()
        {
            base.VerifySemanticErrorSquiggles();
        }
    }
}
