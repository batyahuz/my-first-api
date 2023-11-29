using API_Batya;
using API_Batya.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UnitTests
{
    public class EventsControllerTest
    {
        private readonly EventsController _eventsController;

        public EventsControllerTest()
        {
            var context = new DataContextFake();
            _eventsController = new EventsController(context);
        }

        [Fact]
        public void Get_ReturnOk()
        {
            //AAA
            //Arrange - ארגון הנתונים הנדרשים להפעלת הפונקציה הנבדקת
            //Act - הפעלת הפונקציה הנבדקת
            //Asser - הכרזה מה התוצאה הרצויה
            var result = _eventsController.Get();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_ReturnOk()
        {
            var id = 1;
            var result = _eventsController.Get(id);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Post_ReturnNoContent()
        {
            var e = new Event("a title", DateTime.Now, DateTime.Now);
            var result = _eventsController.Post(e);
            Assert.IsType<NoContentResult>(result);

        }

        [Fact]
        public void Put_ReturnCreated()
        {
            var e = new Event("a title", DateTime.Now, DateTime.Now);
            var id = 2;
            var result = _eventsController.Put(id, e);
            Assert.IsType<CreatedResult>(result);
        }

        [Fact]
        public void Delete_ReturnNotFound()
        {
            var id = 100;
            var result = _eventsController.Delete(id);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}