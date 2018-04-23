namespace PreventDeletingControl {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.xrDesignPanel1 = new DevExpress.XtraReports.UserDesigner.XRDesignPanel();
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // xrDesignPanel1
            // 
            this.xrDesignPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xrDesignPanel1.Location = new System.Drawing.Point(0, 0);
            this.xrDesignPanel1.Name = "xrDesignPanel1";
            this.xrDesignPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.xrDesignPanel1.Size = new System.Drawing.Size(426, 293);
            this.xrDesignPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 293);
            this.Controls.Add(this.xrDesignPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xrDesignPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraReports.UserDesigner.XRDesignPanel xrDesignPanel1;
    }
}

