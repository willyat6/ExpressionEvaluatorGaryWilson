using System;
using System.Data;
using System.Windows.Forms;

namespace SimpleExpressionEvaluator
{
    public partial class FormEvaluator : Form
    {
        private const string NOExpression = "No expression was supplied";
        private DataTable Evaluator = new DataTable();

        public FormEvaluator()
        {
            InitializeComponent();
        }

        private void UpdateResults(string result)
        {
            listBoxEvaluationResults.Items.Add(result);
        }

        public string Evaluate(string expression)
        {
            string result = Evaluator.Compute(expression, string.Empty).ToString();
            if (result == string.Empty)
            {
                result = "Failed to evaluate: " + expression;
            }
            Console.WriteLine(result);
            return result;
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

        // Design decisions - requirements stated the need of a simple expression evaluator so i kept it simple
        // As software professionals we should add value, and enhance re-use and not re-write logic that already exists

        //  Decided to avoid re-inventing the wheel
        //  There are already dozens of 3rd party libraries available to support this requirement

        // Generally - performance may be more critical but coders are expensive, so re-use of available tools 
        //  is a valuable skill today - we are data processors and system integrators more and more these days.

        // Extensibility - the Dataset.Compute() method is widely used and unlikely to go away any time soon, and already supports
        //  more than the required capability defined in requirements.

        // Trade-offs? Reduced delivery time now. Could multi-thread a middleware object to support many invokes per second later.
        //   Reliant on Microsoft preserving support for Dataset.Compute() method - but we are always reliant on something in .Net :-)
        
    }
}
