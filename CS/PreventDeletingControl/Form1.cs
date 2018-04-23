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

    public bool CanHandleCommand(ReportCommand command, ref bool useNextHandler) {
        useNextHandler = command != ReportCommand.Delete && !IsXRLabelSelected();
        return !useNextHandler;
    }

    public void HandleCommand(ReportCommand command, object[] args) {
        MessageBox.Show("Cannot delete label!");
    }

    Boolean IsXRLabelSelected() {
        object[] controls = panel.GetSelectedComponents();

        foreach (object obj in controls)
            if (obj is XRLabel)
                return true;

        return false;
    }
}