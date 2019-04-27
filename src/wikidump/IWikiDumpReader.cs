using System;
using System.Collections.Generic;

namespace wikidump
{
    public interface IWikiDumpReader : IDisposable
    {
        IEnumerable<WikiPage> ReadPages();
    }
}
