using ShoesStoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ShoesStoreMvc.Models
{
    public class ArticleDTO:Article
    {
        
        public  int      ArticleID            { get; set; }
        public  string   ArticleName          { get; set; }
        public  string   ArticleDescription   { get; set; }
        public  decimal  ArticlePrice         { get; set; }
        public  int      TotalShelf           { get; set; }
        public  int      TotalWarehouse       { get; set; }
        public  string   StoreID              { get; set; }
        public string    StoreName            { get; set; }

        
    }
}