using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    #region 5 - Info
    private static string usersFolder = "users";
    private static string adminUsername = "admin";
    private static string adminPassword = "admin123";
    #endregion
    static void Main()
    {
        #region N1 - Calculator
        // Calculator
        //while (true)
        //{
        //    Console.WriteLine("Enter First Number:");
        //    string input1 = Console.ReadLine();
        //    bool isCorrectFirst = int.TryParse(input1, out int firstNumber);
        //    if (isCorrectFirst)
        //    {
        //        Console.WriteLine($"Parsing successful! The first number is {firstNumber}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Parsing failed. Input is not a valid number.");
        //    }
        //    Console.WriteLine("Enter Symbol:");
        //    char symbol = Convert.ToChar(Console.ReadLine());
        //    //int secondNumber = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Second Number:");
        //    string input2 = Console.ReadLine();
        //    bool isCorreectSecond = int.TryParse(input2, out int secondNumber);
        //    if (isCorreectSecond)
        //    {
        //        Console.WriteLine($"Parsing successful! The second number is {secondNumber}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Parsing failed. Input is not a valid number.");
        //    }
        //    if (isCorrectFirst && isCorreectSecond)
        //    {
        //        if (symbol == '+')
        //        {
        //            Console.WriteLine($"Sum is {firstNumber + secondNumber}");
        //        }
        //        else if (symbol == '-')
        //        {
        //            Console.WriteLine($"Substraction is {firstNumber - secondNumber} ");
        //        }
        //        else if (symbol == '*')
        //        {
        //            Console.WriteLine($"Multiplication is  {firstNumber * secondNumber}");
        //        }
        //        else if (symbol == '/')
        //        {
        //            if (secondNumber != 0)
        //            {

        //                Console.WriteLine($"Division is {firstNumber / secondNumber}");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Not possible to divide on 0");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Input symbol must be one of the +-*/");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Input must be numbers!!");
        //    }

        //    Console.WriteLine("Do you want to continue? yes/no");
        //    string continueInput = Console.ReadLine();
        //    if (continueInput?.ToLower() != "yes")
        //    {
        //        break;
        //    }
        //}
        #endregion

        #region N2 - Guess the number
        //Console.WriteLine("Enter min number");
        //string input1 = Console.ReadLine();
        //bool isCorrectFirst = int.TryParse(input1, out int inputMin);
        //while (!isCorrectFirst)
        //{
        //    Console.WriteLine("Invalid input. Please enter a valid number:");
        //    input1 = Console.ReadLine();
        //    isCorrectFirst = int.TryParse(input1, out inputMin);
        //}

        //Console.WriteLine("Enter max number");
        //string input2 = Console.ReadLine();
        //bool isCorrectSecond = int.TryParse(input2, out int inputMax);
        //while (!isCorrectSecond)
        //{
        //    Console.WriteLine("Invalid input. Please enter a valid number:");
        //    input2 = Console.ReadLine();
        //    isCorrectSecond = int.TryParse(input2, out inputMax);
        //}

        //Random rnd = new Random();
        //int number = rnd.Next(inputMin, inputMax);
        //Console.WriteLine("Number is already generated,now guess!");
        //int lifeNumber = (inputMax - inputMin) / 50 + 5;
        //Console.WriteLine($"You have {lifeNumber} lives!");

        //string userNumber = "0";
        //bool winResult = false;
        //while (Convert.ToInt32(userNumber) != number && lifeNumber > 0)
        //{
        //    Console.WriteLine($"You left {lifeNumber} lives");
        //    userNumber = Console.ReadLine();
        //    bool isCorrectuserNumber = int.TryParse(userNumber, out int userNumb);
        //    while (!isCorrectuserNumber)
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number:");
        //        userNumber = Console.ReadLine();
        //        isCorrectuserNumber = int.TryParse(userNumber, out userNumb);
        //    }
        //    while (userNumb < inputMin || userNumb > inputMax)
        //    {
        //        Console.WriteLine("Out of range. Please enter a valid number:");
        //        userNumber = Console.ReadLine();
        //        isCorrectuserNumber = int.TryParse(userNumber, out userNumb);
        //    }

        //    if (userNumb > number)
        //    {
        //        Console.WriteLine("Your number is greater than generated");
        //        lifeNumber--;
        //    }
        //    else if (userNumb < number)
        //    {
        //        Console.WriteLine("Your number is less than generated");
        //        lifeNumber--;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Congrats! You win!");
        //        winResult = true;
        //        break;
        //    }

        //}
        //if (!winResult)
        //{
        //    Console.WriteLine("You lost. Try again!");
        //}
        #endregion

        #region N3 - Hangman
        //string folderPath = "WordsFolder";
        //string filePath = Path.Combine(folderPath, "words.txt");
        //List<string> list = new List<string>(File.ReadAllLines(filePath));
        //Random r = new Random();
        //int index = r.Next(list.Count);
        //string generatedWord = list[index];
        ////Console.WriteLine(generatedWord);
        //int generatedWordLength = generatedWord.Length;
        //char[] guessedLetters = new char[generatedWordLength];
        //for (int i = 0; i < generatedWordLength; i++)
        //{
        //    guessedLetters[i] = '_';
        //    Console.Write(guessedLetters[i]);
        //}
        //Console.WriteLine();
        //int lifeCount = 5;
        //char userSymbol;
        //while (lifeCount > 0 && guessedLetters.Contains('_'))
        //{
        //    Console.WriteLine("Lives remaining: " + lifeCount);
        //    Console.WriteLine("Guess a letter: ");
        //    userSymbol = Convert.ToChar(Console.ReadLine().ToLower());
        //    Console.WriteLine(userSymbol);
        //    if (guessedLetters.Contains(userSymbol))
        //    {
        //        Console.WriteLine("You already guessed that letter!");
        //        continue;
        //    }
        //    else
        //    {
        //        int check = 0;

        //        for (int i = 0; i < generatedWordLength; i++)
        //        {

        //            if (generatedWord[i] == userSymbol)
        //            {
        //                guessedLetters[i] = userSymbol;
        //                check++;
        //            }
        //        }
        //        if (check == 0)
        //        {
        //            lifeCount--;
        //        }
        //        for (int i = 0; i < generatedWordLength; i++)
        //        {
        //            Console.Write(guessedLetters[i]);
        //        }
        //        Console.WriteLine();
        //    }

        //}
        //if (!guessedLetters.Contains('_'))
        //{
        //    Console.WriteLine("Congratulations! You guessed the word.");
        //}
        //else
        //{
        //    Console.WriteLine("Game Over! The word was: " + generatedWord);
        //}
        #endregion

        #region N5 - Bankomati

        //Directory.CreateDirectory(usersFolder);
        //while (true)
        //{
        //    Console.WriteLine("------ Welcome to the MobileBank ------");
        //    Console.WriteLine("1. Register");
        //    Console.WriteLine("2. Sign In");
        //    Console.WriteLine("3. Administrator");
        //    Console.WriteLine("4. Exit");
        //    Console.Write("Please select an option: ");

        //    string choice = Console.ReadLine();

        //    switch (choice)
        //    {
        //        case "1":
        //            Register();
        //            break;

        //        case "2":
        //            SignIn();
        //            break;

        //        case "3":
        //            AdministratorSignIn();
        //            break;

        //        case "4":
        //            Console.WriteLine("Thank you for using the ATM System. Goodbye!");
        //            return;

        //        default:
        //            Console.WriteLine("Invalid option. Please try again.\n");
        //            break;
        //    }
        //}
        //string currentDirectory = Directory.GetCurrentDirectory();
        //string folderName = "Users";
        //string fileName = "Ekaterine Tchonishvili.txt";
        //string folderPath = Path.Combine(currentDirectory, folderName);
        //string filePath = Path.Combine(folderPath, fileName);
        //int accountMoney = GetAccountMoneyFromFile(filePath);
        //if (accountMoney != -1)
        //{
        //    Console.WriteLine($"Account Money: {accountMoney}");
        //}
        //int addMoney = AddAccountMoney(filePath, 50);
        //if (addMoney != -1)
        //{
        //    Console.WriteLine($"added Money : {addMoney}");
        //}
        //int removeMoney = RemoveMoneyFromAccount(filePath, 20);
        //if (removeMoney != -1)
        //{
        //    Console.WriteLine($"remove Money : {removeMoney}");
        //}
        #endregion

        #region OOP N1
        bool isRunning = true;
        BookManager bookManager = new BookManager();
        Console.WriteLine("Book Management System");
        Console.WriteLine("1. Add a New Book");
        Console.WriteLine("2. View All Books");
        Console.WriteLine("3. Search for a Book by Title");
        Console.WriteLine("4. Exit");

        while (isRunning)
        {
            Console.Write("Choose an option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter Book Name: ");
                    string bookName = Console.ReadLine();
                    Console.WriteLine("Enter Book Author: ");
                    string bookAuthor = Console.ReadLine();
                    Console.WriteLine("Enter Book Release Year: ");
                    int releaseYear = Convert.ToInt32(Console.ReadLine());
                    bookManager.addBook(new Book(bookName, bookAuthor, releaseYear));

                    break;

                case 2:
                    bookManager.getBooksList();
                    break;

                case 3:
                    Console.WriteLine("Which book are you looking for?");
                    string searchTitle = Console.ReadLine();
                    bookManager.searchBook(searchTitle);
                    break;

                case 4:
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        #endregion
    }
    #region  Functions For Exercise 5
    private static void Register()
    {
        Console.Write("\nEnter a username: ");
        string username = Console.ReadLine();

        string userFilePath = Path.Combine(usersFolder, username + ".txt");

        if (File.Exists(userFilePath))
        {
            Console.WriteLine("Username already exists. Please choose a different username.\n");
            return;
        }

        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        // Save user data to file
        File.WriteAllLines(userFilePath, new[] { username, password, "0.00" });
        Console.WriteLine("Registration successful! You can now sign in.\n");
    }
    private static void SignIn()
    {
        Console.Write("\nEnter your username: ");
        string username = Console.ReadLine();

        if (username == adminUsername)
        {
            AdministratorSignIn();
            return;
        }

        string userFilePath = Path.Combine(usersFolder, username + ".txt");

        if (!File.Exists(userFilePath))
        {
            Console.WriteLine("Username not found. Please register first.\n");
            return;
        }

        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        // Read user data
        string[] userData = File.ReadAllLines(userFilePath);
        string storedPassword = userData[1];

        if (storedPassword == password)
        {
            Console.WriteLine("Sign-in successful!\n");
            UserMenu(username);
        }
        else
        {
            Console.WriteLine("Incorrect password. Please try again.\n");
        }
    }
    private static void AdministratorSignIn()
    {
        Console.Write("Enter admin password: ");
        string password = Console.ReadLine();

        if (password == adminPassword)
        {
            Console.WriteLine("Admin sign-in successful!\n");
            //AdminMenu();
        }
        else
        {
            Console.WriteLine("Incorrect password. Please try again.\n");
        }
    }
    private static void UserMenu(string username)
    {
        string userFilePath = Path.Combine(usersFolder, username + ".txt");
        string[] userData = File.ReadAllLines(userFilePath);
        decimal balance = decimal.Parse(userData[2]);

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("------- User Menu -------");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Add Money");
            Console.WriteLine("3. Remove Money");
            Console.WriteLine("4. Transfer money");
            Console.WriteLine("5. Logout");
            Console.Write("Please select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"\nYour current balance is: ${balance:F2}\n");
                    break;

                case "2":
                    int addMoney = Convert.ToInt32(Console.ReadLine());
                    AddAccountMoney(userFilePath, addMoney);
                    break;

                case "3":
                    int removeMoney = Convert.ToInt32(Console.ReadLine());
                    balance = RemoveMoneyFromAccount(userFilePath, removeMoney);
                    break;
                case "4":
                    Console.WriteLine("Please provide receiver username:");
                    string receiverUsername = Console.ReadLine();

                    // Amount to transfer
                    Console.WriteLine("Please provide amount to transfer:");
                    decimal amount = Convert.ToInt32(Console.ReadLine());

                    // Perform the transfer
                    TransferMoney(userData[0], receiverUsername, amount);
                    break;

                case "5":
                    // Update balance in user file and logout
                    File.WriteAllLines(userFilePath, new[] { userData[0], balance.ToString("F2") });
                    exit = true;
                    Console.WriteLine("You have been logged out.\n");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.\n");
                    break;
            }
        }
    }
    public static decimal GetAccountMoneyFromFile(string filePath)
    {
        try
        {
            //string fileContent = File.ReadAllText(filePath);
            //decimal accountMoney = Convert.ToInt32(fileContent);
            string[] userData = File.ReadAllLines(filePath);
            decimal balance = decimal.Parse(userData[2]);
            return balance;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found.");
            return -1;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
            return -1;
        }
    }
    public static void AddAccountMoney(string filePath, int money)
    {
        try
        {
            string[] userData = File.ReadAllLines(filePath);
            decimal balance = decimal.Parse(userData[2]);
            //string fileContent = File.ReadAllText(filePath);
            //int accountMoney = Convert.ToInt32(fileContent);
            balance += money;
            userData[2] = balance.ToString();
            File.WriteAllLines(filePath, userData);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
    public static decimal RemoveMoneyFromAccount(string filePath, int money)
    {
        try
        {
            //string fileContent = File.ReadAllText(filePath);
            string[] userData = File.ReadAllLines(filePath);
            decimal balance = decimal.Parse(userData[2]);
            //int accountMoney = Convert.ToInt32(fileContent);
            if (money > balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            balance -= money;
            File.WriteAllText(filePath, balance.ToString());
            return balance;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file was not found.");
            return -1;
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
            return -1;
        }
    }
    public static void TransferMoney(string username, string reveiverUsername, decimal amount)
    {
        string senderFilePath = Path.Combine(usersFolder, username + ".txt");
        string receiverFilePath = Path.Combine(usersFolder, reveiverUsername + ".txt");
        try
        {
            string[] senderData = File.ReadAllLines(senderFilePath);
            if (senderData.Length < 3)
            {
                throw new FormatException("Sender file format is incorrect. Must contain username, passcode, and balance.");
            }
            decimal senderBalance = decimal.Parse(senderData[2]);

            string[] receiverData = File.ReadAllLines(receiverFilePath);
            if (receiverData.Length < 3)
            {
                throw new FormatException("Receiver file format is incorrect. Must contain username, passcode, and balance.");
            }
            decimal receiverBalance = decimal.Parse(receiverData[2]);

            // Check if the sender has sufficient funds
            if (amount > senderBalance)
            {
                throw new InvalidOperationException("Insufficient funds in the sender's account.");
            }

            // Perform the transfer
            senderBalance -= amount;
            receiverBalance += amount;

            // Update the balance lines
            senderData[2] = senderBalance.ToString();
            receiverData[2] = receiverBalance.ToString();

            // Write the updated data back to the files
            File.WriteAllLines(senderFilePath, senderData);
            File.WriteAllLines(receiverFilePath, receiverData);

            Console.WriteLine($"Successfully transferred {amount} from {senderData[0]} to {receiverData[0]}.");
        }
        catch (Exception ex)
        {
            // Handle and log exceptions
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }

    #endregion

    #region OOP N1 Classes
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set; }
        public Book(string name, string author, int releaseDate)
        {
            Name = name;
            Author = author;
            ReleaseDate = releaseDate;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {Name}, Author: {Author}, Year: {ReleaseDate}");
        }
    }
    class BookManager
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public void addBook(Book book)
        {
            Books.Add(book);
        }
        public void getBooksList()
        {
            if (Books.Count == 0) 
            {
                Console.WriteLine("No books available in the collection.");
            }
            else
            {

                foreach (var book in Books)
                {
                    Console.WriteLine($"Book Name {book.Name}, Book Author {book.Author}, Book Release Date {book.ReleaseDate}");
                }
            }
        }

        public void searchBook(string bookName)
        {
            if (Books.Count == 0)
            {
                Console.WriteLine("No books available in the collection.");
            }
            else
            {
                foreach (var book in Books)
                {
                    if (book.Name == bookName)
                    {
                        book.DisplayDetails();
                    }
                    else
                    {
                        Console.WriteLine($"Book '{bookName}' not found in the list.");
                    }
                }
            }
           
            
        }

    }
    #endregion

    #region OOP N2 Classes
    public class Student
    {
        public string Name { get; set; }
        public int Number { get; set; } 
        public char Grade { get; set; } 
        public Student(string name, int number, char grade)
        {
            Name = name;
            Number = number;
            Grade = grade;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Number: {Number}, Grade: {Grade}");
        }
    }

    #endregion
}
