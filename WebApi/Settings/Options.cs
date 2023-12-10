using System.ComponentModel.DataAnnotations;

namespace WebApi.Settings
{
    public class Options
    {
        [MaxLength(5)]
        public string SomeParam { get; set; }

        public RedisOptions RedisOptions { get; set; }
    }
}