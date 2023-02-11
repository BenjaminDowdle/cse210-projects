using System;

//Keeps track of the book, chapter, and verse information.
public class Reference
{
    private string[] _referenceList = {
        "1 Nephi 3:7",
        "2 Nephi 2:25",
        "Proverbs 3:5-6",
        "Mosiah 2:17",
        "James 1:5-6"
    };
    private string _reference;

    public void DisplayAllReferences()
    {
        foreach (string reference in _referenceList)
        {
            Console.WriteLine(reference);
        }
    }

    public string DisplaySelectedReference(int i)
    {
        _reference = _referenceList[i - 1];
        return _reference;
    }
}