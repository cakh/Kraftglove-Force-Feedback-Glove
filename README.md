# Kraftglove-Force-Feedback-Glove
This repo contains the hardware and software files to build Kraftglove - a VR glove that helps you interact with virtual objects and provides binary force feedback to four fingertips. Each component can be manufactured with a 3D printer or are availabe as norm components (bearings, sensors, actuators etc.). The total cost of manufacturing the glove is around 250€ and it weighs around 650g.

# Hardware
The stl data for each component is available in the hardware folder. The BOM as well as detailed assembly will be uploaded if interest is shown on the project. For now, the assembly can be understood by looking at the uploaded CAD files.

# Software
The unity folder can be downloaded and the scene opened by clicking on play.

# Microcontroller
The microcontroller used here is from tinkerforge https://tinkerforge.com/ . Tinkerforge was chosen for the easeness of prototyping. The total cost of the project can be decreased to less than 130€ by using an arduino instead (the programs have to be optimised for arduino).

# Sensors and Actuators
There are four Tinkerforfe potentiometers to measure bending of fingers. An IMU-sensor (Tinkerforge) measures the orientation of the hand. An Oculus-Quest controller attached to arm measures hand position.
