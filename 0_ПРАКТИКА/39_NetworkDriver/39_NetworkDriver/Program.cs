using SimpleWifi;

const string WIFI_NAME_1 = "MW42V_0866";

Wifi net = new Wifi();

// connection 
AccessPoint accessPoint = net.GetAccessPoints().FirstOrDefault(x => x.Name == WIFI_NAME_1);
if (accessPoint != null && !accessPoint.IsConnected)
{
    accessPoint.Connect(new AuthRequest(accessPoint));
}
Console.WriteLine("Done!");

// disconnected
/*if (net.ConnectionStatus == WifiStatus.Connected)
{
    net.Disconnect();
}

Console.WriteLine("Disconected...");*/