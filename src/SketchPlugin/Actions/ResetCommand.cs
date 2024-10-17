namespace Loupedeck.SketchPlugin
{
    using System;

    // This class implements an example command that counts button presses.

    public class ResetCommand : PluginDynamicCommand
    {
        private SketchPlugin SketchPlugin => this.Plugin as SketchPlugin;        // Initializes the command class.

        // Initializes the command class.
        public ResetCommand()
            : base(displayName: "Reset canvas", description: "Reset Sketch canvas", groupName: "Commands")
        {
        }

        // This method is called when the user executes the command.
        protected override void RunCommand(String actionParameter)
        {
            this.SketchPlugin._server.SendReset();
            PluginLog.Info("Reset Command"); // Write the current counter value to the log file.
            // this.ActionImageChanged(); // Notify the plugin service that the command display name and/or image has changed.
        }

        // This method is called when Loupedeck needs to show the command on the console or the UI.
        protected override String GetCommandDisplayName(String actionParameter, PluginImageSize imageSize) =>
            $"Reset Canvas{Environment.NewLine}";
    }
}
