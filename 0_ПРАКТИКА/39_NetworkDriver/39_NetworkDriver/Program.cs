using ManagedNativeWifi;


var arr = EnumerateNetworkSsids();
Console.WriteLine();

IEnumerable<string> EnumerateNetworkSsids()
{
    return NativeWifi.EnumerateAvailableNetworkSsids()
        .Select(x => x.ToString()); // UTF-8 string representation
}

