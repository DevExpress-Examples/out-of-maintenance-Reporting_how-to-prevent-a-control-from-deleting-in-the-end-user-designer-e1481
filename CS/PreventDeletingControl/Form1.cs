using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
// ...


namespace PreventDeletingControl {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.xrDesignPanel1.AddCommandHandler(new DeleteCommandHandler(this.xrDesignPanel1));
            // Load a report into the design form and show the form.
            this.xrDesignPanel1.OpenReport(new XtraReport1());
        }
    }
}

public class DeleteCommandHandler : ICommandHandler {
    XRDesignPanel panel;

    public DeleteCommandHandler(XRDesignPanel panel) {
        this.panel = panel;
    }

    public virtual void HandleCommand(ReportCommand command, object[] args, ref bool handled) {
        if (!CanHandleCommand(command)) return;

        object[] controls = panel.GetSelectedComponents();

        foreach (object obj in controls) {
            if (obj.GetType() == typeof(XRLabel)) {
                MessageBox.Show("Cannot delete label!");
                handled = true;
            }
        }
    }

    public virtual bool CanHandleCommand(ReportCommand command) {
        return command == ReportCommand.Delete;
    }

}