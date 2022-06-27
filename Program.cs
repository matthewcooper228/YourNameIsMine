bool isSubsequence(string name1, string name2)
{
    if(name1.Length == name2.Length && name1 != name2)
    {
        return false;
    }
    string longName = "";
    string shortName = "";
    if(name1.Length < name2.Length)
    {
        longName = name2;
        shortName = name1;
    }
    else
    {
        longName = name1;
        shortName = name2;
    }
    for(int i = 0; i < shortName.Length; i++)
    {
        if(shortName[i] != longName[i])
        {
            longName = longName.Substring(0,i) + longName.Substring(i + 1, longName.Length - i - 1);
        }
    }
    longName = longName.Substring(0, shortName.Length);
    return shortName == longName;
}