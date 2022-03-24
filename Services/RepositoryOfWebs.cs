using PracticaWeb01.Models;

namespace CurrículumASP.Services
{
    public class RepositoryOfWebs
    {
        public List<ClassWebs> GetWebs()
        {
            return new List<ClassWebs>()
            {
                new ClassWebs
                {
                    Title = "Proyecto Amazon",
                    Description = "Web de Amazon",
                    Link = "https://amazon.com",
                    imageURL = "/images/amazon.png"
                },

                new ClassWebs
                {
                    Title = "Proyecto NY Times",
                    Description = "Web de NY Times",
                    Link = "https://nytimes.com",
                    imageURL = "/images/nytimes.png"
                },

                new ClassWebs
                {
                    Title = "Proyecto Reddit",
                    Description = "Web de Reddit",
                    Link = "https://reddit.com",
                    imageURL = "/images/reddit.png"
                },

                new ClassWebs
                {
                    Title = "Proyecto Steam",
                    Description = "Web de Steam",
                    Link = "https://store.steampowered.com",
                    imageURL = "/images/steam.png"
                },

                new ClassWebs
                {
                    Title = "Proyecto Epic Games",
                    Description = "Web de Epic Games",
                    Link = "https://www.epicgames.com/",
                    imageURL = "/images/epic.png"
                },
            };
        }
    }
}
