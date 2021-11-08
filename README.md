# GenericExceptions

Universal exceptions to avoid creating your own

[![License: LGPL v3](https://img.shields.io/badge/License-LGPL_3.0-yellow.svg)](https://github.com/c0debeef/GenericExceptions/blob/main/LICENSE)
[![Nuget](https://img.shields.io/nuget/dt/GenericExceptions)](https://www.nuget.org/packages/GenericExceptions/)

**GenericExceptions is a lightweight .NET library developed to solve a common problem. You don't need to implement exceptions anymore. You already have all possible exceptions.**

## Useage

It can be used with existing error codes or new ones.

```csharp
public enum ResultCode
{
    Undefined = 0,
    Success = 1,
    Error = -1
}
//...
try
{
    throw GenericException.Create(ResultCode.Error);
}
catch (GenericException<ResultCode> exception)
{
    Debug.WriteLine(exception.First);
    exception.Throw();
}
```

Create any exceptions that You can think of and catch them.

```csharp
try
{
    throw GenericException.Create(DayOfWeek.Friday, @"Can't work!");
}
catch (GenericException exception)
{
    Debug.WriteLine(exception);
    exception.Throw();
}
```

## Copyright

Copyright (c) c0debeef@gmail.com. See [LICENSE](https://github.com/c0debeef/GenericExceptions/blob/main/LICENSE) for details.
