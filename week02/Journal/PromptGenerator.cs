using System;
public class PromptGenerator
// PURPOSE: This class is designed to generate random prompts for journal entries.
// It contains a list of prompts and a method to retrieve a random prompt.
// MEMBER VARIABLES: _prompts - a list of strings containing the prompts.
// METHODS: GetRandomPrompt - returns a random prompt from the list.
{
    public List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "What is something you learned recently?",
        "Describe a challenge you faced and how you overcame it.",
        "What are you grateful for today?",
        "What is a goal you want to achieve this week?",
        "What made you smile today?",
        "What is something you learned recently?",
        "Describe a challenge you faced and how you overcame it.",
        "What are you grateful for today?",
        "What is a goal you want to achieve this week?",
        "When have I felt closest to God this week?",
        "What does it mean to me to have a personal relationship with Jesus Christ?",
        "How has God answered my prayers recently—big or small?",
        "What doubts or questions do I need to bring to God right now?",
        "In what areas of my life do I need more faith?",
        "What scripture verse stood out to me today and why?",
        "How can I apply today’s scripture reading to my current season of life?",
        "Is there a parable or Bible story that mirrors something I’m experiencing?",
        "What scripture do I turn to when I’m afraid, and why does it comfort me?",
        "What verse do I want to memorize and live out this week?",
        "What am I truly grateful for today?",
        "How have I seen God's hand in the ordinary moments of my life?",
        "What blessings have I overlooked recently?",
        "Where did I notice beauty today that reminded me of God's creation?",
        "How has God used other people to bless me lately?",
        "What spiritual gifts do I feel God has given me?",
        "How am I using my time and talents to serve others and glorify God?",
        "What is one area of my life where I feel God is calling me to grow?",
        "What legacy of faith do I want to leave behind?",
        "If I trusted God completely, what would I do differently?",
        "Who do I need to forgive—and what’s holding me back?",
        "In what area of my life do I need God’s healing?",
        "What past hurt am I still carrying that I need to surrender?",
        "Have I forgiven myself for past mistakes, and why or why not?",
        "What does God’s grace mean to me personally?",
        "What is one way I can worship God creatively this week?",
        "What has my prayer life been like lately? What’s missing or growing?",
        "What do I need to bring before God in total honesty?",
        "How can I create more space for silence and stillness with God?",
        "What would I say to God today if I knew He was sitting beside me?"
    };

    public string GetRandomPrompt()
    // PURPOSE: This method selects a random prompt from the _prompts list and returns it.
    // PARAMETERS: None.
    // RETURNS: A string containing a random prompt.
    {
        // Create a new random number generator object
        Random random = new Random();
        // Generate a random index based on the number of prompts in the list
        int index = random.Next(_prompts.Count);
        // Retrieve the prompt at the random index and return it
        string promptText = _prompts[index];
        return promptText;
    }
}