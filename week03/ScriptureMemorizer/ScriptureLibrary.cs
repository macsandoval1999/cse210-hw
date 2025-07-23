public class ScriptureLibrary
// This class manages a collection of Scriptures, allowing loading from a file and retrieving random Scriptures.
{
    // ----------Member Variables----------
    private List<Scripture> _scriptures = new List<Scripture>(); // List to hold Scripture objects

    // ----------Methods----------
    public void LoadScripturesFromFile(string filename)
    // Function to load Scriptures from a specified file. As it iterates through each line, lines are split into parts to create Scripture objects, then stored in the _scriptures list.
    // Each line in the file should contain a reference and text, formatted as: <book>,<chapter>,<verse>,<text>, optional <verseEnd>
    // PARAMETERS: filename - The path to the file containing Scripture data
    // RETURNS: void
    {
        // Read all lines from the specified file and store them in an array of strings.
        string[] lines = File.ReadAllLines(filename);

        // Loop through each line in the file
        foreach (string line in lines)
        {
            // Split the line into parts
            string[] parts = line.Split(',');
            // Path for lines with 4 parts: <book>,<chapter>,<verse>,<text>
            if (parts.Length == 4)
            {
                // Create a new Reference object, and assign parts to complete the reference object
                Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                // Create a new Scripture object and assign the reference and the text part to finish the scripture object
                Scripture scripture = new Scripture(reference, parts[3]);
                // Add the Scripture object to the list
                _scriptures.Add(scripture);
            }
            // Path for lines with 5 parts: <book>,<chapter>,<verse>,<verseEnd>,<text>
            else if (parts.Length == 5)
            {
                // Create a new Reference object, and assign parts to complete the reference object
                Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                // Create a new Scripture object and assign the reference and the text part to finish the scripture object
                Scripture scripture = new Scripture(reference, parts[4]);
                // Add the Scripture object to the list
                _scriptures.Add(scripture);
            }
            else
            {
                continue; // Skip lines that do not match expected format
            }
        }
    }
    public Scripture GetRandomScripture()
    // Function to retrieve a random Scripture from the _scriptures library. Returns null if the library is empty.
    // PARAMETERS: None
    // RETURNS: A random Scripture object from the library
    {
        // Check if the list of scriptures is empty, return null if it is
        if (_scriptures.Count == 0)
            return null;
        // Generate a random index object
        Random rand = new Random();
        // Get a random index within the range of the list size.
        int index = rand.Next(_scriptures.Count);
        // Return the Scripture at the random index
        return _scriptures[index];
    }
}