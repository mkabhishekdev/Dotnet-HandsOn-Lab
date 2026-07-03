using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.InterpreterPattern
{
    public class Interpreter
    {
        private Context _context;

        public Interpreter(Context context)
        {
            _context = context;
        }

        public int Interpret(string expression)
        {
            IExpression expressionTree = BuildExpressionTree(expression);
            return expressionTree.Interpret(_context);
        }

        private IExpression BuildExpressionTree(string expression)
        {
            expression = "1 + 2 * 3";

            IExpression expressionTree = new AdditionExpression(
                new NumberExpression(1),
                new MultiplicationExpression(
                    new NumberExpression(2),
                    new NumberExpression(3)
                )
            );
            
            return expressionTree;
        }
    }
}