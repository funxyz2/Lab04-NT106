using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04_ltm_edited_
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form5_Load);

        }

        private async void Form5_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
        }


        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Browser_Click(object sender, EventArgs e)
        {
            if (txtUrl == null)
            {
                MessageBox.Show("TextBox URL chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (webView21 == null)
            {
                MessageBox.Show("WebView chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(txtUrl.Text))
            {
                string url = txtUrl.Text;
                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                {
                    url = "http://" + url;
                }

                // Kiểm tra tính hợp lệ của URL
                if (Uri.TryCreate(url, UriKind.Absolute, out Uri result))
                {
                    webView21.CoreWebView2.Navigate(result.ToString());
                }
                else
                {
                    MessageBox.Show("URL không hợp lệ. Vui lòng thử lại.", "Lỗi URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cần nhập URL!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Download_Click(object sender, EventArgs e)
        {
            if (txtUrl == null)
            {
                MessageBox.Show("TextBox URL chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (webView21 == null)
            {
                MessageBox.Show("WebView chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (webView21 != null)
            {
                string selectedOption = comboBoxOption.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedOption))
                {
                    MessageBox.Show("Vui lòng chọn một tùy chọn trước khi tải xuống.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy mã nguồn HTML từ WebView2
                string htmlContent = await webView21.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML");
                htmlContent = htmlContent.Trim('"').Replace("\\r\\n", "\r\n").Replace("\\", string.Empty);

                // Mở hộp thoại SaveFileDialog
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Chọn nơi lưu file";
                    saveFileDialog.Filter = "HTML File (*.html)|*.html|All Files (*.*)|*.*";
                    saveFileDialog.FileName = "source.html"; // Tên file mặc định

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Lưu file theo tùy chọn
                        if (selectedOption == "Chỉ file HTML")
                        {
                            File.WriteAllText(filePath, htmlContent);
                            MessageBox.Show($"Mã nguồn HTML đã được tải xuống và lưu vào {filePath}", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (selectedOption == "Toàn bộ mã nguồn")
                        {
                            string folderPath = Path.GetDirectoryName(filePath);
                            Directory.CreateDirectory(folderPath);

                            // Lưu file HTML
                            File.WriteAllText(filePath, htmlContent);
                            MessageBox.Show($"Toàn bộ mã nguồn đã được tải xuống và lưu vào {filePath}", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void View_Click(object sender, EventArgs e)
        {
            // Kiểm tra URL hợp lệ trước khi tiếp tục
            if (string.IsNullOrEmpty(txtUrl.Text) || !Uri.IsWellFormedUriString(txtUrl.Text, UriKind.Absolute))
            {
                MessageBox.Show("Vui lòng nhập URL hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string htmlContent = string.Empty; // Biến lưu mã nguồn HTML

            try
            {
                using (WebClient client = new WebClient())
                {
                    // Tải dữ liệu từ URL
                    byte[] data = client.DownloadData(txtUrl.Text);

                    // Chuyển đổi byte[] thành string (UTF-8)
                    htmlContent = Encoding.UTF8.GetString(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị form mới và truyền dữ liệu HTML
            Bai5_Source newForm = new Bai5_Source(htmlContent);
            newForm.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu webView21 đã được khởi tạo
            if (webView21 == null || webView21.CoreWebView2 == null)
            {
                MessageBox.Show("WebView chưa sẵn sàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tải trang trắng (about:blank) để xóa nội dung hiển thị
            webView21.CoreWebView2.Navigate("about:blank");

            txtUrl.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

