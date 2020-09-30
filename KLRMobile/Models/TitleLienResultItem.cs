﻿using System;

namespace KLRMobile.Models
{
    public class TitleLienResultItem
    {
        public int Id { get; set; }
        public string Debtor { get; set; }
        public string LienHolder { get; set; }
        public string FileNumber { get; set; }
        public string VINNumber { get; set; }
        public string Description { get; set; }
        public string SecurityId { get; set; }
        public string TitleNumber { get; set; }
        public string SecurityType { get; set; }
        public string UpdatedBy { get; set; }
        public string IndexedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime DateFiled { get; set; }
    }
}