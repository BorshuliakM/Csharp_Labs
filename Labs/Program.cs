using Lab_4;

Word word = new("I");
Word word2 = new("Will");
Word word3 = new("Do");
Word word4 = new("Something");
Sentence sentence = new();
sentence.AddWord(word);
sentence.AddWord(word2);
sentence.AddWord(word3);
sentence.AddWord(word4);
Text text = new("Some title");
Text text2 = new("Some title");
text2.AddSentence(sentence);
text.AddSentence(sentence);
text.PrintText();
Console.WriteLine(text.ToString());
Console.WriteLine(text.GetHashCode());
text.Equals(text2);
