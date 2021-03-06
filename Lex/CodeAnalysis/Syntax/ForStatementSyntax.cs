namespace Lex.CodeAnalysis.Syntax
{
    // for i =1 to 10

    public sealed class ForStatementSyntax: StatementSyntax
    {
        public ForStatementSyntax(SyntaxToken keyword,SyntaxToken identifier, SyntaxToken equalsToken, ExpressionSyntax lowerBound,SyntaxToken tokeyword, ExpressionSyntax upperBoud,StatementSyntax body)
        {
            Keyword = keyword;
            Identifier = identifier;
            EqualsToken = equalsToken;
            LowerBound = lowerBound;
            Tokeyword = tokeyword;
            UpperBoud = upperBoud;
            Body = body;
        }

        public override SyntaxKind Kind => SyntaxKind.ForStatement;

        public SyntaxToken Keyword { get; }
        public SyntaxToken Identifier { get; }
        public SyntaxToken EqualsToken { get; }
        public ExpressionSyntax LowerBound { get; }
        public SyntaxToken Tokeyword { get; }
        public ExpressionSyntax UpperBoud { get; }
        public StatementSyntax Body { get; }
    }
}