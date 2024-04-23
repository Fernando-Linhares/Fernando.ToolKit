using System;
using System.Text.RegularExpressions;

namespace DotEnv;

public class ConnectionString
{
    private string _text;

    public ConnectionString(IEnv env)
    {
        uid = env.Get("DB_USER");
        server = env.Get("DB_HOST");
        port = env.Get("DB_PORT");
        psswd = env.Get("DB_PASSWORD");
        database = env.Get("DB_DATABASE");

        _text = $"Server={server},{port};User Id={uid};"
        + $"Password={psswd};Database={database};"
        + $"Encrypt=True;Trusted_Connection=True;";
    }

    override
    public string ToString()
    {
        return _text;
    }
}