using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


public partial class _Default : System.Web.UI.Page
{
    //initialising the variables needed to randomly generate the Code the player must guess
    static int Min = 1;
    static int Max = 5;
    Random codeGenerator = new Random();
    static int[] codeAnswer = new int[4];
    static int gameStatus = 1;

    //initialising the arrays for the players current guesses (which will reset on each new guess) and how many guesses the player has made
    static int[] currentGuesses = new int[4];
    static int attemptsMade = 0;

    static string[] colourPicker = new string[5];

    // static int[,] displayGuess = new int[8,4];


    /* public static void guessDisplayer ()
     {
         switch (currentGuesses[0])
         {
             case 1:
                 R1Slot1.ImageUrl = "Images/red_circle.png";
                 break;
             case 2:
                 R1Slot1.ImageUrl = "Images/red_circle.png";
                 break;
             case 3:
                 R1Slot1.ImageUrl = "Images/red_circle.png";
                 break;
             case 4:
                 R1Slot1.ImageUrl = "Images/red_circle.png";
                 break;
             default:
                 break;
         }*/


    /* THIS IS FOR TESTING PURPOSES
protected void Page_Load(object sender, EventArgs e)
{
    foreach (var item in currentGuesses)
    {
        testlabel.Text += item.ToString();
    } 
}*/

    //This code is run on the page first initialising
    protected void Page_Init(object sender, EventArgs e)
    {

        //If the page is simply being refreshed for whatever reason (e.g. postback from pressing a button) this piece of code WILL NOT run again
        if (!Page.IsPostBack)
        {
            guessDisplay1.ImageUrl = "Images/white_circle.png";
            guessDisplay2.ImageUrl = "Images/white_circle.png";
            guessDisplay3.ImageUrl = "Images/white_circle.png";
            guessDisplay4.ImageUrl = "Images/white_circle.png";
            R1Slot1.ImageUrl = "Images/blank.png";
            R1Slot2.ImageUrl = "Images/blank.png";
            R1Slot3.ImageUrl = "Images/blank.png";
            R1Slot4.ImageUrl = "Images/blank.png";
            R2Slot1.ImageUrl = "Images/blank.png";
            R2Slot2.ImageUrl = "Images/blank.png";
            R2Slot3.ImageUrl = "Images/blank.png";
            R2Slot4.ImageUrl = "Images/blank.png";
            R3Slot1.ImageUrl = "Images/blank.png";
            R3Slot2.ImageUrl = "Images/blank.png";
            R3Slot3.ImageUrl = "Images/blank.png";
            R3Slot4.ImageUrl = "Images/blank.png";
            R4Slot1.ImageUrl = "Images/blank.png";
            R4Slot2.ImageUrl = "Images/blank.png";
            R4Slot3.ImageUrl = "Images/blank.png";
            R4Slot4.ImageUrl = "Images/blank.png";
            R5Slot1.ImageUrl = "Images/blank.png";
            R5Slot2.ImageUrl = "Images/blank.png";
            R5Slot3.ImageUrl = "Images/blank.png";
            R5Slot4.ImageUrl = "Images/blank.png";
            R6Slot1.ImageUrl = "Images/blank.png";
            R6Slot2.ImageUrl = "Images/blank.png";
            R6Slot3.ImageUrl = "Images/blank.png";
            R6Slot4.ImageUrl = "Images/blank.png";
            R7Slot1.ImageUrl = "Images/blank.png";
            R7Slot2.ImageUrl = "Images/blank.png";
            R7Slot3.ImageUrl = "Images/blank.png";
            R7Slot4.ImageUrl = "Images/blank.png";
            R8Slot1.ImageUrl = "Images/blank.png";
            R8Slot2.ImageUrl = "Images/blank.png";
            R8Slot3.ImageUrl = "Images/blank.png";
            R8Slot4.ImageUrl = "Images/blank.png";

            attemptsMade = 0;
            // creates the Code the player must guess to win the game on FIRST initialising the page
            for (int i = 0; i < codeAnswer.Length; i++)
            {
                codeAnswer[i] = codeGenerator.Next(Min, Max);
            }
            foreach (var item in codeAnswer)
            {
                //numArray.Text += item.ToString();
            }
        }
    }


