using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;
using System.Data;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;



namespace SkyloWeb.Controller
{
    public class SkyloController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }
          [AllowAnonymous]

        public HttpResponseMessage Post([FromBody]object message)//[FromBody]string name
        {
            try
            {
                string onlystr = message.ToString();
                dynamic obj1 = JObject.Parse(onlystr);
                string finalllstr = obj1.message;
                if (finalllstr!= "" &&  finalllstr!= string.Empty && finalllstr!=null)
                {
                    string jsonString = "{\"code\": \"0\", \"result\": \"SUCCESS\", \"message\": \"Message Received\" }";

                    var response = this.Request.CreateResponse(HttpStatusCode.OK);
                    response.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    return response;
                }
                else
                {
                    string jsonString = "{\"code\": \"-1\", \"result\": \"FAILURE\", \"message\": \"Invalid JSON\" }";

                    var response = this.Request.CreateResponse(HttpStatusCode.OK);
                    response.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    return response;
                }
               

            }

            catch (Exception ex)
            {
                string jsonString = "{\"code\": \"-1\", \"result\": \"FAILURE\", \"message\": \"Invalid JSON\" }";

                var response = this.Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                return response;
                //var responsefinal = Request.CreateResponse(HttpStatusCode.InternalServerError, "");
                //DataTable dt = new DataTable();
                //dt.Columns.Add("Code");
                //dt.Columns.Add("result");
                //dt.Columns.Add("message");
                //dt.Rows.Add(-1, "Failure", "Invalid JSON");
                //string str = "HTTP Status Code:200";
                //return Request.CreateResponse(HttpStatusCode.InternalServerError, dt);
            }
        }
        //public HttpResponseMessage Post([FromBody]object message)//[FromBody]string name
        //{
        //    try{
        //        //if (message!="")
        //        //{
                    
        //        //}
        //        //dynamic objjj = JsonConvert.DeserializeObject(message);
        //        string hhh = message.ToString();
        //        //string request = JsonConvert.DeserializeObject(message);
        //        //var str = message.ToString();
        //       // string ggg="{HTTP Status Code : (200){"code": "0", "result": "SUCCESS", "message": "Message Received" }";
        //        //var jsonString = Json(model).ToString();
                
        //        string someJson = "{\"HTTP Status Code\": \"\",\"ErrorDetails\": {\"ErrorID\": 111,\"Description\":{\"Short\": 0,\"Verbose\": 20},\"ErrorDate\": \"\"}}";
        //        //string ggg="{HTTP Status Code : (200){"code": "0", "result": "SUCCESS", "message": "Message Received" }";
        //        var response = this.Request.CreateResponse(HttpStatusCode.OK);
        //        response.Content = new StringContent(someJson, Encoding.UTF8, "application/json");
        //        return response;

        //        //var responsefinal = Request.CreateResponse(HttpStatusCode.OK, HttpStatusCode.OK);
        //        //DataTable dt = new DataTable();
        //        //dt.Columns.Add("Code");
        //        //dt.Columns.Add("result");
        //        //dt.Columns.Add("message");
        //        //dt.Rows.Add(0, "SUCCESS", "Message Received");
        //        //return Request.CreateResponse(HttpStatusCode.OK, dt);


        //        //var jsonString = '{ "code": "0", "result": "SUCCESS", "message": "Message Received" }' ;
        //        //var response1 = this.Request.CreateResponse(HttpStatusCode.OK);
        //        //response1.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");
        //        //return response1;
                
        //        //string str = "HTTP Status Code:200";
        //        //string test = JsonConvert.SerializeObject(dt);
        //        //var msg = Request.CreateResponse(HttpStatusCode.OK, dt);
        //        //msg.Headers.Serv
        //        //return Request.CreateResponse(HttpStatusCode.OK, test);

              
        //        //return Request.CreateResponse(HttpStatusCode.OK, JSONString);
        //        //return JSONString.ToString();
           
        //    //if (message != "" || message != null)
        //    //{

        //    //    var responsefinal = Request.CreateResponse(HttpStatusCode.OK, HttpStatusCode.OK);
        //    //    DataTable dt = new DataTable();
        //    //    dt.Columns.Add("Code");
        //    //    dt.Columns.Add("result");
        //    //    dt.Columns.Add("message");
        //    //    dt.Rows.Add(0, "SUCCESS", "Message Received");
        //    //    string str = "HTTP Status Code:200";
        //    //    string test = JsonConvert.SerializeObject(dt);
        //    //    string stt = DataTableToJSONWithStringBuilder(dt);
        //    //    return Request.CreateResponse(HttpStatusCode.OK, test);
                
        //    //    //var result = new Item { Id = 123, Name = "Hero" };

        //    //    //return new JsonResult(result)
        //    //    //{
        //    //    //    StatusCode = HttpStatusCode.OK // Status code here 
        //    //    //};

        //    //}
        //    //else
        //    //{
        //    //    var responsefinal = Request.CreateResponse(HttpStatusCode.InternalServerError ,HttpStatusCode.OK);
        //    //    DataTable dt = new DataTable();
        //    //    dt.Columns.Add("Code");
        //    //    dt.Columns.Add("result");
        //    //    dt.Columns.Add("message");
        //    //    dt.Rows.Add(-1, "Failure", "Invalid JSON");
        //    //    string str = "HTTP Status Code:200";
        //    //    return Request.CreateResponse(HttpStatusCode.InternalServerError , dt);
        //    //}

        //    //return Json(new { Code = 0, result = "SUCCESS",message="Message Received" });
        //    //message.Headers.Location = new Uri(Request.RequestUri +
        //    //    employee.ID.ToString());
        //    //return responsefinal;
        //    //return "welcome";
        //    //return Ok;
        //}

       


        ////public IHttpActionResult Post([FromBody]string message)
        ////{
        ////    //return Ok();//200
        ////    //return StatusCode(HttpStatusCode.Accepted);//202
        ////    //return BadRequest();//400
        ////    //return InternalServerError();//500
        ////    //return Unauthorized();//401
        ////    return Ok();
        ////}

        ////public string Post([FromBody]string message)//[FromBody]string name
        ////{
        ////    return "welcome";
        ////}
        ////public string Post()
        ////{
        ////    return "Received";
        ////}
             
        //    catch(Exception ex)
        //    {
        //         var responsefinal = Request.CreateResponse(HttpStatusCode.InternalServerError ,HttpStatusCode.OK);
        //        DataTable dt = new DataTable();
        //        dt.Columns.Add("Code");
        //        dt.Columns.Add("result");
        //        dt.Columns.Add("message");
        //        dt.Rows.Add(-1, "Failure", "Invalid JSON");
        //        string str = "HTTP Status Code:200";
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError , dt);
        //    }
        //}


  
    }
}
