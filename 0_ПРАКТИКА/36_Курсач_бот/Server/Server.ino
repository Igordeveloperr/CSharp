#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>
#include <ESP8266WebServer.h>
#include "DHT.h"
#define DHTTYPE DHT22

// разделитель для вывода в монитор порта
const String teapotId = "153";
const char *ssid = "жмафон"; 
const char *password = "11111111";
const String BASE_HOST = "http://192.168.0.";
ESP8266WebServer server(80);   
WiFiClient ll;
// датчик DHT
uint8_t DHTPin = D1; 
// инициализация датчика DHT.
DHT dht(DHTPin, DHTTYPE);  

void setup() {
  pinMode(DHTPin, INPUT);
  dht.begin();
  Serial.begin(115200);
  delay(1000);
  WiFi.mode(WIFI_OFF);
  delay(1000);
  WiFi.mode(WIFI_STA);
  
  WiFi.begin(ssid, password);//подключаемся к сети
  Serial.println("");

  Serial.print("Connecting");

  while (WiFi.status() != WL_CONNECTED) {
    Serial.println(".");
  }
  Serial.println("");
  Serial.print("Connected to ");
  Serial.println(ssid);
  Serial.print("IP address: ");
  Serial.println(WiFi.localIP()); 

  server.on("/teapotOff", SendTurnOffTeapotRequest);
  server.on("/teapotOn", SendTurnOnTeapotRequest);
  server.on("/temperature", ReturnTemperature);
  server.on("/humidity", ReturnHumidity);
  server.begin();
  Serial.println("_Server started_");
}

// выкл чайник
void SendTurnOffTeapotRequest()
{
  String answer = SendHttpsReq("/teapotOff", teapotId);
  Serial.println(answer);
  server.send(200, "text/html", answer); 
}

// вкл чайник
void SendTurnOnTeapotRequest()
{
  String answer = SendHttpsReq("/teapotOn", teapotId);
  Serial.println(answer);
  server.send(200, "text/html", answer); 
}

// ответ на запрос получения температуры
void ReturnTemperature()
{
  float Temperature = dht.readTemperature(); // получить значение температуры
  server.send(200, "text/html", String(Temperature)); 
}

// ответ на запрос получения влажности воздуха
void ReturnHumidity()
{
  float Humidity = dht.readHumidity();       // получить значение влажности
  server.send(200, "text/html", String(Humidity)); 
}

// кидаем запрос на сервак
String SendHttpsReq(String req, String deviceId)
{
 String data="";
 Serial.println(BASE_HOST+teapotId+req);
 HTTPClient http;
 http.begin(ll,BASE_HOST+teapotId+req);
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
