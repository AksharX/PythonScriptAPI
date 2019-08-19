using System.Collections.Generic;


namespace PythonAPI.Configuration
{
    public class Python
    {
        public Script Script { get; set; }
    }

    public class Script
    {
        public string PathToScript { get; set; }
    }
}