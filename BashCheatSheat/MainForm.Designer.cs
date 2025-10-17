namespace BashCheatsheet
{
    partial class MainForm
    {
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing && (webView != null))
            {
                webView.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.SuspendLayout();
            // 
            // webView
            // 
            // webView
            this.webView.CreationProperties = null;
            this.webView.Name = "webView";
            this.webView.TabIndex = 0;
            this.webView.Dock = System.Windows.Forms.DockStyle.Fill; //  leave this

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.webView);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bash Cheatsheet";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
