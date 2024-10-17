namespace Loupedeck.SketchPlugin
{
    using System;

    // This class implements an example command that counts button presses.

    public class DrawCommand : PluginDynamicCommand
    {
        private SketchPlugin SketchPlugin => this.Plugin as SketchPlugin;        // Initializes the command class.
        public DrawCommand()
            : base(displayName: "Draw", description: "Draw a circle at the current position", groupName: "Commands")
        {
        }

        // This method is called when the user executes the command.
        protected override void RunCommand(String actionParameter)
        {
            this.SketchPlugin._server.SendDraw();
            PluginLog.Info("Draw Command"); // Write the current counter value to the log file.
            // this.ActionImageChanged(); // Notify the plugin service that the command display name and/or image has changed.
        }

        // This method is called when Loupedeck needs to show the command on the console or the UI.
        protected override String GetCommandDisplayName(String actionParameter, PluginImageSize imageSize) =>
            $"Draw Segment{Environment.NewLine}";
    }
}
