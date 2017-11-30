using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


public partial class _Default : System.Web.UI.Page
{
    //initialising the variables needed to randomly generate the final answer the player must guess
    int Min = 1;
    int Max = 5;
    Random codeGenerator = new Random();
    static int[] codeAnswer = new int[4];

    //initialising the arrays for the players current guesses (which will reset on each new guess) and how many guesses the player has made
    static int[] currentGuesses = new int[4];
    static int[] Rounds = new int[8];

    
   
    protected void Page_Load(object sender, EventArgs e)
    {
        foreach (var item in currentGuesses)
        {
            testlabel.Text += item.ToString();
        }
    }

    protected void Page_Init(object sender, EventArgs e)
    {

        // creates the FINAL ANSWER the player must guess on initialising the page
        for (int i = 0; i < codeAnswer.Length; i++)
        {
            codeAnswer[i] = codeGenerator.Next(Min, Max);
        }
        foreach (var item in codeAnswer)
        {
            numArray.Text += item.ToString();
        }
    }

    protected void ansButton1_Click1(object sender, EventArgs e)
    {

        if (currentGuesses[0] == 0)
        {
            guessDisplay1.Text = "1";
            currentGuesses[0] = 1;
            testlabel.Text = Convert.ToString(currentGuesses[0]);
        }
        else if (currentGuesses[1] == 0)
        {
            guessDisplay2.Text = "1";
            currentGuesses[1] = 1;
            testlabel.Text = Convert.ToString(currentGuesses[1]);
        }
        else if (currentGuesses[2] == 0)
        {
            guessDisplay3.Text = "1";
            currentGuesses[2] = 1;
            testlabel.Text = Convert.ToString(currentGuesses[2]);
        }
        else if (currentGuesses[3] == 0)
        {
            guessDisplay4.Text = "1";
            currentGuesses[3] = 1;
            testlabel.Text = Convert.ToString(currentGuesses[3]);
        }


    }
    protected void ansButton2_Click(object sender, EventArgs e)
    {
        if (currentGuesses[0] == 0)
        {
            guessDisplay1.Text = "2";
            currentGuesses[0] = 2;
            testlabel.Text = Convert.ToString(currentGuesses[0]);
        }
        else if (currentGuesses[1] == 0)
        {
            guessDisplay2.Text = "2";
            currentGuesses[1] = 2;
            testlabel.Text = Convert.ToString(currentGuesses[1]);
        }
        else if (currentGuesses[2] == 0)
        {
            guessDisplay3.Text = "2";
            currentGuesses[2] = 2;
            testlabel.Text = Convert.ToString(currentGuesses[2]);
        }
        else if (currentGuesses[3] == 0)
        {
            guessDisplay4.Text = "2";
            currentGuesses[3] = 2;
            testlabel.Text = Convert.ToString(currentGuesses[3]);
        }
    }
    protected void ansButton3_Click(object sender, EventArgs e)
    {
        if (currentGuesses[0] == 0)
        {
            guessDisplay1.Text = "3";
            currentGuesses[0] = 3;
            testlabel.Text = Convert.ToString(currentGuesses[0]);
        }
        else if (currentGuesses[1] == 0)
        {
            guessDisplay2.Text = "3";
            currentGuesses[1] = 3;
            testlabel.Text = Convert.ToString(currentGuesses[1]);
        }
        else if (currentGuesses[2] == 0)
        {
            guessDisplay3.Text = "3";
            currentGuesses[2] = 3;
            testlabel.Text = Convert.ToString(currentGuesses[2]);
        }
        else if (currentGuesses[3] == 0)
        {
            guessDisplay4.Text = "3";
            currentGuesses[3] = 3;
            testlabel.Text = Convert.ToString(currentGuesses[3]);
        }
    }
    protected void ansButton4_Click(object sender, EventArgs e)
    {
        if (currentGuesses[0] == 0)
        {
            guessDisplay1.Text = "4";
            currentGuesses[0] = 4;
            testlabel.Text = Convert.ToString(currentGuesses[0]);
        }
        else if (currentGuesses[1] == 0)
        {
            guessDisplay2.Text = "4";
            currentGuesses[1] = 4;
            testlabel.Text = Convert.ToString(currentGuesses[1]);
        }
        else if (currentGuesses[2] == 0)
        {
            guessDisplay3.Text = "4";
            currentGuesses[2] = 4;
            testlabel.Text = Convert.ToString(currentGuesses[2]);
        }
        else if (currentGuesses[3] == 0)
        {
            guessDisplay4.Text = "4";
            currentGuesses[3] = 4;
            testlabel.Text = Convert.ToString(currentGuesses[3]);
        }
    }

    protected void resetGuessButton_Click1(object sender, EventArgs e)
    {
        for (int i = 0; i < currentGuesses.Length; i++)
        {
            currentGuesses[i] = 0;
        }
        guessDisplay1.Text = "";
        guessDisplay2.Text = "";
        guessDisplay3.Text = "";
        guessDisplay4.Text = "";
    }




    protected void submitButton_Click(object sender, EventArgs e)
    {
        int[] submittedGuess = { currentGuesses[0], currentGuesses[1], currentGuesses[2], currentGuesses[3] };
        string[] guessValidation = new string [4];
        
        if (Rounds[0] == 1)
        {
            if (submittedGuess == codeAnswer)
            {
                gameEndLabel.Text = "You win! Congratulations!";
            }
            else if (codeAnswer.Contains(submittedGuess[0]))
            {
                guessValidation[0] = "is present";

            }

         /*  string[] printer = { "jupiter", "neptune", "pangea", "mercury", "sonic" };
            if (printer.Contains("jupiter"))
            {
                Process.Start("BLAH BLAH CODE TO ADD PRINTER VIA WINDOWS EXEC"");
            }

            string[] stringArray = { "text1", "text2", "text3", "text4" };
            string value = "text3";
            int pos = Array.IndexOf(stringArray, value);
            if (pos > -1)*/







        }
        else
        {

        }
        
    }
}



