public class Prompt
{
    static string[] _prompts = {

    "How did the spirit touch your life today?",
    "What miracles did you see today in your life?",
    "How did you help someone today?",
    "What made you smile today?",
    "How are your relationships with others going?",
    "What scripture did you read today?",
    "What did you learn today?"

    };

    public string DisplayPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Length);
        string prompt = _prompts[index];
        return prompt;
    }
}