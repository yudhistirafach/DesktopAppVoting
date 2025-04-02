using EsemkaVote.Config;
using EsemkaVote.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaVote.View
{
    public partial class ReportForm : Form
    {
        private DatabaseConnection _database = new DatabaseConnection();
        private SqlCommand _command;
        private SqlDataAdapter _adapter;
        private SqlDataReader _reader;

        private string _image_path = "D:\\EsemkaVote\\EsemkaVote\\assets\\";
        private string employeeName;

        public ReportForm()
        {   
            InitializeComponent();

            LoadVoteHeader();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadVoteHeader()
        {
            using (SqlConnection connection = _database.GetConnection())
            {
                connection.Open();
                const string query = "SELECT Name, Description FROM [VotingHeader] ORDER BY Name ASC";

                using (_command = new SqlCommand(query, connection))
                {
                    using (_reader = _command.ExecuteReader())
                    {
                        while (_reader.Read())
                        {
                            VoteHeaderCombo.Items.Add(new VotingHeaderModel
                            {
                                Name = _reader["Name"].ToString(),
                                Description = _reader["Description"].ToString(),
                            });
                        }
                    }
                }
            }
        }

        private int GetDataTotalVote(string year)
        {
            using (SqlConnection connection = _database.GetConnection()) 
            {
                connection.Open();
                const string query = @"SELECT [VotingHeader].Name AS HeaderName, COUNT(VotedCandidateId) AS TotalVote FROM [VotingDetail]
                                        INNER JOIN [VotingCandidate] ON [VotingCandidate].Id = [VotingDetail].VotedCandidateId
                                        INNER JOIN [VotingHeader] ON [VotingCandidate].VotingHeaderId = [VotingHeader].Id
                                        WHERE [VotingHeader].Name = @year
                                        GROUP BY [VotingHeader].Name";

                using (_command = new SqlCommand(query, connection))
                {
                    _command.Parameters.AddWithValue("@year", year);

                    using (_reader = _command.ExecuteReader())
                    {
                        int TotalVote = 0;

                        if(_reader.Read())
                        {
                            TotalVote = Convert.ToInt32(_reader["TotalVote"]);
                        }

                        return TotalVote;
                    }
                }
            }
        }

        private void LoadDataVoted(string VoteHeader)
        {
            using (SqlConnection connection = _database.GetConnection())
            {
                connection.Open();
                const string query = @"SELECT [Division].Name AS Name, count(VotedCandidateId) AS TotalVote FROM [VotingDetail]
                                        INNER JOIN [VotingCandidate] ON [VotingCandidate].Id = [VotingDetail].VotedCandidateId
                                        INNER JOIN [VotingHeader] ON [VotingHeader].Id = [VotingCandidate].VotingHeaderId
                                        INNER JOIN [Employee] ON [Employee].Id = [VotingCandidate].EmployeeId
                                        INNER JOIN [Division] ON [Division].Id = [Employee].DivisionId
                                        WHERE [Employee].Name = @EmployeeName
                                        GROUP BY [Division].Name";

                using (_command = new SqlCommand(query, connection))
                {
                    _command.Parameters.AddWithValue("@EmployeeName", employeeName);

                    using (_adapter = new SqlDataAdapter(_command))
                    {
                        DataTable dataTable = new DataTable();
                        _adapter.Fill(dataTable);
                        dataTable.Columns.Add("Percentage", typeof(string));
                        double percent;

                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            percent = ((Convert.ToDouble(dataTable.Rows[i]["TotalVote"]) / GetDataTotalVote(VoteHeader)) * 100);

                            dataTable.Rows[i]["Percentage"] = percent.ToString("F2") + "%";
                        }

                        VoteGridView.DataSource = dataTable;
                        VoteGridView.Columns["Name"].HeaderText = "Division Name";
                        VoteGridView.Columns["TotalVote"].HeaderText = "Vote Count";
                        VoteGridView.Columns["Percentage"].DisplayIndex = 2;
                    }
                }
            }
        }

        private void LoadBestEmployee(string Year)
        {
            using (SqlConnection connection = _database.GetConnection())
            {
                connection.Open();
                const string query = @"SELECT TOP 1 [VotingHeader].Name AS HeaderName, [Employee].Name AS Employee, count(VotedCandidateId) AS TotalVote, [Employee].Photo FROM [VotingDetail]
                                        INNER JOIN [VotingCandidate] ON [VotingDetail].VotedCandidateId = [VotingCandidate].Id
                                        INNER JOIN [Employee] ON [VotingCandidate].EmployeeId = [Employee].id
                                        INNER JOIN [VotingHeader] ON [VotingCandidate].VotingHeaderId = [VotingHeader].Id
                                        WHERE [VotingHeader].Name = @year
                                        GROUP BY [VotingHeader].Name, [Employee].Name, [Employee].Photo
                                        ORDER BY TotalVote DESC
                                        ";

                using (_command = new SqlCommand(query, connection))
                {
                    _command.Parameters.AddWithValue("@year", Year);

                    using (_reader = _command.ExecuteReader())
                    {
                        if (_reader.Read())
                        {
                            employeeName = _reader["Employee"].ToString();
                            string employeeVote = _reader["TotalVote"].ToString();
                            string employeePhoto = _reader["Photo"].ToString();
                            double totalVote = GetDataTotalVote(Year);
                            string imagePath = _image_path + employeePhoto;
                            EmployeeNameLabel.Text = employeeName;
                            EmployeeVoteLabel.Text = employeeVote;
                            TotalVoteLabel.Text = totalVote.ToString();
                            PercentLabel.Text = (Convert.ToDouble(employeeVote) / totalVote * 100).ToString("F2") + "%";

                            if (File.Exists(imagePath)) {
                                EmployeePicture.Image = new Bitmap(imagePath);
                            } else
                            {
                                EmployeePicture.Image = null;
                                MessageBox.Show(this, "Gambar tidak ditemukan!");
                            }
                        }
                    }

                }
            }
        }

        private void LoadReasonBestEmployee()
        {
            using (SqlConnection connection = _database.GetConnection())
            {
                connection.Open();
                const string query = @"SELECT Reason FROM [VotingDetail]
                                        INNER JOIN [VotingCandidate] ON [VotingCandidate].Id = [VotingDetail].VotedCandidateId
                                        INNER JOIN [Employee] ON [Employee].Id = [VotingCandidate].EmployeeId
                                        WHERE [Employee].Name = @EmployeeName AND Reason IS NOT NULL";

                using (_command = new SqlCommand(query, connection))
                {
                    _command.Parameters.AddWithValue("@EmployeeName", employeeName);

                    using (_reader = _command.ExecuteReader())
                    {
                        FlowLayoutReason.Controls.Clear();
                        while( _reader.Read())
                        {
                            string reason = _reader["Reason"].ToString();

                            RichTextBox richTextBox = new RichTextBox
                            {
                                Width = 237,
                                Height = 192,
                                ReadOnly = true,
                                Text = reason,
                                BorderStyle = BorderStyle.FixedSingle,
                            };

                            FlowLayoutReason.Controls.Add(richTextBox);
                        }
                    }
                }
            }
        }

        private void VoteHeaderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VoteHeaderCombo.SelectedItem is VotingHeaderModel seletedItem)
            {
                DescriptionText.TextAlign = ContentAlignment.MiddleCenter;
                TitleLabel.Text = seletedItem.Name;
                DescriptionText.Text = seletedItem.Description;

                LoadBestEmployee(VoteHeaderCombo.SelectedItem.ToString());
                LoadDataVoted(VoteHeaderCombo.SelectedItem.ToString());
                LoadReasonBestEmployee();
            }
        }
    }
}
