#include "ESP8266WiFi.h"

char inputChar;
String inString= "";
int waitTime = 600;
int scans = 1;
void setup() {
  Serial.begin(9600);
  WiFi.mode(WIFI_STA);
  WiFi.disconnect();
  delay(100);
  Serial.println("Setup done");
}

void loop() {
  if (Serial.available() > 0) {
    inString = Serial.readString();
    if (inString.equals("scan")) {
      Serial.println("howmany");
      scans = Serial.readString().toInt();
      Serial.println("busy");
      for (int j = 0; j < scans; j++) {
        delay(waitTime);
        int n = WiFi.scanNetworks();
        for (int i = 0; i < n; ++i) {
          if (WiFi.SSID(i).startsWith("ESP")) {
            Serial.print(WiFi.SSID(i));
            Serial.println(WiFi.RSSI(i));
          }
        }
        
        Serial.println(j);
      }
      Serial.println("done");
    }
  }
}

//Out of void loop



