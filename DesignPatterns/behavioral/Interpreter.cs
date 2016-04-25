using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.InterpreterApp
{
    /// <summary>
    /// MainApp startup class for Structural 
    /// Interpreter Design Pattern.
    /// </summary>
    class InterpreterApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Show()
        {
            Context context = new Context();

            // Usually a tree 
            List<AbstractExpression> list = new List<AbstractExpression>();

            // Populate 'abstract syntax tree' 
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
    class Context
    {
    }

    /// <summary>
    /// The 'AbstractExpression' abstract class
    /// </summary>
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    /// <summary>
    /// The 'TerminalExpression' class
    /// </summary>
    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }

    /// <summary>
    /// The 'NonterminalExpression' class
    /// </summary>
    class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}