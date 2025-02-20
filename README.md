# Password App

## Overview
This C# console application provides two main functionalities:
- **Password Strength Checker:** Evaluates the strength of a given password based on its length and the variety of characters used (lowercase, uppercase, digits, and special characters).
- **Password Generator:** Creates a random password of a specified length (between 8 and 16 characters) ensuring it includes at least one lowercase letter, one uppercase letter, one digit, and one special character.

## How to Run the Program
### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or later)
- A C# compiler (included with the .NET SDK)

### Steps to Run
1. **Clone or Download the Repository:**
   - Use Git or download the ZIP file of the project.

2. **Build the Application:**
   - Open a terminal or command prompt in the project directory.
   - Run the following command to build the project:
     ```bash
     dotnet build
     ```

3. **Run the Application:**
   - Execute the application using:
     ```bash
     dotnet run
     ```
   - Follow the on-screen instructions to either check a password's strength or generate a new password.

## Limitations
- **Educational Use Only:** This tool is provided for educational purposes and should not be used to secure sensitive information.
- **Basic Security Measures:** The password strength checker and generator are basic implementations. They do not include advanced security features needed for high-security environments.
- **Randomness:** The randomness of the generated password is based on the system's built-in random number generator, which may not be suitable for cryptographic applications.

## Responsible Use
- **Potential Misuse:** While designed as an educational tool, the source code can be modified. Users should be aware that modifying or adapting this code for malicious purposes is unethical.
- **False Sense of Security:** The generated passwords and strength evaluations are simplistic and should not be solely relied upon for securing production systems. Users must supplement this tool with industry-standard security practices.
- **User Responsibility:** Always review and test any security-related code thoroughly. Ensure you understand its limitations and do not deploy it in environments where robust security is critical.

## Conclusion
This application serves as a simple demonstration of password generation and evaluation using C#. It is intended solely for educational purposes. For any production or sensitive use, please consider employing more secure, robust, and well-tested solutions.

