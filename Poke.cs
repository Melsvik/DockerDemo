namespace DockerDemoPoker
{
    public class Poke
    {
        public string Name { get; set; }
        public string Token { get; set; }

        public Poke(string name, string token)
        {
            Name = name;
            Token = token;
        }
    }
}
