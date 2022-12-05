# Initial Downloads:

Download Git from here: https://git-scm.com/downloads 

Download the 64-bit Installer for Node.js from here: https://nodejs.org/en/download/

Download Visual Studio Code from here: https://code.visualstudio.com/download

If you already have these, then ignore this.


# To Download the repository:

Navigate to the location on your machine in File Explorer that you want to put the repository.

When you are in the location you want to put the repository, left-click once in the file path above and type cmd then press enter.
![CMD Example](https://user-images.githubusercontent.com/51216231/205540239-8c101486-3644-4310-be3f-1d8b08feb74e.png)

In the command line, enter the following: git clone https://github.com/DanielVillarreal4/Capstone.git

Keep the command line open.

To open the repository in Visual Studio Code:

In the command line enter the following: code Capstone


# Prior to coding:

Locate and click the extensions tab on the left side of Visual Studio Code

Search for Vetur and install the one created by Pine Wu

This will allow you to see highlighting and IntelliSense for Vue.


# Prior to running the application:

Go to your application in the firebase console: https://console.firebase.google.com/

Click on your application.

Click on the gear widget to the right of the top left tab named Project Overview.

Then click on Project Settings.

Then copy the code towards the bottom of the page that looks like this: 

var firebaseConfig = {
    apiKey: "Your API Key",
    authDomain: "Your Auth Domain",
    projectId: "Your Project ID",
    storageBucket: "Your Storage Bucket",
    messagingSenderId: "Your Messaging Sender ID",
    appId: "Your AppID",
    measurementId: "Your Measurement ID"
  };
  
  Click on the Visual Studio Code application you have opened, and then click on the Explorer tab in the top left.
  
  Click on the src folder.
  
  Then paste that code you copied into the placeholders in the firebaseInit.js and main.js files.
  
  
# To run the application:

In the tabs at the top of Visual Studio Code, click on the Terminal tab and select the New Terminal option.

This will open a Windows Powershell for the folder. 

Enter the following to install npm for this folder: npm install

Once that is finished to run the application enter the following: npm run serve



# To build for production and get ready to deploy to Firebase:

In the Windows Powershell terminal enter the following: npm run build


# To deploy to Firebase:

Enter the following into the Windows Powershell terminal: cd dist

Next log in with your Google Account that is associated with the Firebase Project with the following: firebase login

Once you are logged in, enter the following: firebase init
  
  Type y and press enter
  
  Choose Hosting: Configure files for Firebase Hosting and (optionally) set up GitHub Action deploys by moving down with arrow keys and selecting by pressing spacebar, then press enter to confirm the selection
  
  Click the enter key on Use an existing project
  
  Click the enter key on the project you want to deploy to
  
  Type . and press the enter key to choose the public directory
  
  Type y to configure as a single-page app

  For "File ./index.html already exists. Overwrite?" type n and press the enter key
  
  Finally to deploy enter the following: firebase deploy
