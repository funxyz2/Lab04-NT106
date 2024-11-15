using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04_ltm_edited_
{
    public partial class Form4 : Form
    {
        // Tạo một HttpClient để gọi API
        private static readonly HttpClient client = new HttpClient();

        public Form4()
        {
            InitializeComponent();
        }

        private async void btnLoadData_Click(object sender, EventArgs e)
        {
            await LoadPhotos();
            await LoadComments();
            await LoadUsers();
        }

        // Phương thức để tải và hiển thị danh sách ảnh
        private async Task LoadPhotos()
        {
            string url = "https://jsonplaceholder.typicode.com/photos";
            string response = await client.GetStringAsync(url);
            var photos = JsonConvert.DeserializeObject<List<Photo>>(response);

            listBoxPhotos.Items.Clear();
            foreach (var photo in photos.GetRange(0, 100)) // Lấy 100 ảnh đầu tiên
            {
                listBoxPhotos.Items.Add($"ID: {photo.Id} - Title: {photo.Title}");
            }
        }

        // Phương thức để tải và hiển thị danh sách bình luận
        private async Task LoadComments()
        {
            string url = "https://jsonplaceholder.typicode.com/comments";
            string response = await client.GetStringAsync(url);
            var comments = JsonConvert.DeserializeObject<List<Comment>>(response);

            listBoxComments.Items.Clear();
            foreach (var comment in comments.GetRange(0, 100)) // Lấy 100 bình luận đầu tiên
            {
                listBoxComments.Items.Add($"ID: {comment.Id} - Body: {comment.Body}");
            }
        }

        // Phương thức để tải và hiển thị danh sách người dùng
        private async Task LoadUsers()
        {
            string url = "https://jsonplaceholder.typicode.com/users";
            string response = await client.GetStringAsync(url);
            var users = JsonConvert.DeserializeObject<List<User>>(response);

            listBoxUsers.Items.Clear();
            foreach (var user in users.GetRange(0, 10)) // Lấy 10 người dùng đầu tiên
            {
                listBoxUsers.Items.Add($"ID: {user.Id} - Name: {user.Name}");
            }
        }
    }
    public class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
