namespace Loupedeck.SketchPlugin
{
    using System;

    // This class implements an example adjustment that counts the rotation ticks of a dial.

    public class HorizontalAdjustment : PluginDynamicAdjustment
    {
        private SketchPlugin SketchPlugin => this.Plugin as SketchPlugin;        // Initializes the command class.

        // Initializes the adjustment class.
        // When `hasReset` is set to true, a reset command is automatically created for this adjustment.
        public HorizontalAdjustment()
            : base(displayName: "Horizontal Movement", description: "Move cursor horizontally", groupName: "Adjustments", hasReset: false)
        {
        }

        // This method is called when the adjustment is executed.
        protected override void ApplyAdjustment(String actionParameter, Int32 diff)
        {
            this.SketchPlugin.GetServer().SendMoveCursor(diff, 0);
            this.AdjustmentValueChanged(); // Notify the plugin service that the adjustment value has changed.
        }

        // This method is called when the reset command related to the adjustment is executed.
        // protected override void RunCommand(String actionParameter)
        // {
        //     this._value = 0; // Reset the counter.
        //     this.AdjustmentValueChanged(); // Notify the plugin service that the adjustment value has changed.
        // }

        // Returns the adjustment value that is shown next to the dial.
        // protected override String GetAdjustmentValue(String actionParameter) => this._value.ToString();
    }
}
