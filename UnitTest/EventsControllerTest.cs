using API_Batya;
using API_Batya.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UnitTests
{
    public class EventsControllerTest
    {
        [Fact]
        public void Get_ReturnOk()
        {
            //AAA
            //Arrange - ארגון הנתונים הנדרשים להפעלת הפונקציה הנבדקת
            //Act - הפעלת הפונקציה הנבדקת
            //Asser - הכרזה מה התוצאה הרצויה
            var controller = new EventsController();
            var result = controller.Get();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_ReturnOk()
        {
            var id = 1;
            var controller = new EventsController();
            var result = controller.Get(id);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Post_ReturnNoContent()
        {
            var e = new Event("a title", DateTime.Now, DateTime.Now);
            var controller = new EventsController();
            var result = controller.Post(e);
            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public void Put_ReturnCreated()
        {
            var e = new Event("a title", DateTime.Now, DateTime.Now);
            var id = 1;
            var controller = new EventsController();
            var result = controller.Put(id, e);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Delete_ReturnNotFound()
        {
            var id = 100;
            var controller = new EventsController();
            var result = controller.Delete(id);
            Assert.IsType<OkObjectResult>(result);
        }
    }
}