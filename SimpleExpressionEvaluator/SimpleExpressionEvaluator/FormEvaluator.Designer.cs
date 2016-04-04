namespace SimpleExpressionEvaluator
{
    partial class FormEvaluator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.listBoxEvaluationResults = new System.Windows.Forms.ListBox();
            this.labelExpression = new System.Windows.Forms.Label();
            this.labelEvalResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Location = new System.Drawing.Point(35, 51);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(282, 20);
            this.textBoxExpression.TabIndex = 0;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(335, 50);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluate.TabIndex = 1;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // listBoxEvaluationResults
            // 
            this.listBoxEvaluationResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvaluationResults.FormattingEnabled = true;
            this.listBoxEvaluationResults.Location = new System.Drawing.Point(35, 107);
            this.listBoxEvaluationResults.Name = "listBoxEvaluationResults";
            this.listBoxEvaluationResults.Size = new System.Drawing.Size(376, 277);
            this.listBoxEvaluationResults.TabIndex = 2;
            // 
            // labelExpression
            // 
            this.labelExpression.AutoSize = true;
            this.labelExpression.Location = new System.Drawing.Point(32, 35);
            this.labelExpression.Name = "labelExpression";
            this.labelExpression.Size = new System.Drawing.Size(114, 13);
            this.labelExpression.TabIndex = 3;
            this.labelExpression.Text = "Expression to evaluate";
            // 
            // labelEvalResults
            // 
            this.labelEvalResults.AutoSize = true;
            this.labelEvalResults.Location = new System.Drawing.Point(32, 91);
            this.labelEvalResults.Name = "labelEvalResults";
            this.labelEvalResults.Size = new System.Drawing.Size(42, 13);
            this.labelEvalResults.TabIndex = 4;
            this.labelEvalResults.Text = "Results";
            // 
            // FormEvaluator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 422);
            this.Controls.Add(this.labelEvalResults);
            this.Controls.Add(this.labelExpression);
            this.Controls.Add(this.listBoxEvaluationResults);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.textBoxExpression);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEvaluator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Expression Evaluator - Gary Wilson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxExpression;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.ListBox listBoxEvaluationResults;
        private System.Windows.Forms.Label labelExpression;
        private System.Windows.Forms.Label labelEvalResults;
    }
}

