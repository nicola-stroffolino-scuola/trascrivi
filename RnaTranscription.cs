using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        if(String.IsNullOrEmpty(dna)) return "";

        return string.Join("", dna.ToList<char>().Select(c => 
            c = (c == 'G' ? 'C' : c == 'C' ? 'G' : c == 'T' ? 'A' : c == 'A' ? 'U' : '.')
        ));
    }
}