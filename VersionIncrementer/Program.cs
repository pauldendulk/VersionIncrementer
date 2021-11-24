using CommandLine;
using System;
using System.Collections.Generic;
using VersionIncrementer.Extensions;

namespace VersionIncrementer
{

    public class Options
    {
        [Option('i', "increment", Required = true, HelpText = "Specifies the type of increment (MAJOR|MINOR|PATCH)")]
        public string Type { get; set; } = default!;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(o =>
                {
                    var increment = IncrementParser.Parse(o.Type);
                    Console.WriteLine($"Increment Type: {increment}");
                })
                .WithNotParsed(HandleParseError);
        }

        private static void HandleParseError(IEnumerable<Error> errors)
        {
            Console.WriteLine("Parse error");

            foreach (var error in errors)
            {
                Console.WriteLine(error.Tag);
            }
        }
    }
}
