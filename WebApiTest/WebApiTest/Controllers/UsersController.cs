using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    public class UsersController : ApiController
    {       
        private User[] users = new User[] {
            new User {
                Id = 1, Name = "Haleemah Redfern", Email = "gqwe@qq.com",Phone="94523698"},
            new User {
                Id = 2, Name = "Aya Bostock", Email = "bqwe@qq.com",Phone="84523698"},
            new User {
                Id = 3, Name = "Sohail Perez",Email = "jqwe@qq.com", Phone="34523698" },
            new User {
                Id = 4, Name = "Merryn Peck",Email = "kqwe@qq.com" ,Phone="24523698" },
            new User {
                Id = 5, Name = "Cairon Reynolds", Email = "lqwe@qq.com",Phone="54523698" }
            };

        //GET: api/Users[ResponseType(typeof(IEnumerable<User>))]
        //方法名可以更改
        public IEnumerable<User> Get()
        {         
            return users;
        }

        /**
         IHttpActionResult是WebApi最常用的一种返回值类型，
            常用的方式有：Json(T content)、Ok()、 Ok(T content)、
            NotFound()、Content(HttpStatusCode statusCode, T value)、
            BadRequest()、Redirect(string location)等
         **/
        // GET: api/Users/5
        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
           
        }




        // POST: api/Users
        public IHttpActionResult Post([FromBody]string value)
        {
            string a = value;//(a 是 null后期研究一下)
            string b = a+"oooo";
            return Content(HttpStatusCode.OK,  b);
        }



    }
}