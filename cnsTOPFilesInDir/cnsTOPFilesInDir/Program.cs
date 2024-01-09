using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class DirectoryAnalyzer
{
    private string directoryPath;

    public DirectoryAnalyzer(string path)
    {
        directoryPath = path;
    }

    public void ShowTopFilesBySize(int topCount, bool ascending = false)
    {
        var files = GetFilesBySize(ascending);
        DisplayTopItems("Top Files by Size", files.Take(topCount));
    }

    public void ShowTopFileNames(int topCount)
    {
        var fileNames = GetFileNames();
        DisplayTopItems("Top File Names", fileNames.Take(topCount));
    }

    public void ShowTopExtensions(int topCount)
    {
        var extensions = GetFileExtensions();
        DisplayTopItems("Top File Extensions", extensions.Take(topCount));
    }

    public void ShowTopFilePaths(int topCount)
    {
        var filePaths = GetFilePaths();
        DisplayTopItems("Top File Paths", filePaths.Take(topCount));
    }

    public void ShowTopDirectoryPaths(int topCount)
    {
        var directoryPaths = GetDirectoryPaths();
        DisplayTopItems("Top Directory Paths", directoryPaths.Take(topCount));
    }

    public void ShowTopDirectoriesByFileCount(int topCount)
    {
        var topDirectories = GetTopDirectoriesByFileCount(topCount);
        DisplayTopItems("Top Directories by File Count", topDirectories);
    }

    public void ShowTopDirectoriesBySubdirectoryCount(int topCount)
    {
        var topDirectories = GetTopDirectoriesBySubdirectoryCount(topCount);
        DisplayTopItems("Top Directories by Subdirectory Count", topDirectories);
    }

    private IEnumerable<string> GetFilesBySize(bool ascending = false)
    {
        var files = Directory.GetFiles(directoryPath)
                             .OrderBy(file => new FileInfo(file).Length);
        return ascending ? files : files.Reverse();
    }

    private IEnumerable<string> GetFileNames()
    {
        return Directory.GetFiles(directoryPath).Select(Path.GetFileName);
    }

    private IEnumerable<string> GetFileExtensions()
    {
        return Directory.GetFiles(directoryPath).Select(Path.GetExtension);
    }

    private IEnumerable<string> GetFilePaths()
    {
        return Directory.GetFiles(directoryPath);
    }

    private IEnumerable<string> GetDirectoryPaths()
    {
        return Directory.GetDirectories(directoryPath);
    }

    private Dictionary<string, int> GetTopDirectoriesByFileCount(int topCount)
    {
        var directoryFileCounts = GetDirectoryPaths()
            .ToDictionary(directory => directory, directory => Directory.GetFiles(directory).Length);

        return directoryFileCounts.OrderByDescending(kv => kv.Value)
                                  .Take(topCount)
                                  .ToDictionary(kv => kv.Key, kv => kv.Value);
    }

    private Dictionary<string, int> GetTopDirectoriesBySubdirectoryCount(int topCount)
    {
        var directorySubdirectoryCounts = GetDirectoryPaths()
            .ToDictionary(directory => directory, directory => Directory.GetDirectories(directory).Length);

        return directorySubdirectoryCounts.OrderByDescending(kv => kv.Value)
                                          .Take(topCount)
                                          .ToDictionary(kv => kv.Key, kv => kv.Value);
    }

    private void DisplayTopItems(string title, IEnumerable<string> items)
    {
        Console.WriteLine($"{title}:");

        foreach (var item in items)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }

    private void DisplayTopItems(string title, Dictionary<string, int> items)
    {
        Console.WriteLine($"{title}:");

        foreach (var kv in items)
        {
            Console.WriteLine($"{kv.Key}: {kv.Value} items");
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        string directoryPath = @"..\..\..\..\..\..\MobilApp"; // Change to the desired directory
        DirectoryAnalyzer directoryAnalyzer = new DirectoryAnalyzer(directoryPath);

        int topCount = 5; // Change to the desired number of items in the top lists

        directoryAnalyzer.ShowTopFilesBySize(topCount);
        directoryAnalyzer.ShowTopFileNames(topCount);
        directoryAnalyzer.ShowTopExtensions(topCount);
        directoryAnalyzer.ShowTopFilePaths(topCount);
        directoryAnalyzer.ShowTopDirectoryPaths(topCount);
        directoryAnalyzer.ShowTopDirectoriesByFileCount(topCount);
        directoryAnalyzer.ShowTopDirectoriesBySubdirectoryCount(topCount);
    }
}
