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
            if (to is null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            return $"Hello to you {to}";
        }

        public string GreetFrom(string from)
        {
            if (from is null)
            {
                throw new ArgumentNullException(nameof(from));
            }

            return $"Hello from {from}";
        }

        public string GreetToFrom(string to, string from)
        {
            if (to is null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            if (from is null)
            {
                throw new ArgumentNullException(nameof(from));
            }

            return $"Hello to you {to} from {from}";
        }
    }
}
