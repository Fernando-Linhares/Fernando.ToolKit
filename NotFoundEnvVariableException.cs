using System;

namespace DotEnv;

public class NotFoundEnvVariableException : Exception 
{
    public NotFoundEnvVariableException(string variable)
        : base($"Not found variable ({variable})")
    {}
}