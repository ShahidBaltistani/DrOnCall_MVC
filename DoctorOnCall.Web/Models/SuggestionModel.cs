using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Web.Models
{
    public class SuggestionModel : IEqualityComparer<SuggestionModel>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Href { get; set; }
        public string SellerName { get; set; }
        public string SellerImage { get; set; }
        public bool Equals(SuggestionModel x, SuggestionModel y)
        {
            return x.Id.Equals(y.Id);
        }

        public int GetHashCode(SuggestionModel obj)
        {
            throw new NotImplementedException();
        }
    }
}