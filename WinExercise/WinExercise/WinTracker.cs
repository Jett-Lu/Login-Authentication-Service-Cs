using System;
using System.Windows.Forms;

namespace WinExercise
{
    public partial class WinTracker : Form
    {
        // Change #4: Change the constructor to use a callback function
        private readonly Action<int> _updateProgressBar;

        public WinTracker(Action<int> updateProgressBar)
        {
            InitializeComponent();
            _updateProgressBar = updateProgressBar;

            // Change #6: Move the event subscription to tbMaster_Scroll outside of the constructor
            tbMaster.Scroll += tbMaster_Scroll;
        }

        // Change #6: Add the event handler for tbMaster_Scroll
        private void tbMaster_Scroll(object sender, EventArgs e)
        {
            _updateProgressBar(tbMaster.Value);
        }
    }
}