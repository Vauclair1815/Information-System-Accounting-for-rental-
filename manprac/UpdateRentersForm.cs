﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace manprac
{
    public partial class UpdateRentersForm : Form
    {
        private string ConnString = "Data Source = RentDB; Version=3";
        public UpdateRentersForm()
        {
            InitializeComponent();
        }

        private void UpdateRentersForm_Load(object sender, EventArgs e)
        {
            try
            {
                MainForm main = this.Owner as MainForm;
                ActiveControl = newNameTextBox;
                SQLiteConnection conn = new SQLiteConnection(ConnString);
                conn.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT Name From Renters WHERE ID_Renters = @ID_Renters", conn);
                command.Parameters.AddWithValue("@ID_Renters", main.dataGridRenters.CurrentRow.Cells[0].Value);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    newNameTextBox.Text = reader["Name"].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            newNameTextBox.SelectionStart = 100;
        }

        private void updateRecordButton_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;

            if (newNameTextBox.Text == "")
            {
                MessageBox.Show("Поле пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SQLiteConnection conn = new SQLiteConnection(ConnString);
                conn.Open();
                SQLiteCommand command = new SQLiteCommand("UPDATE [Renters] SET [Name] = @Name WHERE [ID_Renters] = @ID_Renters", conn);
                command.Parameters.AddWithValue("@Name", newNameTextBox.Text);
                command.Parameters.AddWithValue("@ID_Renters", main.dataGridRenters.CurrentRow.Cells[0].Value);
                try
                {
                    command.ExecuteNonQuery();

                    Dictionary<int, string> DebitingRenters = new Dictionary<int, string>();
                    SQLiteCommand loadRentersComboBox = new SQLiteCommand("SELECT ID_Renters, Name FROM Renters", conn);
                    SQLiteDataReader readerRentersComboBox = loadRentersComboBox.ExecuteReader();

                    main.rentersComboBox.Items.Clear();
                    main.rentersComboBox.Items.Add("Все");
                    main.rentersComboBox.SelectedItem = "Все";
                    while (readerRentersComboBox.Read())
                    {
                        DebitingRenters.Add(Convert.ToInt32(readerRentersComboBox["ID_Renters"]), Convert.ToString(readerRentersComboBox["Name"]));
                        main.rentersComboBox.Items.Add(readerRentersComboBox["Name"]);
                    }
                    readerRentersComboBox.Close();
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }

                if (MessageBox.Show("Запись успешно изменена.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    this.Close();
            }

        }

        private void newNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                updateRecordButton_Click(sender, e);
            }
        }

        private void UpdateRentersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            int columnIndex = main.dataGridRenters.CurrentCell.ColumnIndex;
            int rowIndex = main.dataGridRenters.CurrentCell.RowIndex;

            SQLiteConnection conn = new SQLiteConnection(ConnString);
            conn.Open();
            main.dataGridRenters.Rows.Clear();
            SQLiteCommand loadRenters = new SQLiteCommand("SELECT ID_Renters, Name FROM Renters", conn);
            SQLiteDataReader readerRenters = loadRenters.ExecuteReader();
            List<string[]> data = new List<string[]>();

            int count = 1;
            while (readerRenters.Read())
            {

                data.Add(new string[3]);
                data[count - 1][0] = readerRenters["ID_Renters"].ToString();
                data[data.Count - 1][1] = count.ToString();
                data[data.Count - 1][2] = readerRenters["Name"].ToString();
                count++;
            }
            foreach (string[] s in data)
                main.dataGridRenters.Rows.Add(s);

            readerRenters.Close();
            conn.Close();

            main.dataGridRenters.CurrentCell = main.dataGridRenters[columnIndex, rowIndex];
        }
    }
}
