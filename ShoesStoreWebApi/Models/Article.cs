//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesStoreWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        public int ArticleID { get; set; }
        public string ArticleName { get; set; }
        public string ArticleDescription { get; set; }
        public Nullable<decimal> ArticlePrice { get; set; }
        public int TotalShelf { get; set; }
        public int TotalWarehouse { get; set; }
        public Nullable<int> StoreID { get; set; }
    
        public virtual Store Store { get; set; }
    }
}