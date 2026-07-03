using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.InterpreterPattern
{
    public class AdditionExpression : IExpression
    {
        private IExpression _leftExpression;
        private IExpression _rightExpression;

        public AdditionExpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret(Context context)
        {
            return _leftExpression.Interpret(context) + _rightExpression.Interpret(context);
        }
    }
}