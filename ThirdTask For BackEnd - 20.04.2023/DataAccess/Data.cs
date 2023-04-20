using System.Collections.Generic;
using ThirdTask_For_BackEnd___20._04._2023.Models;

namespace ThirdTask_For_BackEnd___20._04._2023.DataAccess
{
    public class Data
    {
        public static List<FeatureForService> FeatureService = new List<FeatureForService>
        {
            new FeatureForService {Id=1,Title="Lorem Ipsum 1",Icon="bi bi-card-checklist",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new FeatureForService {Id=2,Title="Lorem Ipsum 2",Icon="bi bi-bar-chart",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new FeatureForService {Id=3,Title="Lorem Ipsum 3",Icon="bi bi-binoculars",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new FeatureForService {Id=4,Title="Lorem Ipsum 4",Icon="bi bi-card-checklist",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new FeatureForService {Id=5,Title="Lorem Ipsum 5",Icon="bi bi-bar-chart",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new FeatureForService {Id=6,Title="Lorem Ipsum 6",Icon="bi bi-binoculars",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
        };

        public static List<FeatureForHome> FeatureHome = new List<FeatureForHome>
        {
            new FeatureForHome {Id=1,Title="Lorem Ipsum 1",Icon="bi bi-card-checklist",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new FeatureForHome {Id=2,Title="Lorem Ipsum 2",Icon="bi bi-bar-chart",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
            new FeatureForHome {Id=3,Title="Lorem Ipsum 3",Icon="bi bi-binoculars",Desc="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"},
        };
    }
}
