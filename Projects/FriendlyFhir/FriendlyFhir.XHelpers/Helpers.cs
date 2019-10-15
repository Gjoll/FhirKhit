using System;
using Xunit;

namespace FriendlyFhir.XHelpers
{
    public class Helpers
    {
        [Fact]
        public void GenerateResourceClasses()
        {
            FriendlyFhirGenerator g = new FriendlyFhirGenerator(@"c:\Temp\FriendlyFhire");
            g.StatusErrors += this.G_StatusErrors;
            g.StatusWarnings += this.G_StatusWarnings;
            g.StatusInfo += this.G_StatusInfo;
            g.GenerateBaseClasses();
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
