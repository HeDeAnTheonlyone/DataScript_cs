using Diagnostics;

namespace Compiler;



public class Parser
{
    private Status status;
    private Lexer lexer;



    public Parser(Status _status)
    {
        lexer = new Lexer();
        status = _status;
    }



    public void Parse()
    {
        var tokenList = new List<Token>();

        do
        {
            var token = lexer.NextToken();
        }
    }
}