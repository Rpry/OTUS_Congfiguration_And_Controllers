using System.ComponentModel.DataAnnotations;

namespace WebApi.Settings
{
    public class Options
    {
        //[MinLength(20)]
        public string SomeParam { get; set; }

        public RedisOptions RedisOptions { get; set; }
    }
}