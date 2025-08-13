using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;



namespace IN64_Homework_Assignment_1_Group53
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text boxes for sign in
            txtSignInEmail.Clear();
            txtSignInPassword.Clear();
           
        }

       public static bool validateEmail(string email)
        {
            // Check if the email is null or empty
            if (string.IsNullOrWhiteSpace(email))
            {  
                return false;
            }

            Regex regex = new Regex("u\\d\\d\\d\\d\\d\\d\\d\\d@tuks\\.co\\.za", RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }
        public static bool validatePassword(string password)
        {
            // Check if the password is null or empty
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            // Check if the password meets the criteria: 8-16 characters, at least one uppercase letter, one lowercase letter, one digit, and one special character
            Regex regex = new Regex(@"^(.{8,16}|[^0-9]*|[^A-Z])$");
            return regex.IsMatch(password);
        }
        private static bool validateID(string id)
        {
            // Check if the ID is null or empty
            if (string.IsNullOrWhiteSpace(id))
            {
                return false;
            }
            // Check if the ID is exactly 13 digits long
            Regex regex = new Regex(@"^.{13}|[^0-9]$");
            return regex.IsMatch(id);

        }
        private void rdbSignUp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSignUp.Checked == true)
            {
                // Show the create account group box
                grbCeateAccount.Visible = true;
            }
            else 
            {
                rdbLogin.Checked = true;    
                grbCeateAccount.Visible = false;
            }
        }
        int attempts = 1;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Get the values from the text boxes
            string emailAddress = txtSignInEmail.Text;
            string password = txtSignInPassword.Text;
            string binPath = AppDomain.CurrentDomain.BaseDirectory;
            // Declare the file paths
            string folderPathNeo = Path.Combine(binPath, "NeoFit_Session");
            string path = Path.Combine(binPath, "NeoFit_Session\\Users\\users.txt");
            string pathSessions = Path.Combine(binPath, "NeoFit_Session\\Sessions\\sessions.txt");
            DateTime currentDate = DateTime.Now;


            // Validate the email address
            if (validateEmail(emailAddress) == true)
            {
                // Check if the user exists in the file
                bool findUser = File.ReadAllLines(path).Any(x => x.Contains(emailAddress));
                if (findUser == true)
                {
                    // Check if the password matches the user
                    bool findPassword = File.ReadAllLines(path).Any(x => x.Contains(password));
                    if (findPassword == true)
                    {
                        // If the user exists and the password matches, proceed to the main control hub
                        try
                        {
                            // Check if the sessions file exists and write the login session
                            if (File.ReadAllLines(pathSessions).Any(x => x.Contains("timestamp|ation|email|note")))
                            {
                                StreamWriter save = new StreamWriter(pathSessions);
                                save.WriteLine(currentDate + "|" + "Login" + "|" + emailAddress + "|" + "Opened Main Control Hub");
                                save.Close();
                            }
                            else
                            {
                                StreamWriter save = new StreamWriter(pathSessions);
                                save.WriteLine("timestamp|ation|email|note");
                                save.WriteLine(currentDate + "|" + "Login" + "|" + emailAddress + "|" + "Opened Main Control Hub");
                                save.Close();
                            }

                        }
                        catch (Exception ex)
                        {
                            // Handle any exceptions that occur during file operations
                            MessageBox.Show(ex.Message);

                        }
                        // open MainControlHub form
                        MainControlHub myForm = new MainControlHub();
                        myForm.Text = "NeoFit —— Main Control Hub · " + emailAddress;
                        myForm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    // If the user does not exist, show a message box
                    MessageBox.Show("This user does not exist, please sign up first");
                }
            }
            else
            { 
             // If the email address is not valid, show a message box
             lblSign.Text = "Use your student email (u########@tuks.co.za). Attempts left:" + attempts;
            }
            // If the email address is valid but the password is incorrect, increment the attempts counter
            attempts = attempts + 1;
            // If the attempts counter exceeds 3, lock the text boxes and start the timer
            if (attempts > 3)
            {
                lblLock.Visible = true;
                lockTimer.Start();
                lblSign.Text= "Too many attempts. Locking for 30s";
                txtSignInEmail.Enabled = false;
                txtSignInPassword.Enabled = false;  

            }

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Get the values from the text boxes
            string email = txtSignUpStudentEmail.Text;
            string password = Convert.ToString(txtSignUpPassword.Text);
            string confirmPassword = Convert.ToString(txtConfirmPassword.Text);
            string id = Convert.ToString(txtID.Text);
            // Declare the file paths
            string binPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPathNeo = Path.Combine(binPath, "NeoFit_Session");
            string path = Path.Combine(binPath, "NeoFit_Session\\Users\\users.txt");

            //call the method to validate the inputs
            if (validateEmail(email) == false)
            {
                lblSignUpUpdate.Text = "Use your student email (u########@tuks.co.za).";
            }
            else if (validatePassword(password) == false)
            {

                lblSignUpUpdate.Text = "Please enter a valid password  (8-16,upper,lower,digit,special).";

                
            }
            else if (confirmPassword != password)
            {
                lblSignUpUpdate.Text = "Please make sure the passwords are the same.";
            }
            else if (validateID(id) == false)
            {
                lblSignUpUpdate.Text = "Please enter a valid ID (13 digits).";
            }
            else if (File.ReadAllLines(path).Any(x => x.Contains(email)))
            {
                // Check if the email already exists in the file
                lblSignUpUpdate.Text = "This email is already registered. Please log in.";
            }
            else if (File.ReadAllLines(path).Any(x => x.Contains(id)))
            {
                // Check if the ID already exists in the file
                lblSignUpUpdate.Text = "This ID is already registered. Please log in.";
            }
            else
            {
                // If all validations pass, proceed to save the user information
                try
                {
                    
                    if (File.Exists(path))
                    {
                        // If the file exists, append the new user information
                        StreamWriter save = new StreamWriter(path);
                        save.WriteLine("Email: " + email + "\n ID: " + id + "\n Password: " + password + "\n________________________");
                        save.Close();
                    }
                    else
                    {
                        // If the file does not exist, create it and write the user information
                        createFile(path);
                        StreamWriter save = new StreamWriter(path);
                        save.WriteLine("Email: " + email + "\n ID: " + id + "\n Password: " + password + "\n________________________");
                        save.Close();
                    }
                    
                    

                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during file operations
                    MessageBox.Show(ex.Message);

                }
                // Clear the text boxes after successful sign up
                txtSignUpStudentEmail.Clear();
                txtSignUpPassword.Clear();
                txtConfirmPassword.Clear(); 
                txtID.Clear();
                // Display a success message
                lblSignUpUpdate.Text = "Sign Up succesful. You may log in";
            }
        }

        private void CreateFolderIfMissing(string folderLocation)
        {
            // Check if the folder exists, if not, create it
            if (!System.IO.Directory.Exists(folderLocation))
            {
                System.IO.Directory.CreateDirectory(folderLocation);
                
            }
           
        }
        private void createFile(string filePath)
        {
            // Check if the file exists, if not, create it
            if (!File.Exists(filePath))
            {
                StreamWriter sw = File.CreateText(filePath);
                sw.Close();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            //declare the file paths
            string binPath = AppDomain.CurrentDomain.BaseDirectory;
            string folderPathNeo = Path.Combine(binPath, "NeoFit_Session");
            string folderPathBriefings = Path.Combine(binPath, "NeoFit_Session\\Briefings");
            string folderPathUsers = Path.Combine(binPath, "NeoFit_Session\\Users");
            string folderPathSessions = Path.Combine(binPath, "NeoFit_Session\\Sessions");
            string folderPathStocks = Path.Combine(binPath, "NeoFit_Session\\Stocks");
            string folderPathRain = Path.Combine(binPath, "NeoFit_Session\\RainReport");
            string folderPathRelease = Path.Combine(binPath, "Release");
            string pathBalance = Path.Combine(folderPathNeo, "balance.txt");
            string pathFailures = Path.Combine(folderPathNeo, "failures.txt");
            string pathSessions = Path.Combine(folderPathSessions, "sessions.txt");
            string pathuser= Path.Combine(folderPathUsers, "users.txt");

            // Create the main folders if they does not exist
            CreateFolderIfMissing(folderPathUsers);
            CreateFolderIfMissing(folderPathStocks);
            CreateFolderIfMissing(folderPathSessions);
            CreateFolderIfMissing(folderPathRain);
            CreateFolderIfMissing(folderPathRelease);
            CreateFolderIfMissing(folderPathBriefings);

            // Create the files if they do not exist
            createFile(pathFailures);
            createFile(pathBalance);
            createFile(pathSessions);
            createFile(pathuser);

            rdbLogin.Checked = true;    
        }
        
        int count = 30;
        private void lockTimer_Tick(object sender, EventArgs e)
        {
            // Decrease the count every second
            count--;

            // Update the label to show the remaining lock time
            lblLock.Text = "Locked for " + count + " seconds";

            // If the count reaches zero, unlock the fields and reset the timer
            if (count <= 0)
            {
                lblLock.Visible = false;
                txtSignInEmail.Enabled = true;
                txtSignInPassword.Enabled = true;
                lockTimer.Stop();
                count = 30; // Reset the counter for the next lock period
                attempts = 1; // Reset the attempts counter
            }
        }
    }
}
