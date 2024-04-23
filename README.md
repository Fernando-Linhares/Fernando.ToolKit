# ToolKit For Dotnet by Fernando L. Silvestre

Simple and fast configuration of dotenv file for your web application follow this is steps to use in your project

## DotEnv

#### File Example
.env.example

    # APPLICATION
    APP_VERSION=
    APP_KEY=
    APP_FOULDER=

    # DATABASE
    DB_HOST=
    DB_PORT=
    DB_USER=
    DB_PASSWORD=
    DB_DATABASE=


### Steps

Copy file .env.example and rename .env
####
Apply you configurations vars

#### Use class Env

To get the env vars you can use the ```ToolKit.Env``` class.

        using ToolKit;

        var env = Env();

Method used to get the variables ```Get```.

        env.Get("APP_VERSION") // 1.0.0

> This method has a hierarchy to environment variables. Therefore Enviroments variables declared by system is hightest priority instead the variables in ```.env``` file

To override variables you can use the method ```Set```

        env.SET("APP_VERSION", "2.0.0") // 2.0.0

        env.Get("APP_VERSION") // 2.0.0

> It's important to say that the method ```Set```, just override a variable on aplication execution and not in the file dotenv provided.


### Configure file path

Configure the file path passing in attribute ```DotEnvPath``` of object ```ToolKit.Env``` class.

        env.DotEnvPath = "/path/to/file/.env"

## Connection String

You must use the class ```ToolKit.ConnectionString``` with a ```ToolKit.IEnv``` 

###
Example:

        using ToolKit;

        var env = new Env();

        var connection = new ConnectionString(env);

        Console.WriteLine(connection);

        //outputs:  Server=[ENV_SERVER],[ENV_PORT];User Id=[ENV_USER];Password=[ENV_PASSWORD];Database=[ENV_DATABASE];Encrypt=True;Trusted_Connection=True;

Or

        connection.ToString()

        // return: Server=[ENV_SERVER],[ENV_PORT];User Id=[ENV_USER];Password=[ENV_PASSWORD];Database=[ENV_DATABASE];Encrypt=True;Trusted_Connection=True;

