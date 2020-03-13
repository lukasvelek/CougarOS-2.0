# CougarOS 2.0
A brand new version of the newly stopped project "CougarOS". This is a whole new project where everything I created in CougarOS will be rewritten.

## Introduction
This is a project by an high school student, me, where I try to create an "operating system" running in the Windows environment. As for now it'll be only available for Windows. But I'm planning to create the standalone version with own booting proccess - long story short, it will be bootable and runnable standalone.

## Short Info
- Project started on March 13th 2020

## Project Files Management
This whole project has been split into several (for now only 2) categories or subprojects:

 - Kernel (the core functions of the system)
 - System's own interface (the project defining how will the user operate with the OS)

## Why was the CougarOS 1.0 Project stopped
Mostly because it's Kernel to UI implementation problems. Most OS-es work like this:
	(HARDWARE) <=> KERNEL <=> UI
The hardware part won't be mentioned here because this is being driven by Windows for now. But user operates with the UI and the UI than calls functions in Kernel. So, the kernel could be taken away and be used by another UI. But CougarOS didn't work like this. It was both coded together and therefore is unsplittable.
