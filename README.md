# Arduino-RGB-LED-Strip-Controller
Control 3Pins RGB LED Strips with an arduino, through the serial port, using the FastLED library

# How To Use
Upload the sketch to your aduino, be sure to have the DIn pin of your led strip connected to the D7 pin of the arduino, and to change the NUM_LEDS variable according to the size of your RGB LED strip, for instance if you have a controller per LED, NUM_LEDS should be the total number of LEDS, starting at 1, or if like in my case each controller controls several LEDS, count the number of controllers
The LEDs react to commands sent via the serial port, check the beginning of the .ino file for a list of commands and their description, don't forget to send a "CTLR" to handshake connection with the arduino, as it waits for this confirmation before reacting to commands 

# VStudio
You can use the .exe or build the VStudio solution to have an app instead or typing command through the serial ports. The app also includes a text input function.
