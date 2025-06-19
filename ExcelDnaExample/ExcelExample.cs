using ExcelDna.Integration;

namespace MyAddin.Excel
{
    using MyAddin.Example;

    public static class ExcelExample
    {
        private const string Category = "myDates";
        private static Hello hello = new Hello();

        [ExcelFunction(
            Name = "SayHello",
            Description = "Return the date and time as of now.",
            IsVolatile = false,
            Category = Category
        )]
        public static string SayHello
        (
        [ExcelArgument(Name = "[Interval]", Description = "Interval in seconds between refreshes.")] double seconds
        )
        {
            return hello.SayHello;
        }

    }
}