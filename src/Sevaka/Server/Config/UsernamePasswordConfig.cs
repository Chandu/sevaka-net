namespace Sevaka.Server.Config
{
  public class UsernamePasswordConfig
  {
    public UsernamePasswordConfig(string username, string password)
    {
      Username = username;
      Password = password;
    }

    public string Username { get; }
    public string Password { get; }
  }
}
