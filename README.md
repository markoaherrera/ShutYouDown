#﻿ShutYouDown

##Overview
Before I go to sleep I leave my PC ON so that some downloads finish, in the remote past I used GShutdown, and in newer versions I couldn find anything similar, so I made my own python script.
https://github.com/markoaherrera/myscripts/blob/master/pyshut.py


##Objectives.
Shut down Ubuntu PC given a certain amount of time.
Perform a series of tasks before shutting down.
Tasks to perform might have their own timers. 
In the future I would like to perform such tasks immediately but with a remote control.

#Road-map
##Milestone 1

###Parts
* Task Performer 
  * Will only run shutdown at first
  * Each task will have a timer 

####Milestone 1.5
* Implement MEF to run different tasks
  * Copy Files from temp popcorn-time temp directory.

##Milestone 2
PC Form application
* Manage list of tasks and times for each task

##Milestone 3
Web application
* Implement using OWIN, so that I can plug a remote mobile app later on.

##Milestone 4
Android Remote control








