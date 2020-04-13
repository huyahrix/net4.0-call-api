using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace test_notify_api
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TargetFrameworkVersion: v4.0\n");
            Console.Title = "Test api";
        excutte:
            // Create a request for the URL.   
            //// curl -v http://192.168.1.109:6060/api/otification/badge
            //WebRequest request = WebRequest.Create(
            //  "http://192.168.1.109:6060/api/otification/badge");
            //request.Credentials = CredentialCache.DefaultCredentials;


            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.1.109:6060/api/notification/push");
            myHttpWebRequest.Method = "PUT";
            myHttpWebRequest.ContentType = "application/json";
            //myHttpWebRequest.ContentType = "application /x-www-form-urlencoded";
            myHttpWebRequest.Headers.Add("token", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6NSwiY3JlYXRlZEF0IjoiMjAyMC0wNC0wMVQxMToyMToyMC4yOTBaIiwidXBkYXRlZEF0IjoiMjAyMC0wNC0wOVQwMzoxMjozNy42NTZaIiwiZXhwaXJlZEF0IjoiMjAyMC0wNC0xOVQwMzoxMjozNy42NTVaIiwidXNlciI6eyJpZCI6MTksIlVzZXJBY2NvdW50IjoiMDAxNTAiLCJVc2VyTmFtZSI6Ik5o4buvIEhp4bq_dSJ9LCJpYXQiOjE1ODY0MDE5NTcsImV4cCI6MTU4ODk5Mzk1N30.FlPlEa0NCfmzU4mnoJoPj_3gMeLwF_4KR_MPzFTA27U");

            using (var streamWriter = new StreamWriter(myHttpWebRequest.GetRequestStream()))
            {
                //var keyValues = new Dictionary<string, string>
                //   {
                //       { "one", "First" },
                //       { "two", "Second" },
                //       { "three", "Third" },
                //   };
                var data = new List<notify>();
                data.Add(new notify { 
                    title = "notify test", 
                    titleE = "Notification from Lemon ERP", 
                    body = "Thông báo từ ERP",
                    bodyE = "",
                    sender= "LEMONADMIN",
                    consumer = "LEMONADMIN",
                    type = "SPECIAL",
                    AppID = "WHRP",
                    form_id = "A07F1001",
                    voucher_id = "71C502AC-9339-46AD-8897-C1F5A2AD832C",
                    voucher_des = "Đã duyệt test yccu",
                    voucher_desE = "",
                    voucher_no = "",
                    URL = "file/D-01-TAILIEU-z-HINH-Hinh-dai-dien-officeMe.jpg?path=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJyZXN1bHQiOlt7InBhdGgiOiIvMjAxOS8wNS83OWQwZjU4MmM2NTExZGJhMGNhMDY2YWM1NGRkZTRkNy5qcGciLCJvcmlnaW5hbEZpbGVOYW1lIjoiRC0wMS1UQUlMSUVVLXotSElOSC1IaW5oLWRhaS1kaWVuLW9mZmljZU1lLmpwZyIsInB1cmwiOiJodHRwczovL2Fwcmljb3QuZGlnaW5ldC5jb20udm4vY2RuLWRldiIsIml1cmwiOiJodHRwOi8vMTAuMC4wLjk5OjYwNDAvdjEifV0sImlhdCI6MTU3NjAzNDM1NiwiZXhwIjo4Nzk3NjAzNDM1Nn0._ijxLHNUKypgILRuQTaVEzrrMjvlAc-_kEsOTMwHbZk",
                    sender_name = "Đây là LEMONADMIN",
                    action = "WEB"
                });
                data.Add(new notify
                {
                    title = "notify test",
                    titleE = "Notification from Lemon ERP",
                    body = "Thông báo từ ERP",
                    bodyE = "",
                    sender = "LEMONADMIN",
                    consumer = "LEMONADMIN",
                    type = "SPECIAL",
                    AppID = "WHRP",
                    form_id = "A07F1001",
                    voucher_id = "71C502AC-9339-46AD-8897-C1F5A2AD832C",
                    voucher_des = "Đã duyệt test yccu",
                    voucher_desE = "",
                    voucher_no = "",
                    URL = "file/D-01-TAILIEU-z-HINH-Hinh-dai-dien-officeMe.jpg?path=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJyZXN1bHQiOlt7InBhdGgiOiIvMjAxOS8wNS83OWQwZjU4MmM2NTExZGJhMGNhMDY2YWM1NGRkZTRkNy5qcGciLCJvcmlnaW5hbEZpbGVOYW1lIjoiRC0wMS1UQUlMSUVVLXotSElOSC1IaW5oLWRhaS1kaWVuLW9mZmljZU1lLmpwZyIsInB1cmwiOiJodHRwczovL2Fwcmljb3QuZGlnaW5ldC5jb20udm4vY2RuLWRldiIsIml1cmwiOiJodHRwOi8vMTAuMC4wLjk5OjYwNDAvdjEifV0sImlhdCI6MTU3NjAzNDM1NiwiZXhwIjo4Nzk3NjAzNDM1Nn0._ijxLHNUKypgILRuQTaVEzrrMjvlAc-_kEsOTMwHbZk",
                    sender_name = "Đây là LEMONADMIN",
                    action = "WEB"
                });
                data.Add(new notify
                {
                    title = "notify test",
                    titleE = "Notification from Lemon ERP",
                    body = "Thông báo từ ERP",
                    bodyE = "",
                    sender = "LEMONADMIN",
                    consumer = "LEMONADMIN",
                    type = "SPECIAL",
                    AppID = "WHRP",
                    form_id = "A07F1001",
                    voucher_id = "71C502AC-9339-46AD-8897-C1F5A2AD832C",
                    voucher_des = "Đã duyệt test yccu",
                    voucher_desE = "",
                    voucher_no = "",
                    URL = "file/D-01-TAILIEU-z-HINH-Hinh-dai-dien-officeMe.jpg?path=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJyZXN1bHQiOlt7InBhdGgiOiIvMjAxOS8wNS83OWQwZjU4MmM2NTExZGJhMGNhMDY2YWM1NGRkZTRkNy5qcGciLCJvcmlnaW5hbEZpbGVOYW1lIjoiRC0wMS1UQUlMSUVVLXotSElOSC1IaW5oLWRhaS1kaWVuLW9mZmljZU1lLmpwZyIsInB1cmwiOiJodHRwczovL2Fwcmljb3QuZGlnaW5ldC5jb20udm4vY2RuLWRldiIsIml1cmwiOiJodHRwOi8vMTAuMC4wLjk5OjYwNDAvdjEifV0sImlhdCI6MTU3NjAzNDM1NiwiZXhwIjo4Nzk3NjAzNDM1Nn0._ijxLHNUKypgILRuQTaVEzrrMjvlAc-_kEsOTMwHbZk",
                    sender_name = "Đây là LEMONADMIN",
                    action = "WEB"
                });
                var arrayJsonData = new JavaScriptSerializer().Serialize(data);
                string json = new JavaScriptSerializer().Serialize(new{data = arrayJsonData });
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            Console.WriteLine(myHttpWebRequest.Headers);
            try
            {
                WebResponse response = myHttpWebRequest.GetResponse();
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    Console.WriteLine(responseFromServer);
                }
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            System.ConsoleKeyInfo i = Console.ReadKey();
            if (i.Key == ConsoleKey.Escape)
            {
                return;
            }
            Console.Clear();
            goto excutte;
        }
    }
}