    // These statements will record the buttons the user presses as their CURRENT GUESS
    protected void ansButton1_Click(object sender, EventArgs e)
    {
        if (gameStatus == 0)
        {

        }
        else
        {
            if (currentGuesses[0] == 0)
            {
                guessDisplay1.ImageUrl = "Images/red_circle.png";
                currentGuesses[0] = 1;
                //testlabel.Text = Convert.ToString(currentGuesses[0]);
            }
            else if (currentGuesses[1] == 0)
            {
                guessDisplay2.ImageUrl = "Images/red_circle.png";
                currentGuesses[1] = 1;
                //testlabel.Text = Convert.ToString(currentGuesses[1]);
            }
            else if (currentGuesses[2] == 0)
            {
                guessDisplay3.ImageUrl = "Images/red_circle.png";
                currentGuesses[2] = 1;
                //testlabel.Text = Convert.ToString(currentGuesses[2]);
            }
            else if (currentGuesses[3] == 0)
            {
                guessDisplay4.ImageUrl = "Images/red_circle.png";
                currentGuesses[3] = 1;
                //testlabel.Text = Convert.ToString(currentGuesses[3]);
            }
        }
    }
    protected void ansButton2_Click(object sender, EventArgs e)
    {
        if (gameStatus == 0)
        {

        }
        else
        {
            if (currentGuesses[0] == 0)
            {
                guessDisplay1.ImageUrl = "Images/blue_circle.png";
                currentGuesses[0] = 2;
                //testlabel.Text = Convert.ToString(currentGuesses[0]);
            }
            else if (currentGuesses[1] == 0)
            {
                guessDisplay2.ImageUrl = "Images/blue_circle.png";
                currentGuesses[1] = 2;
                //testlabel.Text = Convert.ToString(currentGuesses[1]);
            }
            else if (currentGuesses[2] == 0)
            {
                guessDisplay3.ImageUrl = "Images/blue_circle.png";
                currentGuesses[2] = 2;
                //testlabel.Text = Convert.ToString(currentGuesses[2]);
            }
            else if (currentGuesses[3] == 0)
            {
                guessDisplay4.ImageUrl = "Images/blue_circle.png";
                currentGuesses[3] = 2;
                //testlabel.Text = Convert.ToString(currentGuesses[3]);
            }
        }
    }
    protected void ansButton3_Click(object sender, EventArgs e)
    {
        if (gameStatus == 0)
        {

        }
        else
        {
            if (currentGuesses[0] == 0)
            {
                guessDisplay1.ImageUrl = "Images/green_circle.png";
                currentGuesses[0] = 3;
                //testlabel.Text = Convert.ToString(currentGuesses[0]);
            }
            else if (currentGuesses[1] == 0)
            {
                guessDisplay2.ImageUrl = "Images/green_circle.png";
                currentGuesses[1] = 3;
                //testlabel.Text = Convert.ToString(currentGuesses[1]);
            }
            else if (currentGuesses[2] == 0)
            {
                guessDisplay3.ImageUrl = "Images/green_circle.png";
                currentGuesses[2] = 3;
                //testlabel.Text = Convert.ToString(currentGuesses[2]);
            }
            else if (currentGuesses[3] == 0)
            {
                guessDisplay4.ImageUrl = "Images/green_circle.png";
                currentGuesses[3] = 3;
                //testlabel.Text = Convert.ToString(currentGuesses[3]);
            }
        }
    }
    protected void ansButton4_Click(object sender, EventArgs e)
    {
        if (gameStatus == 0)
        {

        }
        else
        { 
        if (currentGuesses[0] == 0)
        {
            guessDisplay1.ImageUrl = "Images/yellow_circle.png";
            currentGuesses[0] = 4;
            //testlabel.Text = Convert.ToString(currentGuesses[0]);
        }
        else if (currentGuesses[1] == 0)
        {
            guessDisplay2.ImageUrl = "Images/yellow_circle.png";
            currentGuesses[1] = 4;
            //testlabel.Text = Convert.ToString(currentGuesses[1]);
        }
        else if (currentGuesses[2] == 0)
        {
            guessDisplay3.ImageUrl = "Images/yellow_circle.png";
            currentGuesses[2] = 4;
            //testlabel.Text = Convert.ToString(currentGuesses[2]);
        }
        else if (currentGuesses[3] == 0)
        {
            guessDisplay4.ImageUrl = "Images/yellow_circle.png";
            currentGuesses[3] = 4;
            //testlabel.Text = Convert.ToString(currentGuesses[3]);
        }
    }
}
    // This button resets the CURRENT GUESS, changing the values back to null and allowing the user to input a different guess to submit
    protected void resetGuessButton_Click1(object sender, EventArgs e)
    {
        if (gameStatus == 0)
        {

        }
        else
        {
            for (int i = 0; i < currentGuesses.Length; i++)
            {
                currentGuesses[i] = 0;
            }
            guessDisplay1.ImageUrl = "Images/white_circle.png";
            guessDisplay2.ImageUrl = "Images/white_circle.png";
            guessDisplay3.ImageUrl = "Images/white_circle.png";
            guessDisplay4.ImageUrl = "Images/white_circle.png";
        }
    }

