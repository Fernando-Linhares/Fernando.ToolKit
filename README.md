# DotEnv For Dotnet

Simple and fast configuration of dotenv file for your web application follow this is steps to use in your project

## EXAMPLE
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

To get the env vars you can use the ```Env``` class.

        var env = new DotEnv.Env();

Method used to get the variables ```Get```.

        env.Get("APP_VERSION") // 1.0.0

> This method has a hierarchy to environment variables. Therefore Enviroments variables declared by system is hightest priority instead the variables in ```.env``` file

To override variables you can use the method ```Set```

        env.SET("APP_VERSION", "2.0.0") // 2.0.0

        env.Get("APP_VERSION") // 2.0.0

> It's important to say that the method ```Set```, just override a variable on aplication execution and not in the file dotenv provided.


### Configure file path

Configure the file path passing in attribute ```DotEnvPath``` of object ```Env``` class.

        env.DotEnvPath = "/path/to/file/.env"
