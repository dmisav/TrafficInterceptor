using System;

namespace TrafficInterceptor.Domain;

public interface IProtocolProvider
{
    IEnumerable<string> GetProtocolNames();
}
