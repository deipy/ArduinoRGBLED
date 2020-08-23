//These are the functions used in Serial_LED.ino
//getValue is essentially a string.Split(), it splits strings into substrings with a char separator
//SetAllLeds sets all leds to a specific color
//SetLedGroup sets a group of leds (or single led if your strip is completely addressable) to a certain color
//Pulse handles the pulsing mode
//Swipe handles the swiping mode
//ScrollHue handles the scrolling hue from 0° to 360° for the cycle mode
//hsv2rgb converts hsv colors to rgb output for the cycle mode


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

void Pulse(){
  setAllLeds(r,g,b);
  for(int i=0; i<NUM_LEDS; i++){
    setLedGroup(i, sr, sg, sb);
    delay(interval); 
  }
  delay(long_interval);
  for(int i=0; i<NUM_LEDS; i++){
    setLedGroup(i, r, g, b);
    if(debug){Serial.println("waiting for (interval)(ms):"+String(interval));}
    delay(interval);
  }
  if(debug){Serial.println("waiting for (long_interval)(ms):"+String(interval));}
  delay(long_interval);
  
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
  if(debug){Serial.println("debug : ScrollHue()");}
  hue+=1;
  if(hue > 360){
    hue=0;
  }
  if(debug){Serial.println("Hue :"+String(hue));}
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
