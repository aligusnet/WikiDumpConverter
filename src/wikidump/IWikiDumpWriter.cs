using System.Collections.Generic;

namespace wikidump
{
    public interface IWikiDumpWriter
    {
        void WritePages(IEnumerable<WikiPage> pages);
    }
}
