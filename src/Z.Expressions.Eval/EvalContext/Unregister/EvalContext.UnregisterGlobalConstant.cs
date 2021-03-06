﻿// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System.Linq.Expressions;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Unregisters a global constant.</summary>
        /// <param name="aliases">The global constant name.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterGlobalConstant(params string[] aliases)
        {
            foreach (var alias in aliases)
            {
                ConstantExpression value;
                AliasGlobalConstants.TryRemove(alias, out value);
            }

            return this;
        }
    }
}