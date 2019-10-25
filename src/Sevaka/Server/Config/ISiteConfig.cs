using System.IO;
using LanguageExt;

namespace Sevaka.Server.Config
{
  public interface ISiteConfig
  {
    DirectoryInfo ServerRoot { get; }
    Option<UsernamePasswordConfig> usernamePassword { get; }
  }
}
