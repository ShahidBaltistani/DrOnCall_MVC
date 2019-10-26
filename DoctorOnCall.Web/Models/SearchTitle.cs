using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoctorOnCall.Web.Models
{
    public class SearchTitle
    {

        public static List<SearchTitle> RecipeTitles;
        static SearchTitle()
        {
            RecipeTitles = new List<SearchTitle>();
        }
        public int Id { get; set; }
        public string Title { get; set; }

    }
}
