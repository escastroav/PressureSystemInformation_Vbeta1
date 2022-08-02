int analogValue = 0;
int sampleTime = 1000;
int baudRate = 9600;
int externalBaudRate = 0;
String inputStr = "";
String dataStr = "";
bool completeStr = false;
bool sendingData = false;
bool hasEnded = false;

void setup() {
  pinMode(LED_BUILTIN,OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);
  pinMode(A0,INPUT);
  Serial.begin(baudRate);
}

void loop() {

  if(completeStr)
  {
    inputStr.trim();
    if(inputStr.equals("$On"))
    {
      digitalWrite(LED_BUILTIN, HIGH);  
      sendingData = true;
    }
    if(inputStr.equals("$Off"))
    {
      sendingData = false;
      hasEnded = true;      
      digitalWrite(LED_BUILTIN, LOW);   
    }
   
    if(inputStr[0] == 'S')
    {
      inputStr.remove(0,1);
      sampleTime = inputStr.toInt();      
      if(sampleTime == 0)
      {
        Serial.println("$Invalid sample time");        
        Serial.flush();        
        sendingData = false;
      }
      
    }    
        inputStr = "";
        completeStr = false;
  }
  if(sendingData && !hasEnded)
  {
    analogValue = analogRead(A0);    
    Serial.println(analogValue);
    Serial.flush();
    delay(sampleTime);           
  }
}

void serialEvent()
{
  char inChar;
  while(Serial.available())
  {
    inChar = (char)Serial.read();
    if(inChar == '\n')
    {
      completeStr = true;  
    }
    else
    {
      inputStr+=inChar;
    }
  }
}
