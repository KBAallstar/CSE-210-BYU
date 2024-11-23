using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;
    private string _verseText;

    private static List<(string book, int chapter, int verse, int endVerse, string verseText)> _scriptureLibrary = new List<(string, int, int, int, string)>
    {
        ("Matthew", 11, 29, 30, "Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light."),
        ("Mark", 7, 9, 0, "And he said unto them, Full well ye reject the commandment of God, that ye may keep your own tradition."),
        ("John", 3, 16, 0, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
        ("John", 11, 41, 42, "Then they took away the stone from the place where the dead was laid. And Jesus lifted up his eyes, and said, Father, I thank thee that thou hast heard me. And I knew that thou hearest me always: but because of the people which stand by I said it, that they may believe that thou hast sent me."),
        ("Galatians", 6, 7, 0, "Be not deceived; God is not mocked: for whatsoever a man soweth, that shall he also reap.")
    };

    public Reference()
    {
        var random = new Random();
        var randomScripture = _scriptureLibrary[random.Next(_scriptureLibrary.Count)];

        _book = randomScripture.book;
        _chapter = randomScripture.chapter;
        _verse = randomScripture.verse;
        _endVerse = randomScripture.endVerse;
        _verseText = randomScripture.verseText;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }

    public string GetVerseText()
    {
        return _verseText;
    }
}