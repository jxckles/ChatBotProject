using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;


namespace ChatBotProject
{
    public partial class Form1 : Form
    {
        private SQLiteConnection sqliteConnection;
        // Add chat name property
        public string ChatName { get; private set; }

        private WaveOutEvent outputDevice;
        private string initialMessage = "Hello! I'm KAI, your Knowledgeable A.I. companion for computer engineering queries! This session is exclusively question-based. If you're looking to explore career paths in computer engineering, just type 'career path' or ask about different roles and opportunities. Remember, I'm here to answer your questions!";
        static ChatBot bot;

        // Bot Voice...
        SpeechSynthesizer reader = new SpeechSynthesizer();
        bool textToSpeech = false;

        // Voice Recognition
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
    
        

        private FirstPage firstPage;
        

        public Form1()
        {
            InitializeComponent();
            this.firstPage = new FirstPage(this);
            InitializeDatabase();
            InitializeSoundEffects();

            // Set the label text to the provided chat name

            pbxSmoke.Controls.Add(pbxBotGif);
            pbxSmoke.Controls.Add(label2);
            pbxSmoke.Controls.Add(label3);
            //pbxSmoke.Controls.Add(btnVoiceRecognition);
        }



        //Sqlite Database
        private void InitializeDatabase()
        {
            // Get the directory where the application is running
            string directory = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the directory path with the database file name
            string databasePath = Path.Combine(directory, "ChatbotDatabase.db");

            // Check if the database file exists
            if (!File.Exists(databasePath))
            {
                // If the database file doesn't exist, create it
                SQLiteConnection.CreateFile(databasePath);
            }

            // Open the SQLite connection
            sqliteConnection = new SQLiteConnection($"Data Source={databasePath};Version=3;");
            sqliteConnection.Open();

            // Create the ProgrammingMessages table
            string createTableQueryProgrammingMessages = @"
        CREATE TABLE IF NOT EXISTS ProgrammingMessages (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            MessageText TEXT,
            Category TEXT
        );";

            // Create the ComputerMessages table
            string createTableQueryComputerMessages = @"
        CREATE TABLE IF NOT EXISTS ComputerMessages (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            MessageText TEXT,
            Category TEXT
        );";

            // Create the CareerPathMessages table
            string createTableQueryCareerPathMessages = @"
        CREATE TABLE IF NOT EXISTS CareerPathMessages (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            MessageText TEXT,
            Category TEXT
        );";

            // Create the HistoryMessages table
            string createTableQueryHistoryMessages = @"
        CREATE TABLE IF NOT EXISTS HistoryMessages (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            MessageText TEXT,
            Category TEXT
        );";

            // Create the GreetingsMessages table
            string createTableQueryGreetingsMessages = @"
        CREATE TABLE IF NOT EXISTS GreetingsMessages (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            MessageText TEXT,
            Category TEXT
        );";

            // Create the UserProfileMessages table
            string createTableQueryUserProfileMessages = @"
        CREATE TABLE IF NOT EXISTS UserProfileMessages (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            MessageText TEXT,
            Category TEXT
        );";

            // Create the DefaultFallbackMessages table
            string createTableQueryDefaultFallbackMessages = @"
        CREATE TABLE IF NOT EXISTS DefaultFallbackMessages (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            MessageText TEXT,
            Category TEXT
        );";

            // Create the UserMessages table with a foreign key reference to the category
            string createTableQueryUserMessages = @"
        CREATE TABLE IF NOT EXISTS UserMessages (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            MessageText TEXT,
            Category TEXT,
            IsUserMessage INTEGER,
            FOREIGN KEY(Category) REFERENCES ProgrammingMessages(Category),
            FOREIGN KEY(Category) REFERENCES ComputerMessages(Category),
            FOREIGN KEY(Category) REFERENCES CareerPathMessages(Category),
            FOREIGN KEY(Category) REFERENCES HistoryMessages(Category),
            FOREIGN KEY(Category) REFERENCES GreetingsMessages(Category),
            FOREIGN KEY(Category) REFERENCES UserProfileMessages(Category),
            FOREIGN KEY(Category) REFERENCES DefaultFallbackMessages(Category)
        );";

            // Create the BotMessages table with a foreign key reference to the UserMessages table
            string createTableQueryBotMessages = @"
        CREATE TABLE IF NOT EXISTS BotMessages (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            MessageText TEXT,
            IsUserMessage INTEGER,
            Category TEXT,  -- Add Category column here
            UserMessageId INTEGER,
            FOREIGN KEY(UserMessageId) REFERENCES UserMessages(Id)
        );";

            // Create the Messages table with foreign key references to UserMessages and BotMessages
            string createTableQueryMessages = @"
        CREATE TABLE IF NOT EXISTS Messages (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            MessageText TEXT,
            IsUserMessage INTEGER,
            Category TEXT,
            FOREIGN KEY(Category) REFERENCES ProgrammingMessages(Category),
            FOREIGN KEY(Category) REFERENCES ComputerMessages(Category),
            FOREIGN KEY(Category) REFERENCES CareerPathMessages(Category),
            FOREIGN KEY(Category) REFERENCES HistoryMessages(Category),
            FOREIGN KEY(Category) REFERENCES GreetingsMessages(Category),
            FOREIGN KEY(Category) REFERENCES UserProfileMessages(Category),
            FOREIGN KEY(Category) REFERENCES DefaultFallbackMessages(Category)
        );";

            // Execute table creation queries
            using (SQLiteCommand createTableCommandProgrammingMessages = new SQLiteCommand(createTableQueryProgrammingMessages, sqliteConnection))
            using (SQLiteCommand createTableCommandComputerMessages = new SQLiteCommand(createTableQueryComputerMessages, sqliteConnection))
            using (SQLiteCommand createTableCommandCareerPathMessages = new SQLiteCommand(createTableQueryCareerPathMessages, sqliteConnection))
            using (SQLiteCommand createTableCommandHistoryMessages = new SQLiteCommand(createTableQueryHistoryMessages, sqliteConnection))
            using (SQLiteCommand createTableCommandGreetingsMessages = new SQLiteCommand(createTableQueryGreetingsMessages, sqliteConnection))
            using (SQLiteCommand createTableCommandUserProfileMessages = new SQLiteCommand(createTableQueryUserProfileMessages, sqliteConnection))
            using (SQLiteCommand createTableCommandDefaultFallbackMessages = new SQLiteCommand(createTableQueryDefaultFallbackMessages, sqliteConnection))
            using (SQLiteCommand createTableCommandUserMessages = new SQLiteCommand(createTableQueryUserMessages, sqliteConnection))
            using (SQLiteCommand createTableCommandBotMessages = new SQLiteCommand(createTableQueryBotMessages, sqliteConnection))
            using (SQLiteCommand createTableCommandMessages = new SQLiteCommand(createTableQueryMessages, sqliteConnection))
            {
                createTableCommandProgrammingMessages.ExecuteNonQuery();
                createTableCommandComputerMessages.ExecuteNonQuery();
                createTableCommandCareerPathMessages.ExecuteNonQuery();
                createTableCommandHistoryMessages.ExecuteNonQuery();
                createTableCommandGreetingsMessages.ExecuteNonQuery();
                createTableCommandUserProfileMessages.ExecuteNonQuery();
                createTableCommandDefaultFallbackMessages.ExecuteNonQuery();
                createTableCommandUserMessages.ExecuteNonQuery();
                createTableCommandBotMessages.ExecuteNonQuery();
                createTableCommandMessages.ExecuteNonQuery();
            }
        }

