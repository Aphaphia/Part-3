using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Part3
{
    public static class DatabaseHelper
    {
        // Change 'root123' to your MySQL password
        private static string connectionString = "Server=localhost;Database=cybersecurity_db;User ID=root;Password=root123;";

        // Sets up the database and creates the tasks table if it does not exist
        public static void Initialise()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string createDb = "CREATE DATABASE IF NOT EXISTS cybersecurity_db;";
                MySqlCommand dbCmd = new MySqlCommand(createDb, connection);
                dbCmd.ExecuteNonQuery();

                connection.Close();
                connection.Open();

                string createTable = @"
                    CREATE TABLE IF NOT EXISTS tasks (
                        Id INT AUTO_INCREMENT PRIMARY KEY,
                        Title VARCHAR(200) NOT NULL,
                        Description VARCHAR(500),
                        Reminder VARCHAR(200),
                        IsCompleted BOOLEAN DEFAULT FALSE
                    );";

                MySqlCommand tableCmd = new MySqlCommand(createTable, connection);
                tableCmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database error: " + ex.Message);
            }
        }

        // Adds a new task to the database
        public static bool AddTask(string title, string description, string reminder)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string sql = "INSERT INTO tasks (Title, Description, Reminder) VALUES (@Title, @Description, @Reminder);";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Reminder", reminder);
                cmd.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding task: " + ex.Message);
                return false;
            }
        }

        // Gets all tasks from the database
        public static List<TaskItem> GetAllTasks()
        {
            List<TaskItem> tasks = new List<TaskItem>();

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string sql = "SELECT Id, Title, Description, Reminder, IsCompleted FROM tasks;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TaskItem task = new TaskItem();
                    task.Id = reader.GetInt32("Id");
                    task.Title = reader.GetString("Title");
                    task.Description = reader.GetString("Description");
                    task.Reminder = reader.GetString("Reminder");
                    task.IsCompleted = reader.GetBoolean("IsCompleted");
                    tasks.Add(task);
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting tasks: " + ex.Message);
            }

            return tasks;
        }

        // Marks a task as completed
        public static bool CompleteTask(int taskId)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string sql = "UPDATE tasks SET IsCompleted = TRUE WHERE Id = @Id;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Id", taskId);
                cmd.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error completing task: " + ex.Message);
                return false;
            }
        }

        // Deletes a task from the database
        public static bool DeleteTask(int taskId)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string sql = "DELETE FROM tasks WHERE Id = @Id;";
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Id", taskId);
                cmd.ExecuteNonQuery();

                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting task: " + ex.Message);
                return false;
            }
        }
    }

    // Represents a single task
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Reminder { get; set; } = "";
        public bool IsCompleted { get; set; } = false;
    }
}