using Gallery2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gallery2._0.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags=new List<ImageTags>();
            var cityImageTags=new List<ImageTags>();

            var tag1 = new ImageTags()
            {
                Id = 0,
                Descriptions = "Adventure"
            };
            var tag2 = new ImageTags()
            {
                Id = 1,
                Descriptions = "Games"
            }; 
            var tag3 = new ImageTags()
            {
                Id = 1,
                Descriptions = "Travels"
            };

            hikingImageTags.Add(tag1);
            cityImageTags.AddRange(new List<ImageTags>{ tag2,tag3});

            var imageList = new List< GalleryImage>()
            {
                new GalleryImage()
                {
                    Title="Hiking Trip ",
                    Url = "https://images.pexels.com/photos/136872/pexels-photo-136872.jpeg",
                    CreatedDate=DateTime.Now,
                    Tags=hikingImageTags
                },
                new GalleryImage()
                {
                    Title="On the Trails",
                    Url = "https://images.pexels.com/photos/63294/autos-technology-vw-multi-storey-car-park-63294.jpeg",
                    CreatedDate=DateTime.Now,
                    Tags=hikingImageTags
                },
                new GalleryImage()
                {
                    Title="Downtown ",
                    Url = "https://images.pexels.com/photos/136872/pexels-photo-136872.jpeg",
                    CreatedDate=DateTime.Now,
                    Tags=cityImageTags
                }
            };
            
            var model = new GalleryIndexModel()
            {
                Images=imageList,
                SearchQuery=""
            };
            return View(model);
        }
    }
}
