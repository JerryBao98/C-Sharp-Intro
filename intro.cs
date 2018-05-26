

namespace Name
{
    public class HTTPCookie
    {
        //keys and values are both of type string
        private Dictionary<string, string> _dictionary

        public HTTPCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get {
                return _dictionary[key];
            }
            set {
                _dictionary[key] = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args) 
        {  
        }
    }
}