using System;
using System.IO;
using System.Windows.Forms;

namespace anime_dl_gui
{
    public partial class MainForm : Form
    {
        string Command;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPassword.Checked) {
                Password.UseSystemPasswordChar = false;
            }
            else {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void SaveAccountButton_Click(object sender, EventArgs e)
        {
            Account.Default.Username = Username.Text;
            Account.Default.Password = Password.Text;
            Account.Default.Resolution = Resolution.Text;
            Account.Default.Save();
            Account.Default.Reload();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            Command = "-i \"" + URL.Text + "\" -u \"" + 
                Username.Text + "\" -p \"" + 
                Password.Text + "\" -r \"" + 
                Resolution.Text + "\"";
            if (Verbose.Checked)
            {
                Command += " -v";
            }
            if(SubtitleOnly.Checked)
            {
                Command += " --skip";
            }
            if(Episodes.Checked)
            {
                Command += " -rn " + EpisodeFrom.Text + "-" + EpisodeTo.Text;
            }

            System.Diagnostics.Process.Start("anime-dl", Command);

            /*
             * These options for creating Batch files (.bat), it might be a feature later.
             * StreamWriter Batchfile = new StreamWriter(URL.Text + ".bat");
             * Batchfile.WriteLine(Command);
             * Batchfile.Close();
             * 
             * This function show the arguments.
             * MessageBox.Show(Command);
            */
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Username.Text = Account.Default.Username;
            Password.Text = Account.Default.Password;
            Resolution.Text = Account.Default.Resolution;
        }

        private void Episodes_CheckedChanged(object sender, EventArgs e)
        {
            if(Episodes.Checked)
            {
                EpisodeFrom.ReadOnly = false;
                EpisodeTo.ReadOnly = false;
            }
            else
            {
                EpisodeFrom.ReadOnly = true;
                EpisodeTo.ReadOnly = true;
            }
        }
    }
}
