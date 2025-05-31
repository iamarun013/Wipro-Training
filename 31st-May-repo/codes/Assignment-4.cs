using System;
using System.IO;
using System.Threading;

namespace MultithreadingFileProcessor
{
    class Program
    {
        // Shared total line count
        private static int totalLineCount = 0;
        // Lock object for thread safety
        private static readonly object lockObj = new object();

        static void Main(string[] args)
        {
            // File paths (replace with actual large file paths)
            string[] files = {
                "largefile1.txt",
                "largefile2.txt",
                "largefile3.txt"
            };

            Thread[] threads = new Thread[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                string filePath = files[i];
                // Create a thread for each file
                threads[i] = new Thread(() => ReadFileAndCountLines(filePath));
                threads[i].Start();
            }

            // Wait for all threads to complete
            foreach (var thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine($"Total lines across all files: {totalLineCount}");
        }

        // Method to read a file and update total line count
        private static void ReadFileAndCountLines(string filePath)
        {
            int lineCount = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }

                // Lock before updating shared variable
                lock (lockObj)
                {
                    totalLineCount += lineCount;
                }

                Console.WriteLine($"Finished reading {filePath}: {lineCount} lines.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading {filePath}: {ex.Message}");
            }
        }
    }
}