using System;
using System.Text.RegularExpressions;

namespace DotEnv;

public class ConnectionString
{
    private string _text;

    public ConnectionString(IEnv env)
    {
        var uid = env.Get("DB_USER");
        var server = env.Get("DB_HOST");
        var port = env.Get("DB_PORT");
        var psswd = env.Get("DB_PASSWORD");
        var database = env.Get("DB_DATABASE");

        _text = $"Server={server},{port};User Id={uid};"
        + $"Password={psswd};Database={database};"
        + $"Encrypt=True;Trusted_Connection=True;";
    }

    public override string ToString()
    {
        return _text;
    }
}
