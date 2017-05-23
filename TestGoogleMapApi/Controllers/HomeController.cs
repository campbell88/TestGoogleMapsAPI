using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace TestGoogleMapApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SaveGoogleData()//object sender, EventArgs e)
        {
        //  // protected void btnSave_Click(object sender, EventArgs e)
        
        //    string latitude = hfLat.Value;
        //    string longitude = hfLon.Value;

        //    //Save to database here
        

            return View();
        }

        public ActionResult GetGoogleData()
        { //getting API
        //    HttpWebRequest request = WebRequest.CreateHttp("http://forecast.weather.gov/MapClick.php?lat=38.4247341&lon=-86.9624086&FcstType=json");

        //    request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";

        //    //add a key to your API call if the API requires a key to use it
        //    // request.Headers.Add("X-Mashape-Key", "testtest123");


        //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        //    StreamReader rd = new StreamReader(response.GetResponseStream());
        //    string data = rd.ReadToEnd(); //raw format

        //    JObject WeatherData = JObject.Parse(data);

        //    //   ViewBag.Message = WeatherData["productionCenter"];

        //    //  ViewBag.Message = WeatherData["data"]["weather"][4];
        //    //   ViewBag.Message = WeatherData["data"]["weather"][4];

        //    ViewBag.Message = WeatherData["data"]["weather"];

        //    ViewBag.Time = WeatherData["time"]["startPeriodName"];


            return View();


        }

        //public ActionResult GetXMLData()
        //{
        //    HttpWebRequest request = WebRequest.CreateHttp("http://forecast.weather.gov/MapClick.php?lat=38.4247341&lon=-86.9624086&FcstType=xml");

        //    //those numbers are the logitute and latitude

        //    request.UserAgent = @"User-Agent: Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";

        //    //request.Headers.Add("X-Mashape-Key", "235yfhefui4343");

        //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        //    //access data coming from the response (http response body)

        //    StreamReader rd = new StreamReader(response.GetResponseStream());

        //    string data = rd.ReadToEnd();

        //    XmlDocument XMLdata = new XmlDocument();

        //    XMLdata.LoadXml(data); //parse text into the xml document object

        //    XMLdata.GetElementsByTagName("text");

        //    //XMLdata["Forecast"]["period"]["text"]

        //    ViewBag.TextData = XMLdata.GetElementsByTagName("text");

        //    ViewBag.Time = XMLdata.GetElementsByTagName("valid");

        //    return View();
        //}
    }
}