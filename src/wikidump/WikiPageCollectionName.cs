﻿using System.Collections.Generic;

namespace wikidump
{
    internal class WikiPageCollectionName
    {
        public static IEnumerable<string> GenerateCollectionNames(string patternName)
        {
            int index = 0;
            while (true)
            {
                yield return string.Format(patternName, index++);
            }
        }
    }
}
