using System;

namespace ToolKit;

public class NotFoundEnvVariableException : Exception 
{
    public NotFoundEnvVariableException(string variable)
        : base($"Not found variable ({variable})")
    {}
}