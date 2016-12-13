﻿using System;

namespace SearchEngine
{
    [Serializable]
    public class DocumentData
    {
        private static char[] Delimiter = new char[] { '~' };
        public string DocNumber { get; set; }
        public string MostFrequentTerm { get; set; }
        public int FrquenciesOfMostFrequentTerm{get;set;}
        public int AmmountOfUniqueTerms{get;set;}
        public string Language{get;set;}
        public int DocumentLength{get;set;}

        public DocumentData(string docNo, string mostFrequentTerm, int frquenciesOfMostFrequentTerm, int ammountOfUniqueTerms, string language, int documentLength)
        {
            DocNumber = docNo;
            MostFrequentTerm = mostFrequentTerm;
            FrquenciesOfMostFrequentTerm = frquenciesOfMostFrequentTerm;
            AmmountOfUniqueTerms = ammountOfUniqueTerms;
            Language = language;
            DocumentLength = documentLength;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}", DocNumber, Delimiter, MostFrequentTerm, FrquenciesOfMostFrequentTerm, AmmountOfUniqueTerms, Language, DocumentLength);
        }



    }
}