# AppiumAutomationPOCWithCsharp

This project is an example of Appium automation using C#.

## Prerequisites

Before you begin, ensure you have met the following requirements:

- **Appium Server**: Ensure that Appium server is installed and running on your machine. You can download Appium from [Appium official website](http://appium.io/).

- **Android Emulator or Device**: Make sure you have an Android emulator or device configured and accessible.

- **Visual Studio or Visual Studio Code**: You need a C# development environment to run and modify the code. You can download Visual Studio or Visual Studio Code from [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/).

- **NuGet Packages**: Ensure that the necessary NuGet packages are installed. The required packages are managed automatically by Visual Studio or can be installed manually.

## Running the Project

Follow these steps to run the Appium automation project:

1. Clone the project to your local machine.

2. Open the project in Visual Studio or Visual Studio Code.

3. Build the project to restore the NuGet packages.

4. Open the AppiumAutomation.cs file.

5. Review the InitializeAppium and SetCapabilities methods in the code. Adjust the capabilities based on your specific Appium setup and the target Android application.

6. Make sure Appium server is running on 127.0.0.1:4723. 

7. Run the project.

8. Monitor the console output to ensure that the "Start chat" button is found and clicked.
