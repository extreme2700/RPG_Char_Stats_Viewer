﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Char_Stats_Viewer
{
    public partial class Form1 : Form
    {
        List<CharacterSheet> playerList;
        int currentSheet;

        public Form1()
        {
            InitializeComponent();

            // code is run when a form loads
            playerList = new List<CharacterSheet>();
            playerList.Add(new CharacterSheet());
            currentSheet = 0;
            displayCurrentCharacterSheet();
        }

        /* 
         * Some methods for the mouse clicking events
         * 
         * */
        private void updateButton_Click(object sender, EventArgs e)
        {
            // get information user entered. update values WHEN there is a value entered otherwise keep value
            string updateName; 
            if (updateNameTextBox.Text.Equals("")) // you could use ! before expression to make it a NOT statement but this feels cleaner to check without it
            {
                updateName = playerList[currentSheet].name;
            }
            else
            {
                updateName = updateNameTextBox.Text;
            }

            string updateRace; 
            if (updateRaceTextBox.Text.Equals(""))
            {
                updateRace = playerList[currentSheet].race; 
            }
            else
            {
                updateRace = updateRaceTextBox.Text;
            }
            
            // string needs to be converted to int32(int) since it's an int that it's being stored to
            // user ability to enter something that isn't a number will need to be addressed
            int updateLevel; 
            if (updateLevelTextBox.Text.Equals(""))    
            {
                updateLevel = playerList[currentSheet].level; 
            }
            else
            {
                updateLevel = int.Parse(updateLevelTextBox.Text);
            }

            // put info into sheet
            playerList[currentSheet].name = updateName;
            playerList[currentSheet].race = updateRace;
            playerList[currentSheet].level = updateLevel;

            // display updated sheet
            displayCurrentCharacterSheet();
        }

        private void addSheetButton_Click(object sender, EventArgs e)
        {
            displayCurrentCharacterSheet();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            displayCurrentCharacterSheet();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            displayCurrentCharacterSheet();
        }

        private void deleteSheetButton_Click(object sender, EventArgs e)
        {
            displayCurrentCharacterSheet();
        }

        public void displayCurrentCharacterSheet()
        {
            currentNameTextBox.Text = playerList[currentSheet].name;
            currentRaceTextBox.Text = playerList[currentSheet].race;
            currentLevelTextBox.Text = playerList[currentSheet].level.ToString();  // level is integer so needs to be converted to string
            displayInfoLabel.Text =
                "Sheet " + (currentSheet + 1).ToString() + " of " + playerList.Count;   // Changing text in label to display the current and total sheets
            clearForm();
        }

        private void clearForm()
        {
            // method is used to clear input text boxes
            updateNameTextBox.Text = "";
            updateRaceTextBox.Text = "";
            updateLevelTextBox.Text = "";
        }
    }
}
