using System;
using Xunit;

namespace FriendlyFhir.XHelpers
{
    public class Helpers
    {
        [Fact]
        public void Test()
        {
        }

        private bool Message(ConsoleColor color, string className, string method, string msg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{className}.{method}: {msg}");
            Console.ForegroundColor = ConsoleColor.Black;
            return true;
        }

        private bool G_StatusInfo(string className, string method, string msg) => Message(ConsoleColor.Red, className, method, msg);
        private bool G_StatusWarnings(string className, string method, string msg) => Message(ConsoleColor.Yellow, className, method, msg);
        private bool G_StatusErrors(string className, string method, string msg) => Message(ConsoleColor.Black, className, method, msg);
    }
}
