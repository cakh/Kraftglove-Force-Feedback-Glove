# Kraftglove-Force-Feedback-Glove
This repo contains the hardware and software files to build Kraftglove - a VR glove that helps you interact with virtual objects and provides binary force feedback to four fingertips. Each component can be manufactured with a 3D printer or are availabe as norm components (bearings, sensors, actuators etc.). The total cost of manufacturing the glove is around 250€ and it weighs around 650g.

# Working
The working of the first prototype can be seen in this video: [link](https://tuc.cloud/index.php/s/GKymDdmrFFk3KKa) 
# Hardware
The CAD files (Creo) and the STEP file can be found in the hardware folder. Each component can be exported as STL and printed on a 3D-printer. If the project gains attention, the files will be exported as STL and saved in the corresponding folder.

# Software
The unity folder can be downloaded and the scene opened by clicking on play.

# Microcontroller
The microcontroller used here is from tinkerforge https://tinkerforge.com/ . Tinkerforge was chosen for the easeness of prototyping. The total cost of the project can be decreased to less than 130€ by using an arduino instead (the programs have to be optimised for arduino).

# Sensors and Actuators
There are four Tinkerforfe potentiometers to measure bending of fingers. An IMU-sensor (Tinkerforge) measures the orientation of the hand. An Oculus-Quest controller attached to arm measures hand position.

# Detailed description
As of now, a detailed description of the project, its assembly, the software and hardware are not provided, as it is unknown if the project will catch enough attention. But upon demand, the documentation will be expanded so that anyone can assemble and use the haptic glove.
