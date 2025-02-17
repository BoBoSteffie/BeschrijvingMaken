using System;
using System.Collections.Generic;
using Gma.System.MouseKeyHook;

namespace StappenplanApplicatie
{
    public class ActionRecorder
    {
        private IKeyboardMouseEvents globalHook;
        private List<string> actions;

        public ActionRecorder()
        {
            actions = new List<string>();
        }

        public void StartRecording()
        {
            globalHook = Hook.GlobalEvents();
            globalHook.MouseClick += GlobalHook_MouseClick;
            globalHook.KeyPress += GlobalHook_KeyPress;
        }

        public void StopRecording()
        {
            if (globalHook != null)
            {
                globalHook.MouseClick -= GlobalHook_MouseClick;
                globalHook.KeyPress -= GlobalHook_KeyPress;
                globalHook.Dispose();
                globalHook = null;
            }
        }

        private void GlobalHook_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            actions.Add($"Mouse clicked at ({e.X}, {e.Y})");
        }

        private void GlobalHook_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            actions.Add($"Key pressed: {e.KeyChar}");
        }

        public List<string> GetActions()
        {
            return actions;
        }
    }
}