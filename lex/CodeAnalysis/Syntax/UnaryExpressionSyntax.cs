﻿using System.Collections.Generic;

namespace lex.CodeAnalysis.Syntax
{
    sealed class UnaryExpressionSyntax : ExpressionSyntax
    { 
        public UnaryExpressionSyntax(SyntaxToken operatorToken, ExpressionSyntax operand)
        {
    
            OperatorToken = operatorToken;
            Operand = operand;
        }

        public override SyntaxKind Kind => SyntaxKind.UnaryExpression;

        public SyntaxToken OperatorToken { get; }
        public ExpressionSyntax Operand { get; }

        public override IEnumerable<SyntaxNode> getChildern()
        {
            yield return OperatorToken;
            yield return Operand;

        }
    }
}

