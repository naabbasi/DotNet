namespace CSharpCore.Lessons
{
    internal class AsyncSample
    {
        public static async Task<string> getAsyncString()
        {
            var result = await Task.FromResult("Noman Ali");
            return result;
        }
    }
}
