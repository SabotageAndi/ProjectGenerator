using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ProjectGenerator.Tests
{
    public class TestHelper
    {
        public static string CreateDirectoryAndIfNeededCleanIt([CallerMemberName] string testName = null)
        {
            string testProjectPath = Path.Combine(Environment.CurrentDirectory, "TestRun", testName ?? "Test");

            if (Directory.Exists(testProjectPath))
            {
                Console.WriteLine($"Deleting {testProjectPath}");
                
                Directory.Delete(testProjectPath, true);
            }

            return testProjectPath;
        }
    }
}
