using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group2_Lab04
{
    public partial class Lab04_Bai05 : Form
    {
        private string access_tokenSaved; //Lưu trữ token sau khi đăng nhập thành công

        public Lab04_Bai05()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string url = "https://nt106.uitiot.vn/auth/token";
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return;
            }

            try
            {
                //Gửi yêu cầu HTTP POST tới API
                var response = await PostAsync(url, username, password);

                //Hiển trị kết quả
                if (response.login)
                {
                    rtbDisplayInfo.Text = $"{response.token_type} {response.access_token}\nĐăng nhập thành công!";
                    access_tokenSaved = response.access_token; //Lưu token vừa đăng nhập vào biến access_tokenSaved
                }
                else
                {
                    rtbDisplayInfo.Text = $"{response.detail}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGET_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(access_tokenSaved))
            {
                return;
            }

            string url = "https://nt106.uitiot.vn/api/v1/user/me";

            try
            {
                var userInfo = await GetAsync(url, access_tokenSaved);
                rtbDisplayInfo.Text = $"Thông tin user:\n{JsonConvert.SerializeObject(userInfo, Formatting.Indented)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private async Task<LoginResponse> PostAsync(string url, string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                //Tạo nội dung body cho HTTP POST
                var form_data = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password)
                });

                //Gửi yêu cầu POST
                HttpResponseMessage response = await client.PostAsync(url, form_data);

                //Đọc phản hồi từ API
                var json_response = await response.Content.ReadAsStringAsync();

                //Nếu phản hồi là thành công, phân tích JSON từ server
                if (response.IsSuccessStatusCode)
                {
                    var data = JsonConvert.DeserializeObject<dynamic>(json_response);
                    return new LoginResponse
                    {
                        login = true,
                        token_type = data.token_type,
                        access_token = data.access_token
                    };
                }
                else
                {
                    //Nếu phản hồi là thất bại, trả về dữ liệu detail từ JSON
                    var error_data = JsonConvert.DeserializeObject<dynamic>(json_response);
                    return new LoginResponse
                    {
                        login = false,
                        detail = error_data.detail
                    };
                }
            }
        }
        private async Task<dynamic> GetAsync(string url, string token)
        {
            using (HttpClient client = new HttpClient())
            {
                //Thêm header authorization với giá trị bearer token (token được sử dụng để xác thực giữa client và server trong JWT)
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                //Gửi yêu cầu GET
                HttpResponseMessage response = await client.GetAsync(url);

                //Đọc phản hồi từ API
                var json_response = await response.Content.ReadAsStringAsync();

                //Nếu phản hồi là thành công, phân tích JSON từ server
                if (response.IsSuccessStatusCode)
                {
                    var data = JsonConvert.DeserializeObject<dynamic>(json_response);
                    return data;
                }
                else
                {
                    //Ném ngoại lệ với thông báo lỗi
                    throw new Exception("Không thể lấy thông tin người dùng.");
                }
            }
        }
        public class LoginResponse
        {
            public bool login { get; set; }
            public string token_type { get; set; }
            public string access_token { get; set; }
            public string detail { get; set; }
        }
    }
}