    // if you haven't input a full guess you'll be reminded of this and the guess WILL NOT be submitted
    /*  if (currentGuesses.Length < 4)
      {
          MessageBox.Show("Some text", "Some title",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
      }*/
    // if you have a full guess it is submitted




    // This button submits the CURRENT GUESS and compares it to THE CODE. If guess is the same you win! If not, it tells you how close you are and
    // Iterates the number of ATTEMPTS MADE
    protected void submitButton_Click(object sender, EventArgs e)
    {
        if (gameStatus == 0)
        {

        }
        else
        {
            //working out row index for storing guesses in array
            /* int rowIndex;

             if (attemptsMade > 0)
             {
                 rowIndex = attemptsMade - 1;
             }
             else
             {
                 rowIndex = 0;
             }*/

            int fullyCorrect = 0;
            int colourCorrect = 0;
            int[] submittedAnswer = new int[codeAnswer.Length];
            int[] codeComparison = new int[codeAnswer.Length];

            for (int i = 0; i < submittedAnswer.Length; i++)
            {
                submittedAnswer[i] = currentGuesses[i];
                codeComparison[i] = codeAnswer[i];
            }
            for (int i = 0; i < submittedAnswer.Length; i++)
            {
                bool exactSame = (submittedAnswer[i] == codeComparison[i]);

                if (exactSame)
                {
                    fullyCorrect++;
                    submittedAnswer[i] = 0;
                    codeComparison[i] = 0;
                }
            }
            // at this stage, you have the total number of FULLY correct values, and those values have been removed from the SUBMITTED
            // ANSWER array, replaced with 0's. Next stage compares the guess and answer again, ignoring any 0's and picking up any numbers that exist
            // in both arrays. Any numbers that exist in both will iterate the COLOURCORRECT array and be be changed to 0.
            for (int j = 0; j < submittedAnswer.Length; j++)
            {
                for (int i = 0; i < codeComparison.Length; i++)
                {
                    bool validComp = (submittedAnswer[j] != 0) && (codeComparison[i] != 0);
                    bool sameColour = (submittedAnswer[j] == codeComparison[i]);

                    if (validComp && sameColour)
                    {
                        colourCorrect++;
                        // eliminate guessed answer
                        submittedAnswer[j] = 0;
                        codeComparison[i] = 0;
                    }
                }
            }
            // FOR TESTING PURPOSES
            //partialCorrectLabel.Text = "Partially correct = " + colourCorrect;
            //fullyCorrectLabel.Text = "Fully correct = " + fullyCorrect;

            if (fullyCorrect == 4)
            {
                guessInstr.Text = "<strong> <font-size:30px>You win! </font-size> </strong> <br/>The correct answer was: ";


            }
            else
            {

                switch (attemptsMade)
                {
                    case 0:
                        // display[rowIndex, 0] = currentGuesses[0];
                        switch (currentGuesses[0])
                        {
                            case 1:
                                R1Slot1.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R1Slot1.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R1Slot1.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R1Slot1.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        //  display[rowIndex, 0] = currentGuesses[1];
                        switch (currentGuesses[1])
                        {
                            case 1:
                                R1Slot2.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R1Slot2.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R1Slot2.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R1Slot2.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[2];
                        switch (currentGuesses[2])
                        {
                            case 1:
                                R1Slot3.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R1Slot3.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R1Slot3.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R1Slot3.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[3];
                        switch (currentGuesses[3])
                        {
                            case 1:
                                R1Slot4.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R1Slot4.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R1Slot4.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R1Slot4.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        break;
                    case 1:
                        switch (currentGuesses[0])
                        {
                            case 1:
                                R2Slot1.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R2Slot1.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R2Slot1.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R2Slot1.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        //  display[rowIndex, 0] = currentGuesses[1];
                        switch (currentGuesses[1])
                        {
                            case 1:
                                R2Slot2.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R2Slot2.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R2Slot2.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R2Slot2.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[2];
                        switch (currentGuesses[2])
                        {
                            case 1:
                                R2Slot3.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R2Slot3.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R2Slot3.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R2Slot3.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[3];
                        switch (currentGuesses[3])
                        {
                            case 1:
                                R2Slot4.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R2Slot4.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R2Slot4.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R2Slot4.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        switch (currentGuesses[0])
                        {
                            case 1:
                                R3Slot1.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R3Slot1.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R3Slot1.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R3Slot1.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        //  display[rowIndex, 0] = currentGuesses[1];
                        switch (currentGuesses[1])
                        {
                            case 1:
                                R3Slot2.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R3Slot2.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R3Slot2.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R3Slot2.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[2];
                        switch (currentGuesses[2])
                        {
                            case 1:
                                R3Slot3.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R3Slot3.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R3Slot3.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R3Slot3.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[3];
                        switch (currentGuesses[3])
                        {
                            case 1:
                                R3Slot4.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R3Slot4.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R3Slot4.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R3Slot4.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (currentGuesses[0])
                        {
                            case 1:
                                R4Slot1.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R4Slot1.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R4Slot1.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R4Slot1.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        //  display[rowIndex, 0] = currentGuesses[1];
                        switch (currentGuesses[1])
                        {
                            case 1:
                                R4Slot2.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R4Slot2.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R4Slot2.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R4Slot2.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[2];
                        switch (currentGuesses[2])
                        {
                            case 1:
                                R4Slot3.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R4Slot3.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R4Slot3.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R4Slot3.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[3];
                        switch (currentGuesses[3])
                        {
                            case 1:
                                R4Slot4.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R4Slot4.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R4Slot4.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R4Slot4.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        switch (currentGuesses[0])
                        {
                            case 1:
                                R5Slot1.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R5Slot1.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R5Slot1.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R5Slot1.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        //  display[rowIndex, 0] = currentGuesses[1];
                        switch (currentGuesses[1])
                        {
                            case 1:
                                R5Slot2.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R5Slot2.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R5Slot2.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R5Slot2.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[2];
                        switch (currentGuesses[2])
                        {
                            case 1:
                                R5Slot3.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R5Slot3.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R5Slot3.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R5Slot3.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[3];
                        switch (currentGuesses[3])
                        {
                            case 1:
                                R5Slot4.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R5Slot4.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R5Slot4.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R5Slot4.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5:
                        switch (currentGuesses[0])
                        {
                            case 1:
                                R6Slot1.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R6Slot1.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R6Slot1.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R6Slot1.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        //  display[rowIndex, 0] = currentGuesses[1];
                        switch (currentGuesses[1])
                        {
                            case 1:
                                R6Slot2.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R6Slot2.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R6Slot2.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R6Slot2.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[2];
                        switch (currentGuesses[2])
                        {
                            case 1:
                                R6Slot3.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R6Slot3.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R6Slot3.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R6Slot3.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[3];
                        switch (currentGuesses[3])
                        {
                            case 1:
                                R6Slot4.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R6Slot4.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R6Slot4.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R6Slot4.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        break;
                    case 6:
                        switch (currentGuesses[0])
                        {
                            case 1:
                                R7Slot1.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R7Slot1.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R7Slot1.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R7Slot1.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        //  display[rowIndex, 0] = currentGuesses[1];
                        switch (currentGuesses[1])
                        {
                            case 1:
                                R7Slot2.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R7Slot2.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R7Slot2.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R7Slot2.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[2];
                        switch (currentGuesses[2])
                        {
                            case 1:
                                R7Slot3.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R7Slot3.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R7Slot3.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R7Slot3.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[3];
                        switch (currentGuesses[3])
                        {
                            case 1:
                                R7Slot4.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R7Slot4.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R7Slot4.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R7Slot4.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        break;
                    case 7:
                        switch (currentGuesses[0])
                        {
                            case 1:
                                R8Slot1.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R8Slot1.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R8Slot1.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R8Slot1.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        //  display[rowIndex, 0] = currentGuesses[1];
                        switch (currentGuesses[1])
                        {
                            case 1:
                                R8Slot2.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R8Slot2.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R8Slot2.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R8Slot2.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[2];
                        switch (currentGuesses[2])
                        {
                            case 1:
                                R8Slot3.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R8Slot3.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R8Slot3.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R8Slot3.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        // display[rowIndex, 0] = currentGuesses[3];
                        switch (currentGuesses[3])
                        {
                            case 1:
                                R8Slot4.ImageUrl = "Images/red_circle.png";
                                break;
                            case 2:
                                R8Slot4.ImageUrl = "Images/blue_circle.png";
                                break;
                            case 3:
                                R8Slot4.ImageUrl = "Images/green_circle.png";
                                break;
                            case 4:
                                R8Slot4.ImageUrl = "Images/yellow_circle.png";
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;

                }

                switch (attemptsMade)
                {
                    case 0:
                        R1Result.Text = "<strong>Guess No.1</strong> <br> <font color='green'> Correct: " + fullyCorrect + "</font color> </br>" + "<font color='blue'> Right Colour: " + colourCorrect;
                        break;
                    case 1:
                        R2Result.Text = "<strong>Guess No.2</strong> <br> <font color='green'> Correct: " + fullyCorrect + "</font color> </br>" + "<font color='blue'> Right Colour: " + colourCorrect;
                        break;
                    case 2:
                        R3Result.Text = "<strong>Guess No.3</strong> <br> <font color='green'> Correct: " + fullyCorrect + "</font color> </br>" + "<font color='blue'> Right Colour: " + colourCorrect;
                        break;
                    case 3:
                        R4Result.Text = "<strong>Guess No.4</strong> <br> <font color='green'> Correct: " + fullyCorrect + "</font color> </br>" + "<font color='blue'> Right Colour: " + colourCorrect;
                        break;
                    case 4:
                        R5Result.Text = "<strong>Guess No.5</strong> <br> <font color='green'> Correct: " + fullyCorrect + "</font color> </br>" + "<font color='blue'> Right Colour: " + colourCorrect;
                        break;
                    case 5:
                        R6Result.Text = "<strong>Guess No.6</strong> <br> <font color='green'> Correct: " + fullyCorrect + "</font color> </br>" + "<font color='blue'> Right Colour: " + colourCorrect;
                        break;
                    case 6:
                        R7Result.Text = "<strong>Guess No.7</strong> <br> <font color='green'> Correct: " + fullyCorrect + "</font color> </br>" + "<font color='blue'> Right Colour: " + colourCorrect;
                        break;
                    case 7:
                        R8Result.Text = "<strong>Guess No.8</strong> <br> <font color='green'> Correct: " + fullyCorrect + "</font color> </br>" + "<font color='blue'> Right Colour: " + colourCorrect;
                        break;
                    default:
                        break;
                }

                attemptsMade++;

                for (int i = 0; i < currentGuesses.Length; i++)
                {
                    currentGuesses[i] = 0;

                }
                guessDisplay1.ImageUrl = "Images/white_circle.png";
                guessDisplay2.ImageUrl = "Images/white_circle.png";
                guessDisplay3.ImageUrl = "Images/white_circle.png";
                guessDisplay4.ImageUrl = "Images/white_circle.png";
            }
            fullyCorrect = 0;
            colourCorrect = 0;
            if (attemptsMade >= 8)
            {
                guessInstr.Text = "<strong> <font-size:30px>You Lose...</font-size> </strong> <br/>The correct answer was: ";
                gameStatus = 0;
                switch (codeAnswer[0])
                {
                    case 1:
                        guessDisplay1.ImageUrl = "Images/red_circle.png";
                        break;
                    case 2:
                        guessDisplay1.ImageUrl = "Images/blue_circle.png";
                        break;
                    case 3:
                        guessDisplay1.ImageUrl = "Images/green_circle.png";
                        break;
                    case 4:
                        guessDisplay1.ImageUrl = "Images/yellow_circle.png";
                        break;
                    default:
                        break;
                }
                switch (codeAnswer[1])
                {
                    case 1:
                        guessDisplay2.ImageUrl = "Images/red_circle.png";
                        break;
                    case 2:
                        guessDisplay2.ImageUrl = "Images/blue_circle.png";
                        break;
                    case 3:
                        guessDisplay2.ImageUrl = "Images/green_circle.png";
                        break;
                    case 4:
                        guessDisplay2.ImageUrl = "Images/yellow_circle.png";
                        break;
                    default:
                        break;
                }
                // display[rowIndex, 0] = currentGuesses[2];
                switch (codeAnswer[2])
                {
                    case 1:
                        guessDisplay3.ImageUrl = "Images/red_circle.png";
                        break;
                    case 2:
                        guessDisplay3.ImageUrl = "Images/blue_circle.png";
                        break;
                    case 3:
                        guessDisplay3.ImageUrl = "Images/green_circle.png";
                        break;
                    case 4:
                        guessDisplay3.ImageUrl = "Images/yellow_circle.png";
                        break;
                    default:
                        break;
                }
                // display[rowIndex, 0] = currentGuesses[3];
                switch (codeAnswer[3])
                {
                    case 1:
                        guessDisplay4.ImageUrl = "Images/red_circle.png";
                        break;
                    case 2:
                        guessDisplay4.ImageUrl = "Images/blue_circle.png";
                        break;
                    case 3:
                        guessDisplay4.ImageUrl = "Images/green_circle.png";
                        break;
                    case 4:
                        guessDisplay4.ImageUrl = "Images/yellow_circle.png";
                        break;
                    default:
                        break;
                }
            }
        }
    }

    protected void resetButton_Click(object sender, EventArgs e)
    {
        guessDisplay1.ImageUrl = "Images/white_circle.png";
        guessDisplay2.ImageUrl = "Images/white_circle.png";
        guessDisplay3.ImageUrl = "Images/white_circle.png";
        guessDisplay4.ImageUrl = "Images/white_circle.png";
        R1Slot1.ImageUrl = "Images/blank.png";
        R1Slot2.ImageUrl = "Images/blank.png";
        R1Slot3.ImageUrl = "Images/blank.png";
        R1Slot4.ImageUrl = "Images/blank.png";
        R2Slot1.ImageUrl = "Images/blank.png";
        R2Slot2.ImageUrl = "Images/blank.png";
        R2Slot3.ImageUrl = "Images/blank.png";
        R2Slot4.ImageUrl = "Images/blank.png";
        R3Slot1.ImageUrl = "Images/blank.png";
        R3Slot2.ImageUrl = "Images/blank.png";
        R3Slot3.ImageUrl = "Images/blank.png";
        R3Slot4.ImageUrl = "Images/blank.png";
        R4Slot1.ImageUrl = "Images/blank.png";
        R4Slot2.ImageUrl = "Images/blank.png";
        R4Slot3.ImageUrl = "Images/blank.png";
        R4Slot4.ImageUrl = "Images/blank.png";
        R5Slot1.ImageUrl = "Images/blank.png";
        R5Slot2.ImageUrl = "Images/blank.png";
        R5Slot3.ImageUrl = "Images/blank.png";
        R5Slot4.ImageUrl = "Images/blank.png";
        R6Slot1.ImageUrl = "Images/blank.png";
        R6Slot2.ImageUrl = "Images/blank.png";
        R6Slot3.ImageUrl = "Images/blank.png";
        R6Slot4.ImageUrl = "Images/blank.png";
        R7Slot1.ImageUrl = "Images/blank.png";
        R7Slot2.ImageUrl = "Images/blank.png";
        R7Slot3.ImageUrl = "Images/blank.png";
        R7Slot4.ImageUrl = "Images/blank.png";
        R8Slot1.ImageUrl = "Images/blank.png";
        R8Slot2.ImageUrl = "Images/blank.png";
        R8Slot3.ImageUrl = "Images/blank.png";
        R8Slot4.ImageUrl = "Images/blank.png";

        R1Result.Text = "";
        R2Result.Text = "";
        R3Result.Text = "";
        R4Result.Text = "";
        R5Result.Text = "";
        R6Result.Text = "";
        R7Result.Text = "";
        R8Result.Text = "";

        guessInstr.Text= "This is your current guess: ";

        for (int i = 0; i < codeAnswer.Length; i++)
        {
            codeAnswer[i] = codeGenerator.Next(Min, Max);
        }
        attemptsMade = 0;
        gameStatus = 1;
    }
} 


