﻿// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

#if NET45
using System.Threading.Tasks;

namespace Z.Expressions
{
    public static partial class Eval
    {
        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public static Task<TResult> ExecuteAsync<TResult>(string code)
        {
            return EvalManager.DefaultContext.ExecuteAsync<TResult>(code);
        }

        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <param name="parameters">The parameter values used to evaluates the code or expression.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public static Task<TResult> ExecuteAsync<TResult>(string code, object parameters)
        {
            return EvalManager.DefaultContext.ExecuteAsync<TResult>(code, parameters);
        }

        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <param name="parameters">The parameter values used to evaluates the code or expression.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public static Task<TResult> ExecuteAsync<TResult>(string code, params object[] parameters)
        {
            return EvalManager.DefaultContext.ExecuteAsync<TResult>(code, parameters);
        }
    }
}

#endif