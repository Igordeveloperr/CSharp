#include <ESP8266WiFi.h>
#include <WiFiClientSecure.h> 
#include <ESP8266WebServer.h>
#include <ESP8266HTTPClient.h>

// разделитель для вывода в монитор порта
const String separator = "________________________________________________";

const char *ssid = "MF90PLUS_AD8DDC"; 
const char *password = "4EH6HD5RHD";

const char *host = "localhost:5001";//aspnet-core-mvc.bazanoniefaza.repl.co
const int httpsPort = 80;
// клиент
WiFiClientSecure httpsClient;
//отпечаток SHA-1, который скопировали раньше
const char fingerprint[] PROGMEM = "85 B0 9E D0 2B 41 3E 27 2B 50 7E DF 51 3E 39 54 27 F5 E2 EB";


int t = 0;

void setup() {
  Serial.begin(115200);
  WiFi.mode(WIFI_OFF);
  delay(1000);
  WiFi.mode(WIFI_STA);
  
  WiFi.begin(ssid, password);//подключаемся к сети
  Serial.println("");

  Serial.print("Connecting");

  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }


  Serial.println("");
  Serial.print("Connected to ");
  Serial.println(ssid);
  Serial.print("IP address: ");
  Serial.println(WiFi.localIP()); 
}

// подключаемся к серваку
void ConnectToServer()
{
  Serial.printf("Using fingerprint '%s'\n", fingerprint);
  httpsClient.setFingerprint(fingerprint);
  httpsClient.setTimeout(500); 
  delay(1000);
  //подключение к серверу
  Serial.print("HTTPS Connecting");
  int r=0; 
  while((!httpsClient.connect(host, httpsPort)) && (r < 30)){
      delay(100);
      Serial.print(".");
      r++;
  }
  if(r==30) {
    Serial.println("Connection failed");
  }
  else {
    Serial.println("Connected to web");
  }
  Serial.println(separator);
}

// кидаем запрос и возвращаем ответ в формате строки
String SendRequest(String request)
{
  Serial.print("requesting URL: ");
  Serial.println(host+request);
  // выполняем переход по этой ссылке
  httpsClient.print(String("GET ") + request + " HTTP/1.1\r\n" +
               "Host: " + host + "\r\n" +               
               "Connection: close\r\n\r\n");
  Serial.println("request sent");
                  
  while (httpsClient.connected()) {
    String line = httpsClient.readStringUntil('\n');
    if (line == "\r") {
      Serial.println("headers received");
      break;
    }
  }
  Serial.print("reply:");
  
//в переменную line записываем ответ сервера. В данном случае 0 или 1, команда от телеграм-бота
  String answer;
  while(httpsClient.available()){        
    answer = httpsClient.readStringUntil('\n');
    Serial.println("ANSWER: "+answer);
  }
  Serial.println("closing connection");
  return answer;
}

void loop() { 
  if(t >= 20)
  {
    t = 0;
  }
  else{
    t++;
  }
  ConnectToServer();
  Serial.println(separator);
  String answer = SendRequest("/home/index");
  //Serial.println("ANSWER: " + answer);
  Serial.println(separator);
  delay(500);//ждем 0.5с и повторяем
}
