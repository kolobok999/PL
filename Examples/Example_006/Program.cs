//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
 + "ежели бы вас послали вместо нашего милого Винценгероде,"
 + "вы бы взяли приступом согласие прусского короля."
 + "Вы так красноречивы. Вы дадите мне чаю?";

String Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue)
            result += newValue;
        else
            result += text[i];

    }
    return result;
}
string newText = Replace(text, ' ', '-');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replace(newText, 'к', 'К');
System.Console.WriteLine(newText);
newText = Replace(newText, 'C','c');
System.Console.WriteLine(newText);