        // Message SFX
        private void InitializeSoundEffects()
        {
            outputDevice = new WaveOutEvent();
        }

        private void PlaySoundEffect(string soundFilePath)
        {
            if (File.Exists(soundFilePath))
            {
                // Stop playback if the output device is already playing
                if (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    outputDevice.Stop();
                }

                // Initialize and start playback
                using (var audioFile = new AudioFileReader(soundFilePath))
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bot = new ChatBot();

            // Load all messages from the database
            LoadMessagesFromDatabase();

       
        }


        // If database is empty
        public bool IsDatabaseEmpty()
        {
            using (SQLiteCommand command = new SQLiteCommand("SELECT COUNT(*) FROM UserMessages", sqliteConnection))
            {
                int messageCount = Convert.ToInt32(command.ExecuteScalar());
                return messageCount == 0;
            }
        }

        //Speech Recognizer
        private void InitializeVoiceRecognition()
        {
            // Create separate Choices for words and phrases
            Choices wordList = new Choices();
            Choices phraseList = new Choices();

            // Add words to the word list
            wordList.Add(new string[] { "hey!", "hello!", "hi!", "sharp.", "kai.", "yes.", "no." });

            // Add phrases to the phrase list
            phraseList.Add(new string[] { "what is a computer?", "what is the time today?", "what is c sharp?", 
                "what is java?", "what is your name?", "hey kai.", "what is c?", "what is c plus plus?", "what is python?","career paths.",
                "career roles.", "growth opportunities.", "expanding horizons.", "industry trends and outlook.", "what is the current time?", 
                "what date is today?","what is my name?","what is my age?","what is my gender?", "thank you!", "my name is jenn." });

            // Create GrammarBuilder instances for each list
            GrammarBuilder wordBuilder = new GrammarBuilder(wordList);
            GrammarBuilder phraseBuilder = new GrammarBuilder(phraseList);

            // Create Grammar instances from GrammarBuilder
            Grammar wordGrammar = new Grammar(wordBuilder);
            Grammar phraseGrammar = new Grammar(phraseBuilder);

            // Load both grammars asynchronously
            recognizer.LoadGrammarAsync(wordGrammar);
            recognizer.LoadGrammarAsync(phraseGrammar);

            // Register event handlers for speech recognition
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
            recognizer.SpeechRecognitionRejected += Recognizer_SpeechRecognitionRejected;

            // Start listening for speech
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }


        // Event handler for recognized speech
        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            InputTxt.Text = e.Result.Text; // Set recognized speech as input text         
            showOutput(); // Automatically trigger message sending process         
        }

