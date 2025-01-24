public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideRandomWords(int numberToHide)
    {
        var random = new Random ();
        int hiddenCount = 0 ;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            Word word = _words[index];

            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;

            }
        }
    }
    public string GetDisplayText()
    {
        string verseText = string.Join(' ', _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {verseText}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(Word => Word.IsHidden());
    }
}