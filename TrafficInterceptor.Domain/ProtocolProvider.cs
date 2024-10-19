using System;

namespace TrafficInterceptor.Domain;

public class ProtocolProvider: IProtocolProvider
{
    public IEnumerable<string> GetProtocolNames()
    {
        var lst = new List<string>();
        lst.Add("tcp");
        lst.Add("udp");
        lst.Add("https");
        lst.Add("http");
        
        return lst;
    }
}
