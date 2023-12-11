using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ExaminationApplication
{
    public partial class QuestionEditor : Form
    {
        private DataTable questionsTable;
        private MySqlDataAdapter adapter;

        public QuestionEditor(string subject)
        {
            InitializeComponent();
            Grid_Questions(subject);
        }

        private void Grid_Questions(string subject)
        {
            questionsTable = new DataTable();

            DatabaseHandler.connect_database();

            string query = "SELECT * FROM " + subject + "_questions";

            adapter = new MySqlDataAdapter(query, DatabaseHandler.connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

            adapter.Fill(questionsTable);

            DatabaseHandler.disconnect_database();

            dataGridView1.DataSource = questionsTable;
        }

        private void UpdateDatabase()
        {
            try
            {
                DatabaseHandler.connect_database();

                adapter.Update(questionsTable);

                DatabaseHandler.disconnect_database();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RefreshData()
        {
            questionsTable.Clear();
            adapter.Fill(questionsTable);
        }

        private void addButton_Click(object sender, EventArgs e) // Add button
        {
            DataRow newRow = questionsTable.NewRow();
            questionsTable.Rows.Add(newRow);
            UpdateDatabase();
        }

        private void editButton_Click(object sender, EventArgs e) // Edit button
        {
            UpdateDatabase();
        }

        private void removeButton_Click(object sender, EventArgs e) // Remove button
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
                UpdateDatabase();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e) // Refresh button
        {
            RefreshData();
        }
    }
}
