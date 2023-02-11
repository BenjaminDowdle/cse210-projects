using System;

//Keeps track of the reference and the text of the scripture.
//Can hide words and get the rendered display of the text.
public class Scripture
{
    private string[] _scriptureList = {
        $"\nAnd it came to pass that I, Nephi, said unto my father: I will go and do \nthe things which the Lord hath commanded, for I know that the Lord giveth \nno commandments unto the children of men, save he shall prepare a way \nfor them that they may accomplish the thing which he commandeth them.",
        $"\nAdam fell that men might be; \nand men are, that they might have joy.",
        $"\nTrust in the Lord with all thine heart; and lean not unto thine own \nunderstanding. In all thy ways acknowledge him, and he shall direct thy paths.",
        $"\nAnd behold, I tell you these things that ye may learn wisdom; that ye may \nlearn that when ye are in the service of your fellow beings ye are only \nin the service of your God.",
        $"\nIf any of you lack wisdom, let him ask of God, that giveth to all men \nliberally, and upbraideth not; and it shall be given him. But let him ask in \nfaith, nothing wavering. For he that wavereth is like a wave of the sea driven \nwith the wind and tossed."
    };
    private string _scripture;
    private string _reference;


    public string GetRandomScripture()
    {
        Console.Clear();
        var random = new Random();
        int index = random.Next(_scriptureList.Length);
        _scripture = _scriptureList[index];

        Reference reference = new Reference();
        _reference = reference.DisplaySelectedReference(index);

        _scripture = _reference + "\n" + _scripture;

        return _scripture;
    }

    public string GetSpecificScripture(int i)
    {
        string _scripture = _scriptureList[i - 1];
        return _scripture;
    }

    public string[] GetScriptureArray(int i)
    {
        _scripture = _scriptureList[i - 1];
        var scriptureArray = _scripture.Split(" ");

        return scriptureArray;
    }
}