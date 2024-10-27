using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Group2_Lab02
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void BtnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.Title = "Select Input File";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);
                        txtInput.Text = string.Join(Environment.NewLine, lines);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save Output File";
                    saveFileDialog.DefaultExt = "txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, txtOutput.Text);
                        MessageBox.Show("Results saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static float Calculate(float a, float b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return b != 0 ? a / b : throw new DivideByZeroException("Division by zero");
                default: throw new InvalidOperationException($"Unknown operator: {op}");
            }
        }

        static int Priority(char op)
        {
            switch (op)
            {
                case '+':
                case '-': return 1;
                case '*':
                case '/': return 2;
                case '(': return 0;
                default: return -1;
            }
        }

        private float Process(string expression)
        {
            Stack<float> nums = new Stack<float>();
            Stack<char> ops = new Stack<char>();
            StringBuilder number = new StringBuilder();

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (char.IsDigit(ch) || ch == '.')
                {
                    number.Append(ch);
                }
                else
                {
                    if (number.Length > 0)
                    {
                        nums.Push(float.Parse(number.ToString()));
                        number.Clear();
                    }

                    if (ch == '(')
                    {
                        ops.Push(ch);
                    }
                    else if (ch == ')')
                    {
                        while (ops.Count > 0 && ops.Peek() != '(')
                        {
                            ApplyOperation(nums, ops);
                        }
                        if (ops.Count > 0) ops.Pop();
                    }
                    else if ("+-*/".Contains(ch))
                    {
                        while (ops.Count > 0 && Priority(ch) <= Priority(ops.Peek()))
                        {
                            ApplyOperation(nums, ops);
                        }
                        ops.Push(ch);
                    }
                }
            }

            if (number.Length > 0)
            {
                nums.Push(float.Parse(number.ToString()));
            }

            while (ops.Count > 0)
            {
                ApplyOperation(nums, ops);
            }

            return nums.Count == 1 ? nums.Pop() : throw new InvalidOperationException("Expression could not be fully evaluated.");
        }

        private void ApplyOperation(Stack<float> nums, Stack<char> ops)
        {
            if (nums.Count < 2 || ops.Count == 0)
                throw new InvalidOperationException("Not enough operands for operation.");

            float b = nums.Pop();
            float a = nums.Pop();
            char op = ops.Pop();
            nums.Push(Calculate(a, b, op));
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lines = txtInput.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                List<string> results = new List<string>();

                foreach (string line in lines)
                {
                    string trimmedLine = line.Trim();
                    if (!string.IsNullOrEmpty(trimmedLine))
                    {
                        float result = Process(trimmedLine);
                        results.Add($"{trimmedLine} = {result}");
                    }
                }

                txtOutput.Text = string.Join(Environment.NewLine, results);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
