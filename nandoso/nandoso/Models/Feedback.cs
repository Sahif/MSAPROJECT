using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
namespace nandoso.Models
{
    public class Feedback
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string feedback { get; set; }
    }
}