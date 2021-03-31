# GOOP
Object-Oriented Design Class Project Repository for Graduating Object-Oriented Programmers

Class diagrams of each component and Component/Data Flow diagrams can be found in GOOP\Class_Diagrams

Source Code can be found in GOOP\mosquito\mosquito.sln to open the whole project.
The program is created in Visual Studio 2019.

Goal: Prevent users from being distracted by applications on their PC when trying to do work on the PC.

How To:
1. First time using: Click the "First Time Set Up" button. This will search for all executable files installed on the PC. (make sure to hit the ok button for the loading screen)
   (may take a minute or 2; may say not responding in task manager but it is still loading) If not first time using, open the Application Manager or Task Viewer.
2. Application Manager opens up when the files are all gathered. From the Installed executables list on the right, enter the number of the application you find distracting.
   Executables are sorted in alphabetical order so it should be easy to find. Can delete from the list by inserting the exact program name in the bad app list on the left. 
3. Enter the Task Viewer. Create tasks that you plan to accomplish for your assignment/work. Hit start when ready to begin working.
4. When in Start Mode, if an application running is on the Bad App List, popups will appear to deter your distraction. 3 levels of popups: normal forms, captcha with pics, buttons
5. When tasks are completed, enter them to add time to the Reward Time. This time can be used to take a break from work and go on the Bad Application from the list. Once the timer
   is finished, the application preventor will activate again and ensue popups.
6. When all tasks are completed, the program can be closed.


Background:
Installed executables found by checking the program files of all drivers on the PC.
All lists are saved to the Desktop as a .txt file.
All forms except for the popup windows from the System Preventer have the same GUI format.
The Application Detector periodically calls a function to the task manager to retrieve running applications.
This is compared to the Bad App List that the user creates for matches.
If there are any matches, the System Preventer is activated by creating new popups.
The Progress Tracker takes in the user's tasks and saves them to a file for future use. Once tasks are completed, time is added to the Task Reward time.
The Task Rewarder disables the System Preventer for a set amount of time so the user can access the Bad Apps.
