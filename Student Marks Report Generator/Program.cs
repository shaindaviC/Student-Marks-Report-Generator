using System;

class StudentMarksReport
{
    static void Main()
    {
        Console.WriteLine("Enter number of students:");
        int n = int.Parse(Console.ReadLine());

        int[] marks = new int[n];

        // 1. Read marks
        Console.WriteLine("\nEnter marks for each student:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Student " + (i + 1) + ": ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        // 2. Display original marks
        Console.WriteLine("\n--- Original Marks ---");
        DisplayArray(marks);

        // 3. Display sorted marks
        int[] sortedMarks = new int[n];
        Array.Copy(marks, sortedMarks, n);
        Array.Sort(sortedMarks);

        Console.WriteLine("\n--- Sorted Marks (Ascending) ---");
        DisplayArray(sortedMarks);

        // 4. Summary statistics
        int total = 0;
        int highest = marks[0];
        int lowest = marks[0];

        for (int i = 0; i < n; i++)
        {
            total += marks[i];
            if (marks[i] > highest) highest = marks[i];
            if (marks[i] < lowest) lowest = marks[i];
        }

        Console.WriteLine("\n--- Summary Statistics ---");
        Console.WriteLine("Total Marks: " + total);
        Console.WriteLine("Highest Mark: " + highest);
        Console.WriteLine("Lowest Mark: " + lowest);

        // 5. Search for a specific mark
        Console.WriteLine("\nEnter a mark to search:");
        int searchMark = int.Parse(Console.ReadLine());

        bool found = false;
        for (int i = 0; i < n; i++)
        {
            if (marks[i] == searchMark)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine(searchMark + " found in the marks data.");
        else
            Console.WriteLine(searchMark + " not found in the marks data.");

        // 6. Backup copy
        int[] backupMarks = new int[n];
        Array.Copy(marks, backupMarks, n);
        Console.WriteLine("\nBackup copy of marks created successfully.");

        // 7. Compare with another set of marks
        Console.WriteLine("\nEnter another set of marks to compare:");
        int[] anotherMarks = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Student " + (i + 1) + ": ");
            anotherMarks[i] = int.Parse(Console.ReadLine());
        }

        bool isEqual = true;
        for (int i = 0; i < n; i++)
        {
            if (marks[i] != anotherMarks[i])
            {
                isEqual = false;
                break;
            }
        }

        Console.WriteLine("\n--- Comparison Result ---");
        if (isEqual)
            Console.WriteLine("Both marks datasets are IDENTICAL.");
        else
            Console.WriteLine("The marks datasets are DIFFERENT.");
    }

    // Function to display array
    static void DisplayArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "  ");
        }
        Console.WriteLine();
    }
}
