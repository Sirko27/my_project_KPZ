using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр10
{
    class Logger
    {
        static Logger _instance;

        Logger()
        {

        }

        public static Logger getInstance()
        {
            if (_instance == null)
                _instance = new Logger();
            return _instance;
        }

        List<string> _text = new List<string>();

        public void Logging(string _txt)
        {
            _text.Add(DateTime.Now.ToString() + ": " + _txt);
        }

        public string getLog()
        {
            return String.Join("\n", _text.ToArray());
        }
    }
}