        // Event handler for rejected speech (not recognized)
        private void Recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            lblListening.Hide();
            recognizer.RecognizeAsyncStop();
            // Provide feedback to the user
            InputTxt.Text = "Sorry, I didn't understand that.";
            reader.SelectVoiceByHints(VoiceGender.Female);
            reader.SpeakAsync(InputTxt.Text);

            //enable the voice button again
            btnVoiceRecognition.Enabled = true;
            // Optionally log the rejected speech for further analysis
            LogRejectedSpeech(e);
        }

        // Method to log rejected speech for further analysis
        private void LogRejectedSpeech(SpeechRecognitionRejectedEventArgs e)
        {
            // Log the rejected speech to a file or database for further analysis
            string rejectedSpeech = string.Join(" ", e.Result.Alternates.Select(a => a.Text));
            using (StreamWriter writer = File.AppendText("RejectedSpeechLog.txt"))
            {
                writer.WriteLine($"Rejected speech: {rejectedSpeech}");
            }
        }



        // Method to handle bot responses
        private void HandleBotResponse(string response)
        {
            // Show the bot message
            addOutMessage(response);

            // Play receive sound effect
            PlaySoundEffect("SOUND2.mp3");

            // Text to Speech if enabled
            if (textToSpeech)
            {             
                // Start TTS
                reader.SelectVoiceByHints(VoiceGender.Female);
                reader.SpeakAsync(response);                        
            }                    
        }
        // Message Output
        private void showOutput()
        {
            recognizer.RecognizeAsyncStop();

            if (!(string.IsNullOrWhiteSpace(InputTxt.Text))) // Make sure the textbox isn't empty
            {

                string message = InputTxt.Text;
                string category = DetermineCategory(message);




                // Play send sound effect
                PlaySoundEffect("SOUND1.mp3");

                // Show the user message
                addInMessage(message);

                // Store the Bot's Output by giving it our input.
                string outtt = bot.getOutput(message);

                if (outtt.Length == 0)
                {
                    outtt = "I don't understand.";
                }

                // Save user message to the database
                SaveMessageToDatabase(InputTxt.Text, category, true);

                // Set a fixed delay for responsiveness
                int fixedDelay = 2000; // Adjust this value as needed

                // Show the "Bot is typing.." text
                txtTyping.Show();

                // Disable the chat box while the bot is typing to prevent user spam.
                InputTxt.Enabled = false;

                // Create and start a timer with a fixed delay
                var t = new System.Windows.Forms.Timer();
                t.Interval = fixedDelay;
                t.Tick += (s, d) =>
                {
                    // Once the timer ends
                    InputTxt.Enabled = true; // Enable Chat box

                    // Hide the "Bot is typing.." text
                    txtTyping.Hide();

                    // Handle bot response
                    HandleBotResponse(outtt);

                    InputTxt.Focus(); // Put the cursor back on the textbox
                    t.Stop();
                };
                t.Start(); // Start Timer

                //Disable Voice button disables after bot response
                btnDisableVoiceRecognition.Enabled = false;

                //Voice button enables after bot response
                btnVoiceRecognition.Enabled = true;
                lblListening.Hide();

                InputTxt.Text = ""; // Reset textbox

                // Save bot message to the database and relate it to the user message
                SaveMessageToDatabase(outtt, category, false);
            }
        }

