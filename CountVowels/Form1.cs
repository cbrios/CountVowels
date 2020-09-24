// Author : Chavela Rios
// Date   : 2020-09-23
// Write a GUI program using WPF named CountVowels that accepts a phrase from the user and counts the number of 
//vowels in the phrase. For this exercise, count both uppercase and lowercase vowels, but do not consider a y to be a vowel.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Button event
        private void btnCount_Click(object sender, EventArgs e)
        {
            // Variable to declare human input
            String input;

            // Assigning input from human
            input = txtInput.Text;

            // Counts the vowels
            getVowels(input);
        }

        // When window is loaded event
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Makes sure TextBoxs are blank
            txtInput.Text = "";
            txtCount.Text = "";
        }

        // Text changed in textbox event
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // Makes sure TextBox is blank if entering another input
            txtCount.Text = "";
        }

        // Obtains number of vowels in human input
        private void getVowels(String input)
        {
            // Declare and reset vowel count
            int v = 0;

            // Loop that sorts through string length and adds to total if matches to vowels listed below
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                    v++;
                if (input[i] == 'e')
                    v++;
                if (input[i] == 'i')
                    v++;
                if (input[i] == 'o')
                    v++;
                if (input[i] == 'u')
                    v++;
            }

            // Displays total in textbox
            txtCount.Text = v.ToString();
        }
    }
}
