using System;
using System.Text.RegularExpressions;

namespace ToolKit;

public interface IEnv
{
    public string Get(string key);

    public void Set(string key, string value);
}