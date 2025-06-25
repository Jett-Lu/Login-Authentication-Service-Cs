using System;
using System.Windows.Forms;

namespace WinExercise
{
    public partial class WinExerciseForm : Form
    {
        // Change #8: Replace m_tracker with a private property named Tracker
        private WinTracker Tracker { get; set; }

        public WinExerciseForm()
        {
            InitializeComponent();

            // Change #8: Use the property Tracker instead of m_tracker
            Tracker = new WinTracker(UpdateProgressBar);
            Tracker.FormClosed += (sender, e) => Tracker = null;
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            // Change #1: Replace dummy argument with discard (_)
            btnCalculate.Enabled = int.TryParse(txtNumber.Text, out _);
        }

        // Change #2: Combine ComputeSquare and ComputeCube into a single function
        private (int Square, int Cube) Compute(int num)
        {
            return (num.Square(), num.Cube());
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int square, cube;
            lblSquareValue.Text = lblCubeValue.Text = string.Empty;

            // Change #2: Use the Compute function
            (square, cube) = Compute(Convert.ToInt32(txtNumber.Text));

            lblSquareValue.Text = square.ToString();
            lblCubeValue.Text = cube.ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Change #3: Replace string.Format with string interpolation
            lblMessage.Text = txtFirstName.Text.Trim().Length > 0 || txtLastName.Text.Trim().Length > 0
                ? $"My name is {txtFirstName.Text.Trim()} {txtLastName.Text.Trim()} and I approve this application."
                : string.Empty;
        }

        private void btnShowSlider_Click(object sender, EventArgs e)
        {
            // Change #7: Use null-conditional operator
            Tracker?.Show(this);
        }

        // Change #9: Use extension methods for Square and Cube
        private void UpdateProgressBar(int value)
        {
            pbEcho.Value = value;
        }
    }

    // Change #9: Add extension methods for Square and Cube
    public static class IntExtensions
    {
        public static int Square(this int num) => num * num;
        public static int Cube(this int num) => num * num * num;
    }
}