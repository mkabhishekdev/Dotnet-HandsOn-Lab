using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.InterpreterPattern
{
    public class Interpreter2
    {
        private Context _context;

        public Interpreter2(Context context)
        {
            _context = context;
        }

        public int Interpret(string expression)
        {
            IExpression expressionTree = BuildExpressionTree(expression);
            return expressionTree.Interpret(_context);
        }

        
    }
}