﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP_WebCrawler
{
    interface IWebCrawler
    {
        Task<CrawlResult> StartCrawlingAsync(string parentUrl, List<string> rootUrls, int currentDepth);
    }
}