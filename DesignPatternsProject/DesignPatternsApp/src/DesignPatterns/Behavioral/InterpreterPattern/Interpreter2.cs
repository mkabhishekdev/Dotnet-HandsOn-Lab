using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

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

        private IExpression BuildExpressionTree(string input)
        {
            string[] tokens = input.Split(" ");
            var output = new Queue<string>();
            var operators = new Stack<string>();

            // Shunting Yard Algorithm to convert infix to postfix
            foreach (var token in tokens)
            {
                if (int.TryParse(token, out _))
                {
                    output.Enqueue(token);          
                }
                else if (token == "+" || token == "-" )
                {
                    while (operators.Count > 0 && (operators.Peek() == "+" || operators.Peek() == "-"))
                    {
                        output.Enqueue(operators.Pop());
                    }
                    operators.Push(token);
                }
            }

            while (operators.Count > 0)
            {
                output.Enqueue(operators.Pop());
            }

            // Build expression tree from postfix notation
            var stack = new Stack<IExpression>();
            while (output.Count > 0)
            {
                var token = output.Dequeue();
                if (int.TryParse(token, out int number))
                {
                    stack.Push(new NumberExpression(number));   
                }
                else if (token == "+")
                {
                    var right = stack.Pop();
                    var left = stack.Pop();
                    stack.Push(new AdditionExpression(left, right));
                }
                else if (token == "-")
                {
                    var right = stack.Pop();
                    var left = stack.Pop();
                    stack.Push(new SubtractionExpression(left, right));
                }
            }
            return stack.Pop();
        }
    }
}