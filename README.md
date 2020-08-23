# Arduino-RGB-LED-Strip-Controller
Control 3Pins RGB LED Strips with an arduino, through the serial port, using the FastLED library

# How To Use
Upload the sketch to your aduino, be sure to have the DIn pin of your led strip connected to the D7 pin of the arduino, and to change the NUM_LEDS variable according to the size of your RGB LED strip, for instance if you have a controller per LED, NUM_LEDS should be the total number of LEDS, starting at 1, or if like in my case each controller controls several LEDS, count the number of controllers
The LEDs should now respond to commands through the Serial Port : 
  color$r$g$b : Sets all the leds to a specific color (r,g,b)
  mode_cycle$interval : Cycles through every color hue, interval is the delay in ms between each degrees on the hue wheel
  mode_swipe$r1$g1$b1$r2$g2$b2$interval : Sets all leds to r1g1b1, and runs r2g2b2 color to all leds one by one, interval is the time in ms between each led
  setGroup$index$r$g$b : sets a LED or group of leds at index to a specific color
  CTRLR : arduino replies "200", this is for connecting to software on the computer, to avoid sending commands to other devices using com ports.

# VStudio
You can use the .exe or build the VStudio solution to have an app instead or typing command through the serial ports. The app also includes a text input function.
