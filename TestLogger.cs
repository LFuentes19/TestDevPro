using System;
using Logger;

//Task 1.1 : Example Tests for Logging functionality
public class LoggerTests
{
    public static void TestLogger()
    {
        // Test INFO message
        Logger.LogMessage("application.log", "User successfully logged in", "INFO");

        // Test WARNING message
        Logger.LogMessage("application.log", "Failed login attempt", "WARNING");

        // Test ERROR message
        Logger.LogMessage("application.log", "Database connection failed", "ERROR");
		
    		//Test Multiple Message Logging same file
    		Logger.LogMessage("application.log", "User logged in", "INFO")
    		Logger.LogMessage("application.log", "Failed login attempt", "WARNING")
    		Logger.LogMessage("application.log", "Database connection failed", "ERROR")
    			
    		//Test Multiple Message Logging different file
    		Logger.LogMessage("errors.log", "Critical error occurred", "CRITICAL")
    		Logger.LogMessage("activity.log", "User performed action A", "INFO")
    }
}
