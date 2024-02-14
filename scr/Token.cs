
namespace Compiler;



public enum TokenType
{
    Error,
    Whitespace,
    Digit,
    Text,
    EndOfFile
} 



public struct Token
{
    public Token(int _position, string _context, TokenType _type)
    {
        Position = _position;
        Context = _context;
        Type = _type;
    }

    public int Position { get; }
    public string Context { get; }
    public TokenType Type { get; }
}