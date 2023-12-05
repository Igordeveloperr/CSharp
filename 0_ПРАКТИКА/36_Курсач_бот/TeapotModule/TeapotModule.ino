#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>
#include <ESP8266WebServer.h>
#include <WiFiClientSecureBearSSL.h>

// разделитель для вывода в монитор порта
const String teapotId = "127";
const char *ssid = "жмафон"; 
const char *password = "11111111";
const String BASE_HOST = "http://192.168.0.";
ESP8266WebServer server(80);   
uint8_t relayPin = D1; 

void setup() {
  pinMode(relayPin, OUTPUT);
  digitalWrite(relayPin, LOW);
  Serial.begin(115200);
  delay(1000);
  WiFi.mode(WIFI_OFF);
  delay(1000);
  WiFi.mode(WIFI_STA);
  
  WiFi.begin(ssid, password);//подключаемся к сети
  Serial.println("");

  Serial.print("Connecting");

  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
  }
  Serial.println("");
  Serial.print("Connected to ");
  Serial.println(ssid);
  Serial.print("IP address: ");
  Serial.println(WiFi.localIP()); 

  server.on("/teapotOff", TurnOffTeapot);
  server.on("/teapotOn", TurnOnTeapot);
  server.begin();
  Serial.println("_Server started_");
}

// выкл чайник
void TurnOffTeapot()
{
  digitalWrite(relayPin, LOW);
  server.send(200, "text/html", "teapotOff"); 
}


// вкл чайник
void TurnOnTeapot()
{
  digitalWrite(relayPin, HIGH);
  server.send(200, "text/html", "teapotOn"); 
}

// кидаем запрос на сервак
String SendHttpsReq(String req, String deviceId)
{
 String data="";
 HTTPClient http;
 std::unique_ptr<BearSSL::WiFiClientSecure> myClient(new BearSSL::WiFiClientSecure);
 myClient -> setInsecure();
 http.begin(*myClient,BASE_HOST+teapotId+req);
 int httpCode = http.GET();
 Serial.println("Status = "+String(httpCode));
 if(httpCode > 0)
 {
  data = http.getString();
 }
 else {Serial.println("Error!!!");}
 http.end();  
 return data;
}

void loop() {
 /*String ans = SendHttpsReq("/home/index");
 Serial.println(ans);
 Serial.println(separator);
 delay(1100);*/
 server.handleClient();    // обработка входящих запросов
}
