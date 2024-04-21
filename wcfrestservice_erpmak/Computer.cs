namespace MyRESTService.Core
{
    public class Computer
    {
        public string CPU { get; set; } = string.Empty;
        public string GPU { get; set; } = string.Empty;
        public string Memory { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"CPU: {CPU}, GPU: {GPU}, Memory: {Memory}";
        }
    }
}
