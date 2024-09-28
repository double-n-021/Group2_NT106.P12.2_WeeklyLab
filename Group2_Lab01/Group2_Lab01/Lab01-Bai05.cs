using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2_Lab01
{
    public partial class Bai05 : Form
    {
        private List<Candidate> candidates = new List<Candidate>();
        private int ID = 1;

        public Bai05()
        {
            InitializeComponent();
            InitializeDataGridView();
            candidateList.CellContentClick += candidateList_CellContentClick;
            btnDelete.Click += btnDelete_Click;
        }

        private void InitializeDataGridView()
        {
            candidateList.Columns.Clear();

            candidateList.Columns.Add("ID", "ID");
            candidateList.Columns.Add("Name", "Họ và tên");

            DataGridViewComboBoxColumn sexColumn = new DataGridViewComboBoxColumn();
            sexColumn.Name = "Sex";
            sexColumn.HeaderText = "Phái";
            sexColumn.Items.AddRange(new string[] { "Nam", "Nữ" });
            candidateList.Columns.Add(sexColumn);

            candidateList.Columns.Add("Score1", "Điểm 1");
            candidateList.Columns.Add("Score2", "Điểm 2");
            candidateList.Columns.Add("Score3", "Điểm 3");
            candidateList.Columns.Add("Average", "Trung bình");

            DataGridViewComboBoxColumn rankColumn = new DataGridViewComboBoxColumn();
            rankColumn.Name = "Rank";
            rankColumn.HeaderText = "Xếp loại";
            rankColumn.Items.AddRange(new string[] { "Giỏi", "Khá", "Trung Bình", "Yếu", "Kém" });
            candidateList.Columns.Add(rankColumn);

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "Xóa";
            deleteButton.UseColumnTextForButtonValue = true;
            candidateList.Columns.Add(deleteButton);
        }

        private void Bai05_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();

            chooseSex.Items.Clear();
            chooseSex.Items.AddRange(new string[] { "Nam", "Nữ" });
            chooseSex.SelectedIndex = 0;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length > 30)
            {
                MessageBox.Show("Họ và tên không hợp lệ (tối đa 30 ký tự)!");
                return false;
            }

            if (chooseSex.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return false;
            }

            if (!float.TryParse(txtScore1.Text, out float score1) || score1 < 0 || score1 > 10 ||
                !float.TryParse(txtScore2.Text, out float score2) || score2 < 0 || score2 > 10 ||
                !float.TryParse(txtScore3.Text, out float score3) || score3 < 0 || score3 > 10)
            {
                MessageBox.Show("Điểm không hợp lệ. Hãy nhập lại!");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                string id = $"TS{ID:D3}";
                string name = txtName.Text;
                string sex = chooseSex.SelectedItem.ToString();
                float score1 = (float)Math.Round(float.Parse(txtScore1.Text), 1);
                float score2 = (float)Math.Round(float.Parse(txtScore2.Text), 1);
                float score3 = (float)Math.Round(float.Parse(txtScore3.Text), 1);

                Candidate candidate = new Candidate(id, name, sex, score1, score2, score3);
                candidates.Add(candidate);

                if (candidateList.Columns.Count == 0)
                {
                    InitializeDataGridView();
                }

                int rowIndex = candidateList.Rows.Add(candidate.ID, candidate.Name, candidate.Sex,
                    candidate.Score1, candidate.Score2, candidate.Score3,
                    candidate.AverageScore, candidate.Rank);

                // Gán giá trị vào cột giới tính (ComboBox)
                DataGridViewComboBoxCell sexCell = (DataGridViewComboBoxCell)candidateList.Rows[rowIndex].Cells["Sex"];
                sexCell.Value = candidate.Sex;

                // Gán giá trị vào cột xếp loại (ComboBox)
                DataGridViewComboBoxCell rankCell = (DataGridViewComboBoxCell)candidateList.Rows[rowIndex].Cells["Rank"];
                rankCell.Value = candidate.Rank;

                ID++;

                MessageBox.Show("Thí sinh đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void candidateList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == candidateList.Columns["Delete"].Index)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thí sinh này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string id = candidateList.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                    // Xóa khỏi danh sách candidates
                    Candidate candidateToRemove = candidates.FirstOrDefault(c => c.ID == id);
                    if (candidateToRemove != null)
                    {
                        candidates.Remove(candidateToRemove);
                    }

                    // Xóa khỏi DataGridView
                    candidateList.Rows.RemoveAt(e.RowIndex);

                    MessageBox.Show("Đã xóa thí sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            int totalCandidates = candidates.Count;
            string topCandidate = candidates.OrderByDescending(c => c.AverageScore).FirstOrDefault()?.Name ?? "Không có";
            int excellentCount = candidates.Count(c => c.Rank == "Giỏi");
            int goodCount = candidates.Count(c => c.Rank == "Khá");
            int averageCount = candidates.Count(c => c.Rank == "Trung Bình");
            int failCount = candidates.Count(c => c.Rank == "Yếu" || c.Rank == "Kém");

            string message = $"Tổng số thí sinh: {totalCandidates}\n" +
                             $"Thí sinh có điểm trung bình cao nhất: {topCandidate}\n" +
                             $"Số lượng thí sinh xếp loại Giỏi: {excellentCount}\n" +
                             $"Số lượng thí sinh xếp loại Khá: {goodCount}\n" +
                             $"Số lượng thí sinh xếp loại Trung Bình: {averageCount}\n" +
                             $"Số lượng thí sinh không đạt: {failCount}";

            MessageBox.Show(message, "Thống kê");
        }

        public class Candidate
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Sex { get; set; }
            public float Score1 { get; set; }
            public float Score2 { get; set; }
            public float Score3 { get; set; }
            public float AverageScore { get; set; }
            public string Rank { get; set; }

            private void CalculateOverallAndRank()
            {
                AverageScore = (float)Math.Round((Score1 + Score2 + Score3) / 3, 2);

                if (AverageScore >= 8 && Score1 >= 6.5 && Score2 >= 6.5 && Score3 >= 6.5)
                    Rank = "Giỏi";
                else if (AverageScore >= 6.5 && Score1 >= 5 && Score2 >= 5 && Score3 >= 5)
                    Rank = "Khá";
                else if (AverageScore >= 5 && Score1 >= 3.5 && Score2 >= 3.5 && Score3 >= 3.5)
                    Rank = "Trung Bình";
                else if (AverageScore >= 3.5 && Score1 >= 2 && Score2 >= 2 && Score3 >= 2)
                    Rank = "Yếu";
                else
                    Rank = "Kém";
            }

            public Candidate(string id, string name, string sex, float score1, float score2, float score3)
            {
                ID = id;
                Name = name;
                Sex = sex;
                Score1 = score1;
                Score2 = score2;
                Score3 = score3;
                CalculateOverallAndRank();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (candidateList.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa thí sinh đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in candidateList.SelectedRows)
                    {
                        string id = row.Cells["ID"].Value.ToString();

                        // Xóa khỏi danh sách candidates
                        Candidate candidateToRemove = candidates.FirstOrDefault(c => c.ID == id);
                        if (candidateToRemove != null)
                        {
                            candidates.Remove(candidateToRemove);
                        }

                        // Xóa khỏi DataGridView
                        candidateList.Rows.Remove(row);
                    }

                    MessageBox.Show("Đã xóa thí sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thí sinh cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
