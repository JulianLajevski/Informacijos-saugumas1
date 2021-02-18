using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CesarAlgorithm
{
    public partial class Form1 : Form
    {
        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(encryptingKeyTextBox.Text == "kev123")
            {
                if (cryptTextBox.Text != "")
                {
                    string messageText = cryptTextBox.Text;
                    char[] secretMessage = messageText.ToCharArray();

                    char[] encryptedMessage = new char[secretMessage.Length];

                    for (int i = 0; i < secretMessage.Length; i++)
                    {
                        char secretItem = secretMessage[i];
                        int index = Array.IndexOf(alphabet, secretItem);
                        int letterPosition = (index += 4) % 26;
                        char encrypterdCharacter = alphabet[letterPosition];
                        encryptedMessage[i] = encrypterdCharacter;
                    }

                    cryptedText.Text = String.Join("", encryptedMessage);
                }
                else
                {
                    MessageBox.Show("Message is empty!");
                }
                
            }
            else
            {
                MessageBox.Show("Key is incorrect!");
            }
            
        }

        private void uncryptButton_Click(object sender, EventArgs e)
        {
            if(decryptingKeyTextBox.Text == "kev321")
            {
                if(uncryptTextBox.Text != "")
                {
                    string cryptedMessageText = uncryptTextBox.Text;
                    char[] cryptedMessage = cryptedMessageText.ToCharArray();

                    char[] normalMessage = new char[cryptedMessage.Length];

                    for (int i = 0; i < cryptedMessage.Length; i++)
                    {
                        char normalItem = cryptedMessage[i];
                        int index = Array.IndexOf(alphabet, normalItem);
                        int letterPosition = (index = index - 4 + 26) % 26;
                        char encryptedCharacter = alphabet[letterPosition];
                        normalMessage[i] = encryptedCharacter;
                    }
                    uncryptTextView.Text = String.Join("", normalMessage);
                }
                else
                {
                    MessageBox.Show("Message is empty");
                }
                
            }
            else
            {
                MessageBox.Show("Key is incorrect!");
            }
            
        }
    }
}
