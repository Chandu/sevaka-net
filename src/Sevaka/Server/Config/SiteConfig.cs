using System.IO;
using LanguageExt;

namespace Sevaka.Server.Config
{
  public class SiteConfig : ISiteConfig
  {
    public DirectoryInfo ServerRoot { get; set; }
    public Option<UsernamePasswordConfig> usernamePassword { get; set; }
  }
}
