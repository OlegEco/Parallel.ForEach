List<string> urls = new List<string>
{
    "https://jsonplaceholder.typicode.com/posts",
    "https://jsonplaceholder.typicode.com/comments",
    "https://jsonplaceholder.typicode.com/albums"
};

Parallel.ForEach(urls, url =>
{
     Console.WriteLine($"Fetchind data from {url} on thread {Task.CurrentId}");
});
Console.WriteLine("All tasks completed.");
