namespace SteveLabs.DockerBuildTest.Service
{
    public sealed class GreetingService
    {
        public string Greet()
        {
            return "Hello";
        }

        public string GreetTo(string to)
        {
            return $"Hello to you {to}";
        }

        public string GreetFrom(string from)
        {
            return $"Hello from {from}";
        }

        public string GreetToFrom(string to, string from)
        {
            return $"Hello to you {to} from {from}";
        }
    }
}
