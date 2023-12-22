
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;

/// <summary>
/// Class responsible for handling Appium automation tasks.
/// </summary>
class AppiumAutomation
{
    private AndroidDriver<AndroidElement> driver;

    public AppiumAutomation(AndroidDriver<AndroidElement> driver)
    {
        this.driver = driver;
    }

    /// <summary>
    /// Set up Appium capabilities and connect to the Appium server.
    /// </summary>
    public void InitializeAppium()
    {
        AppiumOptions appiumOptions = new AppiumOptions();

        // Set capabilities (device, app details, etc.)
        SetCapabilities(appiumOptions);

        // Connect to Appium server
        this.driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
    }

    /// <summary>
    /// Set Appium capabilities.
    /// </summary>
    private void SetCapabilities(AppiumOptions appiumOptions)
    {
        // Device properties
        appiumOptions.AddAdditionalCapability("appium:deviceName", "Pixel 6 API 31");
        appiumOptions.AddAdditionalCapability("platformName", "Android");
        appiumOptions.AddAdditionalCapability("appium:udid", "emulator-5554");
        appiumOptions.AddAdditionalCapability("appium:platformVersion", "12.0");

        // Application informations
        appiumOptions.AddAdditionalCapability("appium:appPackage", "com.google.android.apps.messaging");
        appiumOptions.AddAdditionalCapability("appium:appActivity", "com.google.android.apps.messaging.ui.ConversationListActivity");

        // Other settings
        appiumOptions.AddAdditionalCapability("appium:skipUnlock", true);
        appiumOptions.AddAdditionalCapability("appium:noReset", false);
        appiumOptions.AddAdditionalCapability("appium:automationName", "uiautomator2");
    }


    /// <summary>
    /// Find and click the "Start chat" button.
    /// </summary>
    public void ClickStartChatButton()
    {
        string xpathExpression = "//android.widget.Button[@content-desc='Start chat']";
        IWebElement startChatButton = this.driver.FindElement(By.XPath(xpathExpression));
        startChatButton.Click();
    }

    /// <summary>
    /// Close the application session.
    /// </summary>
    public void CloseAppiumSession()
    {
        this.driver.Quit();
    }
}

/// <summary>
/// Main program entry point.
/// </summary>
class Program
{
    static void Main()
    {
        // Create an instance of AppiumAutomation
        AppiumAutomation appiumAutomation = new AppiumAutomation(null); // You can pass a valid AndroidDriver instance here

        // Initialize Appium
        appiumAutomation.InitializeAppium();

        // Click the "Start chat" button
        appiumAutomation.ClickStartChatButton();

        // Print output indicating that the "Start chat" button was found and clicked
        Console.WriteLine("Start chat button found and clicked.");

        // Close the application session
        appiumAutomation.CloseAppiumSession();
    }
}