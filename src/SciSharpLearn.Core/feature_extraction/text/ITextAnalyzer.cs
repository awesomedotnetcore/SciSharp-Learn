﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SciSharpLearn.Core.feature_extraction.text
{
    public interface ITextAnalyzer
    {
        string[] analyze(string doc);
    }
}
