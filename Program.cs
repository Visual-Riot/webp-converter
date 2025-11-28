using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Use the folder where you run "dotnet run" (your project folder)
        string basePath = Directory.GetCurrentDirectory();

        string inputFolder = Path.Combine(basePath, "_input");
        string outputFolder = Path.Combine(basePath, "_output");

        Directory.CreateDirectory(inputFolder);
        Directory.CreateDirectory(outputFolder);

        Console.WriteLine($"Input folder:  {inputFolder}");
        Console.WriteLine($"Output folder: {outputFolder}");

        var encoder = new WebpEncoder { Quality = 80 };

        var files = Directory.GetFiles(inputFolder)
                             .Where(f =>
                                 f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                 f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                 f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase))
                             .ToList();

        if (files.Count == 0)
        {
            Console.WriteLine("No PNG/JPG files found in the input folder.");
            return;
        }

        foreach (var file in files)
        {
            using var image = Image.Load(file);
            string outPath = Path.Combine(
                outputFolder,
                Path.GetFileNameWithoutExtension(file) + ".webp"
            );

            image.Save(outPath, encoder);
            Console.WriteLine($"Converted: {Path.GetFileName(file)}");
        }

        Console.WriteLine("Done!");
    }
}
