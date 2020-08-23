#include <FastLED.h>

#define LED_PIN 7
#define NUM_LEDS 4

CRGB leds[NUM_LEDS];

int r=0;    //primary color
int g=0;
int b=0;

int sr=0;    //secondary color   (used for swiping mode)
int sg=0;
int sb=0;

int group=0;

float hue=0;

int interval=500;

int swipe_index=1; //first group to be set to secondary color; FastLED counts from 1 to NUM_LEDS

bool cycle = false;   //is cycling activated
bool swipe = false;   //is swiping activated

String message;    //String variable for the message from the Serial port

void setup() {
  FastLED.addLeds<WS2812, LED_PIN, GRB>(leds, NUM_LEDS);
  Serial.begin(9600);
  //Serial.setTimeout(1500);
}

void loop() {
   if(Serial.available() > 0){ //Handling incoming messages
    message = Serial.readString();
    
    if(message.indexOf("CTRLR")>=0){
     Serial.println("200"); 
    }
    else if(message.indexOf("color$")>=0){
      swipe=false;
      cycle=false;
      r=getValue(message, '$', 1).toInt();
      g=getValue(message, '$', 2).toInt();
      b=getValue(message, '$', 3).toInt();
      setAllLeds(r,g,b);
    } 
    else if(message.indexOf("setGroup$")>=0){
      group=getValue(message, '$', 1).toInt();
      r=getValue(message, '$', 2).toInt();
      g=getValue(message, '$', 3).toInt();
      b=getValue(message, '$', 4).toInt();
      setLedGroup(group, r, g, b);
    }
    else if(message.indexOf("mode_cycle$")>=0){
      cycle = true;
      if(swipe){
        swipe = false;
      }
      interval=getValue(message, '$', 1).toInt();
    }
    else if(message.indexOf("mode_swipe$")>=0){
      swipe=true;
      if(cycle){
        cycle = false;
      }
      r=getValue(message, '$', 1).toInt();
      g=getValue(message, '$', 2).toInt();
      b=getValue(message, '$', 3).toInt();
      sr=getValue(message, '$', 4).toInt();
      sg=getValue(message, '$', 5).toInt();
      sb=getValue(message, '$', 6).toInt();
      interval=getValue(message, '$', 7).toInt();
    }
   }
   message="";

   if(cycle){ //handling cycling mode
    if(millis()%interval ==0){
     ScrollHue();  
    }        
   }
   if(swipe){  //handling swiping mode
    if(millis()%interval == 0){
      Swipe();
    }
   }
}

String getValue(String data, char separator, int index){ //function to split string into substrings at '$'
  int found = 0;
  int strIndex[] = {0, -1};
  int maxIndex = data.length()-1;

  for(int i=0; i<=maxIndex && found<=index; i++){
    if(data.charAt(i)==separator || i==maxIndex){
        found++;
        strIndex[0] = strIndex[1]+1;
        strIndex[1] = (i == maxIndex) ? i+1 : i;
    }
  }

  return found>index ? data.substring(strIndex[0], strIndex[1]) : "";
}

void setAllLeds(int red, int green, int blue){   //set all leds to a specific color
  
    for (int i = 0; i < NUM_LEDS; i++) {
        leds[i] = CRGB (red, blue, green);
        FastLED.show();
    }  
}

void setLedGroup(int group_index, int red, int green, int blue){
  leds[group_index] = CRGB (red, blue, green);
  FastLED.show();
}

void Swipe(){  //handling swiping
  group+=1;
  if(group==NUM_LEDS){
    group=0;
  }
  setAllLeds(r,g,b);
  setLedGroup(group, sr, sg, sb);
}

void ScrollHue(){ //handling cycling colors
  hue+=1;
  if(hue > 360){
    hue=0;
  }
  hsv2rgb(hue, 1, 1);
  setAllLeds(r,g,b);
}
 
void hsv2rgb(float h, float s, float v){ //HSV to RGB converter to make cycling easier
   float c = v *s ;
   float x = c * ( 1 - abs(fmod((h/60), 2)-1));
   float m = v - c;

   if(h<60 && h>=0){
    r=(c+m)*255;
    g=(x+m)*255;
    b=(0+m)*255;
   }
   else if (h<120 && h>=60){
    r=(x+m)*255;
    g=(c+m)*255;
    b=(0+m)*255;
   }
   else if (h<180 && h>=120){
    r=(0+m)*255;
    g=(c+m)*255;
    b=(x+m)*255;
   }
   else if (h<240 && h>=180){
    r=(0+m)*255;
    g=(x+m)*255;
    b=(c+m)*255;
   }
   else if (h<300 && h>=240){
    r=(x+m)*255;
    g=(0+m)*255;
    b=(c+m)*255;
   }
   else if(h<360 && h>=300){
    r=(c+m)*255;
    g=(0+m)*255;
    b=(x+m)*255;
   }
}
