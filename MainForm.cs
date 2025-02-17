using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StappenplanApplicatie;

namespace BeschrijvingMaken
{
    public partial class MainForm : Form
    {
        private ActionRecorder actionRecorder;
        public MainForm()
        {
            InitializeComponent();
            actionRecorder = new ActionRecorder();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            actionRecorder.StartRecording();
            MessageBox.Show("Recording started");
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            actionRecorder.StopRecording();
            UpdateListView();
            MessageBox.Show("Recording stopped");
        }

        private void UpdateListView()
        {
            ListViewSteps.Items.Clear();
            foreach (var action in actionRecorder.GetActions())
            {
                ListViewSteps.Items.Add(new ListViewItem(action));
            }
        }
    }
}
