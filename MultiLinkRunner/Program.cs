using System.Diagnostics;


while (true) // loop until user quits
{

    List<string> validLinks = new List<string>();
    Console.WriteLine("Enter the path of the text file Or Type L to load and open saved links");
    string filePath = "";

    string chosenOption = Console.ReadLine();
    if (!chosenOption.ToString().Equals("L") && !chosenOption.ToString().Equals("l"))
    {

        filePath = chosenOption;

    }
    else
    {

        filePath = "SavedLinks.txt";
    }



    if (!File.Exists(filePath))
    {
        Console.WriteLine("File not found!");
        return;
    }

    string[] lines = File.ReadAllLines(filePath);

    foreach (var line in lines)
    {
        string trimmedLine = line.Trim();

        // Check if it's a valid link
        if (trimmedLine.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ||
            trimmedLine.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
        {

            validLinks.Add(trimmedLine);


            /*    try
                {
                    Console.WriteLine($"Opening: {trimmedLine}");
                    Process.Start(new ProcessStartInfo(trimmedLine) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to open {trimmedLine}: {ex.Message}");
                }
        */


        }




    }
    Console.WriteLine("O - open all links now");
    Console.WriteLine("S - save links to open later (Append)");
    Console.WriteLine("F - save links to open later (Clear and Save)");


    chosenOption = Console.ReadLine();
    if (chosenOption.Equals("O") && chosenOption.Equals("o"))
    {


        foreach (var link in validLinks)
        {
            try
            {
                Console.WriteLine($"Opening: {link}");
                Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open {link}: {ex.Message}");
            }
        }
    }

    else if (chosenOption.Equals("F") || chosenOption.Equals("f"))
    {
        string savePath = "SavedLinks.txt";
        File.WriteAllLines(savePath, validLinks);
        Console.WriteLine($"Links saved to {savePath}");
    }
    else if (chosenOption.Equals("S") || chosenOption.Equals("s"))
    {
        string savePath = "SavedLinks.txt";
        File.AppendAllLines(savePath, validLinks);
        Console.WriteLine($"Links saved to {savePath}");
    }
    else
    {
        Console.WriteLine("Invalid option selected.");
    }



    Console.WriteLine("Done! Press R to repeat");

  //  chosenOption = Console.ReadLine();
}

Console.ReadLine();
/*if (chosenOption.ToString().Equals("R") || chosenOption.ToString().Equals("r"))

{


}
else
{

    Console.ReadKey();
}*/


