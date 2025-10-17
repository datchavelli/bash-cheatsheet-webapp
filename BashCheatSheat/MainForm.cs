using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;

namespace BashCheatsheet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            webView.Dock = DockStyle.Fill;
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.Navigate("https://devhints.io/bash");

            webView.CoreWebView2.NewWindowRequested += (s, e) =>
            {
                e.Handled = true;
                webView.CoreWebView2.Navigate(e.Uri);
            };
        }
    }
}
