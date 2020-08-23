//--------------------------------------Summary of commands------------------------------
//
//             Command                                  Description
//
//CTRLR                                                 Arduino will reply "200", this is a handshake command to allow softwares to identify which arduino is running this code
//color$r$g$b                                           sets all leds to a certain color
//setGroup$index$r$g$b                                  sets specified group to a certain color
//mode_cycle$interval                                   cycles through all hues, waiting (interval)(ms) between every degree increment
//mode_swipe$r1$g1$b1$r2$g2$b2$interval                 sets r1g1b1 as background color and swipes r2g2b2 across, waiting (interval)(ms) between each groups of leds (or leds if your strip is single addressable)
//mode_pulse$r1$g1$b1$r2$g2$b2$interval$long_interval   sets r1g1b1 to all groups, waiting (interval)(ms) between each, then waits for (long_interval)(ms) and does the same with r2g2b2
//debug_true or debug_false                             changes debug mode, if true, will print a bunch of info to the serial port, default if false
//
//---------------------To Do
//mode_pulse needs some rewrite to eliminate the delay() functions to wait for interval and long_interval between loops.
//Add more commands, i guess.

#include <FastLED.h>
#define LED_PIN 7
#define NUM_LEDS 4    //change this according to how many leds or groups of leds you have

CRGB leds[NUM_LEDS];

int r=0;    //primary color
int g=0;
int b=0;

int sr=0;    //secondary color   (used for swiping mode)
int sg=0;
int sb=0;

int group=0;
int swipe_index=0; //first group to be set to secondary color; FastLED counts from 1 to NUM_LEDS

float hue=0;

int interval=500;
int long_interval = 3000;

bool debug=false;     //is debugging enabled
bool cycle = false;   //is cycling enabled
bool swipe = false;   //is swiping enabled
bool pulse = false;   //is pulsing enabled

String message;    //String variable for the message from the Serial port

void setup() {
  FastLED.addLeds<WS2812, LED_PIN, GRB>(leds, NUM_LEDS); //initiate the LED strip using FastLED
  Serial.begin(9600);
}

void loop() {
   if(Serial.available() > 0){ //Handling incoming messages
    message = Serial.readString();
    //Handling different commands
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
      if(pulse){
        pulse=false;
      }
      interval=getValue(message, '$', 1).toInt();
    }
    else if(message.indexOf("mode_swipe$")>=0){
      swipe=true;
      if(cycle){
        cycle = false;
      }
      if(pulse){
        pulse=false;
      }
      r=getValue(message, '$', 1).toInt();
      g=getValue(message, '$', 2).toInt();
      b=getValue(message, '$', 3).toInt();
      sr=getValue(message, '$', 4).toInt();
      sg=getValue(message, '$', 5).toInt();
      sb=getValue(message, '$', 6).toInt();
      interval=getValue(message, '$', 7).toInt();
    }
    else if(message.indexOf("mode_pulse$")>=0){
      pulse=true;
      if(cycle){
        cycle = false;
      }
      if(swipe){
        swipe = false;
      }
      r=getValue(message, '$', 1).toInt();
      g=getValue(message, '$', 2).toInt();
      b=getValue(message, '$', 3).toInt();
      sr=getValue(message, '$', 4).toInt();
      sg=getValue(message, '$', 5).toInt();
      sb=getValue(message, '$', 6).toInt();
      interval=getValue(message, '$', 7).toInt();
      long_interval=getValue(message, '$', 8).toInt();   
    }
    else if(message.indexOf("debug_true")>=0){
      debug=true;
    }
    else if(message.indexOf("debug_false")>=0){
      debug=false;
    }
   }
   message="";
   if(millis()%interval==0){  //doing actions every interval ms
    if(cycle){
      ScrollHue(); //scroll hue if cycle mode is activated, every interval
    }
    else if(swipe){
      Swipe(); //execute swipe() if swipe is true
    }
    else if(pulse){
      Pulse(); //execute pulse if pulse is true;
    }
   }
}
