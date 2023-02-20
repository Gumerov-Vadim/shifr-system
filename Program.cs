// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите текст, который хотите зашифровать:");
string l = Console.ReadLine();
Alphabeta a = new Alphabeta();
Console.WriteLine("\nЗашифрованный текст: " +a.shifr(l));
Console.WriteLine("\nВведите текст, который хотите расшифровать:");
l = Console.ReadLine();
Console.WriteLine("\nрасшифрованный текст: " + a.deshifr(l));

class Alphabeta
{
    private char[,] ab_en;
    private char[,] ab_ru;
    public Alphabeta()
    {
        ab_en = new char[34, 2];
        ab_ru = new char[34, 2];
        ab_ru[0, 0] = 'а'; ab_ru[0, 1] = 'б';
        ab_ru[1, 0] = 'б'; ab_ru[1, 1] = 'ю';
        ab_ru[2, 0] = 'в'; ab_ru[2, 1] = 'г';
        ab_ru[3, 0] = 'г'; ab_ru[3, 1] = 'ы';
        ab_ru[4, 0] = 'д'; ab_ru[4, 1] = 'е';
        ab_ru[5, 0] = 'е'; ab_ru[5, 1] = 'ь';
        ab_ru[6, 0] = 'ё'; ab_ru[6, 1] = 'з';
        ab_ru[7, 0] = 'ж'; ab_ru[7, 1] = 'ш';
        ab_ru[8, 0] = 'з'; ab_ru[8, 1] = 'й';
        ab_ru[9, 0] = 'и'; ab_ru[9, 1] = 'ц';
        ab_ru[10, 0] = 'й'; ab_ru[10, 1] = 'л';
        ab_ru[11, 0] = 'к'; ab_ru[11, 1] = 'ф';
        ab_ru[12, 0] = 'л'; ab_ru[12, 1] = 'н';
        ab_ru[13, 0] = 'м'; ab_ru[13, 1] = 'т';
        ab_ru[14, 0] = 'н'; ab_ru[14, 1] = 'п';
        ab_ru[15, 0] = 'о'; ab_ru[15, 1] = 'р';
        ab_ru[16, 0] = 'п'; ab_ru[16, 1] = 'с';
        ab_ru[17, 0] = 'р'; ab_ru[17, 1] = 'о';
        ab_ru[18, 0] = 'с'; ab_ru[18, 1] = 'у';
        ab_ru[19, 0] = 'т'; ab_ru[19, 1] = 'м';
        ab_ru[20, 0] = 'у'; ab_ru[20, 1] = 'х';
        ab_ru[21, 0] = 'ф'; ab_ru[21, 1] = 'к';
        ab_ru[22, 0] = 'х'; ab_ru[22, 1] = 'ч';
        ab_ru[23, 0] = 'ц'; ab_ru[23, 1] = 'и';
        ab_ru[24, 0] = 'ч'; ab_ru[24, 1] = 'щ';
        ab_ru[25, 0] = 'ш'; ab_ru[25, 1] = 'ж';
        ab_ru[26, 0] = 'щ'; ab_ru[26, 1] = 'ъ';
        ab_ru[27, 0] = 'ъ'; ab_ru[27, 1] = 'д';
        ab_ru[28, 0] = 'ы'; ab_ru[28, 1] = 'э';
        ab_ru[29, 0] = 'ь'; ab_ru[29, 1] = 'в';
        ab_ru[30, 0] = 'э'; ab_ru[30, 1] = 'я';
        ab_ru[31, 0] = 'ю'; ab_ru[31, 1] = ' ';
        ab_ru[32, 0] = 'я'; ab_ru[32, 1] = 'а';
        ab_ru[33, 0] = ' '; ab_ru[33, 1] = 'ё';

        ab_en[0, 0] = 'a'; ab_en[0, 1] = 'v';
        ab_en[1, 0] = 'b'; ab_en[1, 1] = 'w';
        ab_en[2, 0] = 'c'; ab_en[2, 1] = 'x';
        ab_en[3, 0] = 'd'; ab_en[3, 1] = 'y';
        ab_en[4, 0] = 'e'; ab_en[4, 1] = 'z';
        ab_en[5, 0] = 'f'; ab_en[5, 1] = ' ';
        ab_en[6, 0] = 'g'; ab_en[6, 1] = '.';
        ab_en[7, 0] = 'h'; ab_en[7, 1] = ',';
        ab_en[8, 0] = 'i'; ab_en[8, 1] = '!';
        ab_en[9, 0] = 'j'; ab_en[9, 1] = ':';
        ab_en[10, 0] = 'k'; ab_en[10, 1] = ';';
        ab_en[11, 0] = 'l'; ab_en[11, 1] = '?';
        ab_en[12, 0] = 'm'; ab_en[12, 1] = '-';
        ab_en[13, 0] = 'n'; ab_en[13, 1] = 'k';
        ab_en[14, 0] = 'o'; ab_en[14, 1] = 'l';
        ab_en[15, 0] = 'p'; ab_en[15, 1] = 'm';
        ab_en[16, 0] = 'q'; ab_en[16, 1] = 'n';
        ab_en[17, 0] = 'r'; ab_en[17, 1] = 'o';
        ab_en[18, 0] = 's'; ab_en[18, 1] = 'p';
        ab_en[19, 0] = 't'; ab_en[19, 1] = 'q';
        ab_en[20, 0] = 'u'; ab_en[20, 1] = 'r';
        ab_en[21, 0] = 'v'; ab_en[21, 1] = 's';
        ab_en[22, 0] = 'w'; ab_en[22, 1] = 't';
        ab_en[23, 0] = 'x'; ab_en[23, 1] = 'u';
        ab_en[24, 0] = 'y'; ab_en[24, 1] = 'a';
        ab_en[25, 0] = 'z'; ab_en[25, 1] = 'b';
        ab_en[26, 0] = ' '; ab_en[26, 1] = 'c';
        ab_en[27, 0] = '.'; ab_en[27, 1] = 'd';
        ab_en[28, 0] = ','; ab_en[28, 1] = 'e';
        ab_en[29, 0] = '!'; ab_en[29, 1] = 'f';
        ab_en[30, 0] = ':'; ab_en[30, 1] = 'g';
        ab_en[31, 0] = ';'; ab_en[31, 1] = 'h';
        ab_en[32, 0] = '?'; ab_en[32, 1] = 'i';
        ab_en[33, 0] = '-'; ab_en[33, 1] = 'j';
    }

    public char shifr(char c)
    {
        int i = 0;
        while (i < 34&&ab_en[i,0] != c)
        {
            i++;
        }
        if (i != 34) { return ab_en[i,1]; }
        i = 0;
        while (i < 34 && ab_ru[i,0] != c )
        {
            i++;
        }
        if (i != 34) { return ab_ru[i,1]; }
        return '*';
    }
    public char deshifr(char c)
    {
        int i = 0;
        while (i < 34 && ab_en[i,1] != c )
        {
            i++;
        }
        if (i != 34) { return ab_en[i,0]; }
        i = 0;
        while (i < 34 && ab_ru[i,1] != c)
        {
            i++;
        }
        if (i != 34) { return ab_ru[i,0]; }
        return '*';
    }
    public string shifr(string s)
    {
        int l = s.Length;
        char[] shifr_s = new char[l];
        for (int i = 0; i < l; i++)
        {
            shifr_s[i] = shifr(s[i]);
        }
        return new string(shifr_s);
    }
    public string deshifr(string s)
    {
        int l = s.Length;
        char[] deshifr_s = new char[l];
        for (int i = 0; i < l; i++)
        {
            deshifr_s[i] = deshifr(s[i]);
        }
        return new string(deshifr_s);
    }
}