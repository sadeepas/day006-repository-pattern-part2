using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyPublisher.Day006
{
    // C#: Decoupled Clean Repository Architecture (Day 6)
    // Category: .NET Core & Clean Architecture | Difficulty: Advanced

    public record ExecutionRecord(int Id, string Topic, DateTime Timestamp);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C#: Decoupled Clean Repository Architecture (Day 6) ===");
            var records = new List<ExecutionRecord>
            {
                new(1, "C#: Decoupled Clean Repository Architecture (Day 6)", DateTime.UtcNow),
                new(2, "Optimized Pipeline Execution", DateTime.UtcNow)
            };

            foreach (var rec in records)
            {
                Console.WriteLine($"* [{rec.Id}] {rec.Topic} (UTC: {rec.Timestamp})");
            }
        }
    }
}
