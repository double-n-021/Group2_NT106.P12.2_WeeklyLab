using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group2_Lab04
{
    public partial class Lab04_Bai04 : Form
    {
        public Lab04_Bai04()
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
        //Lớp LoginResponse lưu trữ phản hồi
        public class LoginResponse
        {
            public bool login { get; set; }
            public string token_type { get; set; }
            public string access_token { get; set; }
            public string detail { get; set; }
        }
    }
}
