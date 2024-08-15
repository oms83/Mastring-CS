using Newtonsoft.Json; // Make sure you are using Newtonsoft.Json
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Introduction.Serialization
{
    public class Todo
    {
        public Todo(int userId, int id, string title, bool completed)
        {
            this.userId = userId;
            this.id = id;
            this.title = title;
            this.completed = completed;
        }

        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }

    public class Example2
    {
        // shared variable
        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task run()
        {
            var todoes = await httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/todos");
            var TodoesContent = JsonConvert.DeserializeObject<List<Todo>>(todoes);

            // Optional: Print the todos to verify
            foreach (var todo in TodoesContent)
            {
                Console.WriteLine($"{todo.id}: {todo.title} - Completed: {todo.completed}");
            }
        }
    }
}
