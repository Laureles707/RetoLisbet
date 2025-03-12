namespace RetoLisbet.Models
{
    public class Datos
    {
        public Name name { get; set; }
        public string gender { get; set; }
        public location location { get; set; }
        public string email { get; set; }
        public Picture picture { get; set; }

    }

    public class Name
    {
        public string tittle { get; set; }
        public string first { get; set; }
        public string last { get; set; }
    }

    public class location
    {
        public Street street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string postcode { get; set; }
        public Coordinates coordinates { get; set; }

    }

    public class Street
    {
        public string number { get; set; }
        public string name { get; set; }

    }
    public class Coordinates
    {
        public string latitude { get; set; }
        public string longitude { get; set; }

    }
    public class Timezone
    {
        public string offset { get; set; }
        public string description { get; set; }

    }

    public class Picture
    {
        public string large { get; set; }

    }
}