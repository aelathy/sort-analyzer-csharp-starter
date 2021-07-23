using System;
using System.IO;

class MainClass {
    public static void Main (string[] args) {
        // Load Data Files into Arrays
        int[] randomData = loadDataArray("data-files/random-values.txt");
        int[] reversedData = loadDataArray("data-files/reversed-values.txt");
        int[] nearlySortedData = loadDataArray("data-files/nearly-sorted-values.txt");
        int[] fewUniqueData = loadDataArray("data-files/few-unique-values.txt");
    }

    // Function to create an array of integers from provided data file
    public static int[] loadDataArray(string fileName) {
        // Read Text File by Line 
        string[] lines = File.ReadAllLines(fileName);

        // Create Array of Integers
        int[] tempData = new int[lines.Length];
        for (int i = 0; i < lines.Length; i++) {
            tempData[i] = Convert.ToInt32(lines[i]);
        }

        // Return Array of Integers
        return tempData;
    }
}