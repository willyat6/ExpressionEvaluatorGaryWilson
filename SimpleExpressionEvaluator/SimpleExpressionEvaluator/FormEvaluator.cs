using System;
using System.Windows.Forms;

namespace SimpleExpressionEvaluator
{
    public partial class FormEvaluator : Form
    {
        private const string NOExpression = "No expression was supplied";

        public FormEvaluator()
        {
            InitializeComponent();
        }

        private void UpdateResults(string result)
        {
            listBoxEvaluationResults.Items.Add(result);
            Console.WriteLine(result);
        }

        public string Evaluate(string expression)
        {
            ExpressionIterator parser = new ExpressionIterator();
            decimal result = parser.EvaluateStringExpression(textBoxExpression.Text);

            UpdateResults("ExpressionIterator says the answer is: " + result.ToString());
            return result.ToString();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBoxExpression.Text.Trim();
                if (expression == string.Empty)
                {
                    expression = NOExpression;
                }
                else
                {
                    expression = expression + " evaluates to " + Evaluate(expression);
                }
                UpdateResults(expression);
            }
            catch (Exception evaluateEx)
            {
                UpdateResults("Exception during expression evaluation: " + evaluateEx.Message);
            }
        }


        // Generally - performance - if the ExpressionIterator was to be used by multiple clients, a multi-threaded assembly to accept many simultaneous
        //  requests to resolve expressions could be accommodated with a new instance of the ExpressionIterator class per thread created

        // Extensibility - 

        //  ExpressionIterator currently supports limited operators as per requirements, including unary -, and supports decimal numbers
        //  Extension of support for more operators and construction controllers (the other kinds of mathematical braces and functions other than ())
        //    can be achieved by extension of the three 'supported' constants defined at the top of the ExpressionIterator class, and supporting new code
        //    within the main algorithm that decides what to do with a particular character. To support other mathematical construction symbols within formulae
        //    over and above simple brackets, the main logic of the algorithm would need to be enhanced to support the other construction characters. 
        //    A more generic 'IamEnteringAConstructionBrace' function could be added instead of the hard coded '(', and an accompanying 
        //                   'ClosingConstructionSymbolFound' function could be added instead of the hard coded ')' check. The stack operations of 
        //    Pop, Peek, Push would continue for all nested construction characters in more complex mathematical formulae

        //    Supports expressions of format: 
        //      5*(-2)
        //      (5 + 5) * (3 + 2) - 1
        //      (5 + 5) * (3 + 2) - -1 
        //      (5 + 5.25) * (1.75 + 2.25) - -1
        //      (5 + -5) * (3 + 2) - 1
        //      (6 + 0 ) * (3 * -2) 
        //      (6 *-2 ) * (3 * -2) 

        // Trade-offs? 
        // Solution uses an algorithm that walks through the expression left to right, and nests any bracketed sub-expressions to stack operations
        //  so that execution of (leftParam operator rightParam) succeeds according to mathematical rules of precedence

        // Summary - a bit Heath-Robinson but seems to have some future lifespan and maintainability - though like any algorithm, you gotta know what 
        //   its doing.

    }
}
