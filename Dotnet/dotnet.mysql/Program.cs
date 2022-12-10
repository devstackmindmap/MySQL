// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// var connString = "Server=myserver;User ID=mylogin;Password=mypass;Database=mydatabase";

// using (var conn = new MySqlConnection(connString))
// {
//     await conn.OpenAsync();

//     // Insert some data
//     using (var cmd = new MySqlCommand())
//     {
//         cmd.Connection = conn;
//         cmd.CommandText = "INSERT INTO data (some_field) VALUES (@p)";
//         cmd.Parameters.AddWithValue("p", "Hello world");
//         await cmd.ExecuteNonQueryAsync();
//     }

//     // Retrieve all rows
//     using (var cmd = new MySqlCommand("SELECT some_field FROM data", conn))
//     using (var reader = await cmd.ExecuteReaderAsync())
//         while (await reader.ReadAsync())
//             Console.WriteLine(reader.GetString(0));
// }