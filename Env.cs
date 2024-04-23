using System;
using System.Text.RegularExpressions;

namespace ToolKit;

public class Env: IEnv
{
    public static string DotEnvPath = ".env";

    private Dictionary<string, string>? DataStream;

    public string Get(string key)
    {
        string? val = Environment.GetEnvironmentVariable(key);

        if(val is not null)
        {
            return val;
        }

        val = GetVarByDataStream(key);

        if(val is not null)
        {
            return val;
        }

        throw new NotFoundEnvVariableException(key);
    }

    public void Set(string key, string value)
    {
        Environment.SetEnvironmentVariable(key, value);
    }

    private string? GetVarByDataStream(string key)
    {
        bool hasdotenvfile = File.Exists(Env.DotEnvPath);

        if(hasdotenvfile && DataStream is null)
        {
            string text = File.ReadAllText(Env.DotEnvPath);

            string[] raws = text.Split("\n");

            DataStream = new Dictionary<string, string>();

            foreach(string raw in raws)
            {
                if(IsNotAComment(raw)) 
                {
                    string[] keyval = raw.Split("=");
                   
                    DataStream[keyval[0]] = keyval.Length > 1 ? keyval[1] : "";
                }
            }
        }

        return DataStream.Keys.Contains(key)
            ? DataStream[key]
            : null;
    }

    private bool IsNotAComment(string line)
    {
        string pattern = @"^[#]";

        var regex = new Regex(pattern);

        var match = regex.Match(line);

        return !match.Success;
    }
}