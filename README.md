# Unity Plugin to update Google Sparse Hashtable Library

## Download the plugin

## Import the package
In Unity Editor, select Assets > Import Package > Custom Package 

## Select all files
In the plugin file import selection popup, select all and click import

## Building your project
To build your project with the new hashtable lib, you will need to export an Android Studio project and build it using Android Studio, to do that, select File > Build Profiles

## Build Profiles popup
In the Build Profiles popup, scroll to Platform Settings and tick export project

## Exported Android Studio project
In the exported Android Studio project, noticed that sparsepp has been added to the external folder
And also, il2cppHashMap.h and il2cppHashSet.h has been modified to use the version from sparsepp
You can continue building your project from Android Studio as usual.
