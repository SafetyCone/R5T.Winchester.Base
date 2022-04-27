using System;using R5T.T0064;


namespace R5T.Winchester
{[ServiceDefinitionMarker]
    public interface ITestingtDataDirectoryPathProvider:IServiceDefinition
    {
        string GetTestingDataDirectoryPath();
    }
}