        // Call the Output method when the send button is clicked.
        private void button1_Click(object sender, EventArgs e)
        {
            showOutput();
        }

        // Call the Output method when the enter key is pressed.
        private void InputTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showOutput();
                e.SuppressKeyPress = true; // Disable windows error sound
            }
        }

        // Dummy Bubble created to store the previous bubble data.
        bubble bbl_old = new bubble();

        // User Message Bubble Creation
        public void addInMessage(string message)
        {
            // Create new chat bubble
            bubble bbl = new bubble(message, msgtype.In);
            bbl.Location = bubble1.Location; // Set the new bubble location from the bubble sample.
            bbl.Left += 448; // Indent the bubble to the right side.
            bbl.Size = bubble1.Size; // Set the new bubble size from the bubble sample.
            bbl.Top = bbl_old.Bottom + 10; // Position the bubble below the previous one with some extra space.

            // Add the new bubble to the panel.
            panel2.Controls.Add(bbl);

            // Force Scroll to the latest bubble
            bbl.Focus();

            // Save the last added object to the dummy bubble
            bbl_old = bbl;
        }

        // Bot Message Bubble Creation
        public void addOutMessage(string message)
        {
            // Create new chat bubble
            bubble bbl = new bubble(message, msgtype.Out);
            bbl.Location = bubble1.Location; // Set the new bubble location from the bubble sample.
            bbl.Size = bubble1.Size;// Set the new bubble size from the bubble sample.
            bbl.Top = 0;
            bbl.Top = bbl_old.Bottom; // Position the bubble below the previous one with some extra space.


            // Add the new bubble to the panel.
            panel2.Controls.Add(bbl);

            // Force Scroll to the latest bubble
            bbl.Focus();

            // Save the last added object to the dummy bubble
            bbl_old = bbl;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Clear all the bubbles and chat.log
        private void clearChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Drop the specified tables from the database
            using (SQLiteCommand command = new SQLiteCommand("DROP TABLE IF EXISTS BotMessages; " +
                "DROP TABLE IF EXISTS ComputerMessages; DROP TABLE IF EXISTS Messages; DROP TABLE IF EXISTS DefaultFallbackMessages; " +
                "DROP TABLE IF EXISTS ProgrammingMessages; DROP TABLE IF EXISTS UserProfileMessages; DROP TABLE IF EXISTS CareerPathMessages; " +
                "DROP TABLE IF EXISTS GreetingsMessages; DROP TABLE IF EXISTS HistoryMessages; DROP TABLE IF EXISTS UserMessages;", sqliteConnection))
            {
                command.ExecuteNonQuery();
            }

            // Reinitialize the database tables
            InitializeDatabase();

            // Clear the chat Bubbles
            panel2.Controls.Clear();

            // Add the initial message back to the chat panel
            addOutMessage(initialMessage);
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(menuButton, new System.Drawing.Point(0, -contextMenuStrip1.Size.Height));
        }

        private void toggleVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Toggle the text-to-speech setting
            textToSpeech = !textToSpeech;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);  
        }

        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);

        // Define the flags for the animation effect
        public const int AW_BLEND = 0x00080000;
        public const int AW_HIDE = 0x00010000;

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            // Animate the form when minimizing
            AnimateWindow(this.Handle, 300, AW_BLEND | AW_HIDE);

            // Minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        //Voice Recognition Button
        private void btnVoiceRecognition_Click(object sender, EventArgs e)
        {
            try
            {
                lblListening.Show();

                // Unregister previous event handlers
                recognizer.SpeechRecognized -= Recognizer_SpeechRecognized;
                recognizer.SpeechRecognitionRejected -= Recognizer_SpeechRecognitionRejected;

                // Initialize voice recognition
                InitializeVoiceRecognition();

                // Disable the voice recognition button
                this.btnVoiceRecognition.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.btnDisableVoiceRecognition.Enabled = true;
            }
        }

        private void btnDisableVoiceRecognition_Click(object sender, EventArgs e)
        {
            try
            {
                lblListening.Hide();
                recognizer.RecognizeAsyncStop();
                InputTxt.Text = "";
                // Disable the voice recognition button
                this.btnDisableVoiceRecognition.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.btnVoiceRecognition.Enabled = true;
            }
        }

        private void SaveMessageToDatabase(string message, string category, bool isUserMessage)
        {
            // Determine the table name based on the category
            string categoryTableName = GetTableNameFromCategory(category);

            // Construct the query to insert the message into the appropriate category table
            string categoryQuery = $"INSERT INTO {categoryTableName} (MessageText, Category) VALUES (@MessageText, @Category)";

            // Use parameters to prevent SQL injection attacks
            using (SQLiteCommand categoryCommand = new SQLiteCommand(categoryQuery, sqliteConnection))
            {
                categoryCommand.Parameters.AddWithValue("@MessageText", message);
                categoryCommand.Parameters.AddWithValue("@Category", category);

                // Execute the category query
                categoryCommand.ExecuteNonQuery();
            }

            // Insert the message into the UserMessages or BotMessages table based on the isUserMessage flag
            string messageTableName = isUserMessage ? "UserMessages" : "BotMessages";

            // Construct the query to insert the message into the appropriate message table
            string messageQuery = $"INSERT INTO {messageTableName} (MessageText, IsUserMessage, Category) VALUES (@MessageText, @IsUserMessage, @Category)";

            // Use parameters to prevent SQL injection attacks
            using (SQLiteCommand messageCommand = new SQLiteCommand(messageQuery, sqliteConnection))
            {
                messageCommand.Parameters.AddWithValue("@MessageText", message);
                messageCommand.Parameters.AddWithValue("@IsUserMessage", isUserMessage ? 1 : 0);
                messageCommand.Parameters.AddWithValue("@Category", category);

                // Execute the message query
                messageCommand.ExecuteNonQuery();
            }

            // Construct the query to insert the message into the Messages table
            string allMessagesQuery = @"INSERT INTO Messages (MessageText, IsUserMessage, Category)
                                VALUES (@MessageText, @IsUserMessage, @Category)";

            // Use parameters to prevent SQL injection attacks
            using (SQLiteCommand allMessagesCommand = new SQLiteCommand(allMessagesQuery, sqliteConnection))
            {
                allMessagesCommand.Parameters.AddWithValue("@MessageText", message);
                allMessagesCommand.Parameters.AddWithValue("@IsUserMessage", isUserMessage ? 1 : 0);
                allMessagesCommand.Parameters.AddWithValue("@Category", category);

                // Execute the message query
                allMessagesCommand.ExecuteNonQuery();
            }
        }
        private void LoadMessagesFromDatabase()
        {
            // Construct the SQL query to select messages from the Messages table
            string query = @"
        SELECT MessageText, IsUserMessage, Category
        FROM Messages";

            // Create a command to execute the query
            using (SQLiteCommand command = new SQLiteCommand(query, sqliteConnection))
            {
                // Execute the query
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    bool isFirstMessage = true;

                    // Iterate through each row in the result set
                    while (reader.Read())
                    {
                        // If it's the first message, display the initial message
                        if (isFirstMessage)
                        {
                            addOutMessage(initialMessage);
                            isFirstMessage = false;
                        }

                        // Get the message text, user/bot indicator, and category from the current row
                        string messageText = reader["MessageText"].ToString();
                        bool isUserMessage = Convert.ToBoolean(reader["IsUserMessage"]);
                        string category = reader["Category"].ToString();

                        // Determine if the message is from the user or bot and add it to the appropriate category
                        if (isUserMessage)
                        {
                            addInMessage(messageText);
                        }
                        else
                        {
                            addOutMessage(messageText);
                        }
                    }
                }
            }
            if (IsDatabaseEmpty())
            {
                // Add the initial message back to the chat panel
                addOutMessage(initialMessage);
            }
        }

        // Determine the message which category it will be sort.
        private string DetermineCategory(string message)
        {
            if (message.ToLower().Contains("programming") || message.ToLower().Contains("java") || message.ToLower().Contains("program") || 
                message.ToLower().Contains("c") || message.ToLower().Contains("sharp") || message.ToLower().Contains("cplusplus") || 
                message.ToLower().Contains("plus") || message.ToLower().Contains("ruby") || message.ToLower().Contains("php") || 
                message.ToLower().Contains("python"))
            {
                return "Programming";
            }
            else if (message.ToLower().Contains("computer") || message.ToLower().Contains("technology") || message.ToLower().Contains("cpu") || 
                message.ToLower().Contains("session bean") || message.ToLower().Contains("debugger") || message.ToLower().Contains("soundcard")
                || message.ToLower().Contains("jar") || message.ToLower().Contains("http") || message.ToLower().Contains("html") || 
                message.ToLower().Contains("dmoz") || message.ToLower().Contains("ram") || message.ToLower().Contains("ssd") || 
                message.ToLower().Contains("hdd") || message.ToLower().Contains("gpu") || message.ToLower().Contains("bios") || 
                message.ToLower().Contains("operating system") || message.ToLower().Contains("motherboard") || 
                message.ToLower().Contains("network interface card") || message.ToLower().Contains("power supply unit") || message.ToLower().Contains("hardware")
                || message.ToLower().Contains("software") || message.ToLower().Contains("science"))
            {
                return "Computer";
            }
            else if (message.ToLower().Contains("career path") || message.ToLower().Contains("career paths") || message.ToLower().Contains("engineering")
                || message.ToLower().Contains("career") || message.ToLower().Contains("roles") || message.ToLower().Contains("level")
                || message.ToLower().Contains("growth opportunities") || message.ToLower().Contains("expanding horizons") || message.ToLower().Contains("industry")
                || message.ToLower().Contains("degree") || message.ToLower().Contains("certifications") || message.ToLower().Contains("networking")
                || message.ToLower().Contains("opportunities") || message.ToLower().Contains("emerging technologies") || message.ToLower().Contains("professional development")
                || message.ToLower().Contains("artificial intelligence") || message.ToLower().Contains("cybersecurity") || message.ToLower().Contains("cloud")
                || message.ToLower().Contains("data analytics") || message.ToLower().Contains("challenges") || message.ToLower().Contains("challenges"))
            {
                return "CareerPath";
            }
            else if (message.ToLower().Contains("history") || message.ToLower().Contains("network engineering") || message.ToLower().Contains("digital signal processing")
                || message.ToLower().Contains("robotics") || message.ToLower().Contains("generations") || message.ToLower().Contains("pioneers")
                || message.ToLower().Contains("evolution") || message.ToLower().Contains("architecture") || message.ToLower().Contains("scientist")
                || message.ToLower().Contains("scientists") || message.ToLower().Contains("innovations") || message.ToLower().Contains("revolution"))
            {
                return "History";
            }
            else if (message.ToLower().Contains("greetings") || message.ToLower().Contains("hi") || message.ToLower().Contains("hello") || message.ToLower().Contains("hey")
                || message.ToLower().Contains("good morning") || message.ToLower().Contains("good evening") || message.ToLower().Contains("good afternoon")
                || message.ToLower().Contains("how are you") || message.ToLower().Contains("thank you"))
            {
                return "Greetings";
            }
            else if (message.ToLower().Contains("name") || message.ToLower().Contains("age") || message.ToLower().Contains("gender") || message.ToLower().Contains("profile"))
            {
                return "UserProfile";
            }
            else
            {
                return "DefaultFallback";
            }
        }

        private string GetTableNameFromCategory(string category)
        {
            // Append "Messages" suffix to the category name to get the table name
            return category + "Messages";
        }
    }
}
