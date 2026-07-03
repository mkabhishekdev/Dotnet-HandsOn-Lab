using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.InterpreterPattern
{
    public interface IExpression
    {
        int Interpret(Context context);
    }
}