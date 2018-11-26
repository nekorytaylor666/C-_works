using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebSchoolApi.Models
{
    public class Firebase
    {
        private List<School> _schools = new List<School>(); 
        public string URL { get; set; }
        public Firebase(string url)
        {
            URL = url;
            using (WebClient client = new WebClient())
            {
                string output = client.DownloadString(URL + "educational_institutions/schools.json");
                _schools = JsonConvert.DeserializeObject<List<School>>(output);

            }
            
            
        }
        public Firebase() : this("https://edustats-971fc.firebaseio.com/")
        {
        }
        public string Get()
        {
                return JsonConvert.SerializeObject(_schools);
        }
        public string Top()
        {

            return JsonConvert.SerializeObject(_schools.OrderByDescending(a=>Double.Parse(a.AverageBall)).Take(10));
        }
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(_schools[id]);
        }
        public string Get(string search)
        {
            return JsonConvert.SerializeObject(_schools.Where(a=>string.Format(
                $"{a.Address} {a.Language} {a.Name} {a.Principal}").ToLower().Contains(search.ToLower())));
        }
    }
}
