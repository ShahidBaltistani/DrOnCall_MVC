using DoctorOnCall.Model.Doctors;
using DoctorOnCall.ViewModel;
using DoctorOnCall.ViewModel.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorOnCall.Web.Models
{
    public class SearchMappers
    {
        public List<SearchTitle> RecipeTemplateModelsToRecipeTitle(List<DoctorCreateViewModel> recipeTemplates)
        {
            List<SearchTitle> titles = null;
            if (recipeTemplates != null)
            {
                titles = new List<SearchTitle>();
                foreach (DoctorCreateViewModel doctor in recipeTemplates)
                {
                    titles.Add(new SearchTitle()
                    {

                        Id = doctor.DoctorId,
                        //Title = doctor.Name
                    });
                }
            }
            return titles;
        }


        //public List<SuggestionModel> RecipeTitlesToSuggestionModels(List<SearchTitle> recipeTitles)
        //{
        //    List<SuggestionModel> suggestions = null;
        //    if (recipeTitles != null)
        //    {
        //        suggestions = new List<SuggestionModel>();
        //        foreach (SearchTitle title in recipeTitles)
        //        {
        //            //var seller = new DoctorService().GetDoctor(title.Id);
        //            var suggestion = new SuggestionModel()
        //            {
        //                Title = title.Title,
        //                Id = title.Id,
        //                SellerName = seller.Name,
        //                SellerImage = seller.ProfileImage,
        //                Href = "#"

        //            };
        //            suggestions.Add(suggestion);
        //        }
        //    }
        //    return suggestions;
        //}
    }
}