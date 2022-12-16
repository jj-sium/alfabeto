using System;
// write in 2019 by maurizio.conti@fablabromagna.org

public static class Alfabeto
{
    public static bool Verifica(string input)
    {
        string alfabeto = "abcdefghilmnopqrstuvz";
        bool s = false;
        for (int i = 0; i < alfabeto.Length; i++)
        {
            for (int j = 0; j < alfabeto.Length; j++)
            {
                if (i ==j)
                {
                    s = true;
                    break;
                }
                else
                {
                    s = false;
                }
            }
        }
        return s;
    }
}
