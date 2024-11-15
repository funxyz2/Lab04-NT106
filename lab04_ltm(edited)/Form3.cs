using Microsoft.Web.WebView2.Core;
using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace lab04_ltm_edited_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            userAgentComboBox.Items.AddRange(new string[]
            {
                "Mozilla/5.0 (X11; CrOS x86_64 10066.0.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/130.0.0.0 Safari/537.36",
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/13.0.3 Safari/605.1.15",
                "Mozilla/5.0 (Linux; U; Android 4.0.2; en-us; Galaxy Nexus Build/ICL53F) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 Mobile Safari/534.30"
            });
            userAgentComboBox.SelectedIndex = 0;

            deviceComboBox.Items.AddRange(new string[]
            {
                "Desktop - 1920x1080",
                "Tablet - 768x1024",
                "Mobile - 375x667"
            });
            deviceComboBox.SelectedIndex = 0;

            // Tạo CoreWebView2Environment với User-Agent ban đầu
            var env = await CoreWebView2Environment.CreateAsync(null, null, new CoreWebView2EnvironmentOptions
            {
                AdditionalBrowserArguments = $"--user-agent=\"{userAgentComboBox.SelectedItem}\""
            });
            await webView.EnsureCoreWebView2Async(env);
        }

        private void SetUserAgent(string userAgent)
        {
            if (webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Settings.UserAgent = userAgent;
                webView.Reload();
            }
        }

        private void userAgentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUserAgent = userAgentComboBox.SelectedItem.ToString();
            SetUserAgent(selectedUserAgent);
        }

        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (deviceComboBox.SelectedItem.ToString())
            {
                case "Desktop - 1920x1080":
                    webView.Width = 1920;
                    webView.Height = 1080;
                    break;
                case "Tablet - 768x1024":
                    webView.Width = 768;
                    webView.Height = 1024;
                    break;
                case "Mobile - 375x667":
                    webView.Width = 375;
                    webView.Height = 667;
                    break;
            }

            this.Width = webView.Width + 40;
            this.Height = webView.Height + 100;
        }

        private void WebBrowser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(urlTextBox.Text))
            {
                string url = urlTextBox.Text;
                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    url = "http://" + url;
                }

                // Kiểm tra tính hợp lệ của URL
                if (Uri.TryCreate(url, UriKind.Absolute, out Uri result))
                {
                    webView.CoreWebView2.Navigate(result.ToString());
                }
                else
                {
                    MessageBox.Show("URL không hợp lệ. Vui lòng thử lại.", "Lỗi URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Form3_Resize_1(object sender, EventArgs e)
        {

        }

        private void webView_Click(object sender, EventArgs e)
        {

        }

        private void userAgentComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void toolPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu webView21 đã được khởi tạo
            if (webView == null || webView.CoreWebView2 == null)
            {
                MessageBox.Show("WebView chưa sẵn sàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tải trang trắng (about:blank) để xóa nội dung hiển thị
            webView.CoreWebView2.Navigate("about:blank");

            urlTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
