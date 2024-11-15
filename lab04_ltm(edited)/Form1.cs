using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace lab04_ltm_edited_
{
    public partial class Form1 : Form
    {
        public string htmlcontent = string.Empty; // Biến lưu mã nguồn HTML

        public Form1()
        {
            InitializeComponent();

            /*// Đặt DataGridView chiếm hết Form
            dgvHeaders.Dock = DockStyle.Fill;

            // Đặt TextBox nằm ở phía trên của Form
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Đặt Button ở góc phải, phía dưới
            btnLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDownLoad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
*/
            // Cấu hình DataGridView cho các header
            dgvHeaders.ColumnCount = 3;
            dgvHeaders.Columns[0].Name = "STT";
            dgvHeaders.Columns[1].Name = "Header";
            dgvHeaders.Columns[2].Name = "Value";
            dgvHeaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();

            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Vui lòng nhập URL hợp lệ.");
                return;
            }

            // Kiểm tra và thêm "http://" nếu người dùng không nhập
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }

            try
            {
                using (WebClient client = new WebClient())
                {
                    // Tải dữ liệu dưới dạng byte[]
                    byte[] data = client.DownloadData(url);

                    // Chuyển đổi byte[] thành string (UTF-8) và lưu vào htmlcontent
                    htmlcontent = Encoding.UTF8.GetString(data);
                    rtbHtmlContent.Text = htmlcontent; // Hiển thị nội dung HTML trong RichTextBox

                    // Hiển thị headers trong DataGridView
                    dgvHeaders.Rows.Clear(); // Xóa dữ liệu cũ
                    if (client.ResponseHeaders != null)
                    {
                        int index = 1;
                        foreach (var header in client.ResponseHeaders.AllKeys)
                        {
                            string headerName = header;
                            string headerValue = client.ResponseHeaders[header];
                            dgvHeaders.Rows.Add(index, headerName, headerValue);
                            index++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không nhận được header nào từ máy chủ.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi, bạn hãy thử lại!");
            }
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            // Nếu chưa load URL thì htmlcontent sẽ null, yêu cầu load trước
            if (string.IsNullOrEmpty(htmlcontent))
            {
                MessageBox.Show("Bạn chưa load website nào, hãy load rồi download nhé!");
                return; // Dừng hàm nếu htmlcontent rỗng
            }

            // Tải file HTML dùng SaveFileDialog
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Filter 
                saveFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                saveFileDialog.Title = "Lưu mã nguồn HTML";
                saveFileDialog.FileName = "downloadedWebsite.html";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Ghi mã nguồn HTML vào file được chọn
                        File.WriteAllText(saveFileDialog.FileName, htmlcontent);
                        MessageBox.Show("File đã được tải thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!");
                    }
                }
            }
        }
    }
}
