﻿using Bunea_Denisa_Lab2.Models;
namespace Bunea_Denisa_Lab2.Models.ViewModels

{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
