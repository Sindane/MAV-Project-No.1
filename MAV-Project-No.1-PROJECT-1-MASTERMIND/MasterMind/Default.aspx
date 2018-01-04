<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mastermind Game</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    </head>
<body>
    <form id="form1" runat="server" >
    <div class="container">
        <div class="row">
            <div class="col-sm-3">
            <h2 style="text-align:center;"><u>Instructions</u></h2>
                <p style="text-align:justify;">This is a code breaking game. <br /><br />A code made up of 4 colours will be 
                    randomly generated; the goal is to try and guess the correct code within a limited number of guesses. The 
                    correct answer must have the exact combination of colours in exactly the right order to win. <br /><br />To 
                    make a guess, click on the coloured buttons to the right. Each time you click a button the empty circles 
                    beneath will be filled in, from left to right. Once you have selected 4 colours, click the 'Submit Answer' 
                    button to make your guess. If your not happy with what you've selected, click 'Clear Answer' to reset your 
                    choices. <br /><br />Your guesses will appear in the box to the right and will inform you how many of the 
                    colours you guessed correctly, and how many of those colours were in the right place.</p>
        </div>
            <div class="col-sm-5">
        <h1 style=" text-align:center; font-size:50px">Mastermind</h1>

                <%-- Experimental stuff ignore --%>
       <%-- <asp:Label ID="IntroLabel" runat="server" Text="Try to guess the secret code! Choose your difficulty from the options below: "></asp:Label>
        <br />
        <br />
        <asp:Label ID="DifficultyLabel" runat="server" Text="Difficulty:"></asp:Label>
        <br />
        <asp:Button ID="EasyButton" runat="server" Text="Easy" />
        <asp:Label ID="EasyDescription" runat="server" Text="no. colours, no. tries"></asp:Label>
        <br />
        <asp:Button ID="NormalButton" runat="server" Text="Normal" />
        <asp:Label ID="NormalDescription" runat="server" Text="no. colours, no. tries"></asp:Label>
        <br />
        <asp:Button ID="HardButton" runat="server" Text="Hard" />
        <asp:Label ID="HardDescription" runat="server" Text="no. colours, no. tries"></asp:Label>
        <br /> --%>
        <%--<asp:Label ID="gameEndLabel" runat="server"></asp:Label>
         <asp:Label ID="numGen" runat="server" Text="TESTING: This is the correct code:"></asp:Label>
        <asp:Label ID="numArray" runat="server"></asp:Label>--%>
        <%-- <asp:Label ID="testlabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="testlabel2" runat="server"></asp:Label>
        <asp:Label ID="partialCorrectLabel" runat="server"></asp:Label>
        <asp:Label ID="fullyCorrectLabel" runat="server"></asp:Label>--%>
    

    <div>
        <table runat="server" style="width:400px; height:40px;">
            <tr>
                <td><asp:Button ID="submitButton" runat="server" Text="Submit Answer" OnClick="submitButton_Click" Width="210px" Height="30px" /></td>
                <td><asp:Button ID="resetGuessButton" runat="server" Text="Clear Answer" OnClick="resetGuessButton_Click1" Width="210px" Height="30px"  /></td>
            </tr>
        </table>
    </div>
        
    <div style="text-align:center;">
        <div style="text-align:center;">
            <table runat="server">
                <tr>
                    <td><asp:Label ID="guessSelect" runat="server" Text="Input your guess with these buttons: " Width="200px"></asp:Label></td>
                    <td><asp:ImageButton ID="ansButton1" runat="server" ImageUrl="~/MasterMind/Images/red_circle.png" Height="50px" Width="50px" OnClick="ansButton1_Click" /></td>
                    <td><asp:ImageButton ID="ansButton2" runat="server" ImageUrl="~/MasterMind/Images/blue_circle.png" Height="50px" Width="50px" OnClick="ansButton2_Click" /></td>
                    <td><asp:ImageButton ID="ansButton3" runat="server" ImageUrl="~/MasterMind/Images/green_circle.png" Height="50px" Width="50px" OnClick="ansButton3_Click" /></td>
                    <td><asp:ImageButton ID="ansButton4" runat="server" ImageUrl="~/MasterMind/Images/yellow_circle.png" Height="50px" Width="50px" OnClick="ansButton4_Click" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="guessInstr" runat="server" Text="This is your current guess: " Width="200px"></asp:Label></td>
                    <td><asp:Image ID="guessDisplay1" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="guessDisplay2" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="guessDisplay3" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="guessDisplay4" runat="server" Height="50px" Width="50px"></asp:Image></td>
                </tr>
            </table>
        </div>
    </div>

    <br />
    <br />

    <div style="text-align:center;">
        <div style="width:423px; text-align:left; border-style:solid;">
            <table runat="server" style="width:400px; height: 300px;">
                <tr>
                    <td><asp:Label ID="R1Result" runat="server" Width="200px"></asp:Label></td>
                    <td><asp:Image ID="R1Slot1" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R1Slot2" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R1Slot3" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R1Slot4" runat="server" Height="50px" Width="50px"></asp:Image></td>
                </tr>
                <tr>
                    <td><asp:Label ID="R2Result" runat="server" Width="200px"></asp:Label></td>
                    <td><asp:Image ID="R2Slot1" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R2Slot2" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R2Slot3" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R2Slot4" runat="server" Height="50px" Width="50px"></asp:Image></td>
                </tr>
                <tr>
                    <td><asp:Label ID="R3Result" runat="server" Width="200px"></asp:Label></td>
                    <td><asp:Image ID="R3Slot1" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R3Slot2" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R3Slot3" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R3Slot4" runat="server" Height="50px" Width="50px"></asp:Image></td>
                </tr>
                <tr>
                    <td><asp:Label ID="R4Result" runat="server" Width="200px"></asp:Label></td>
                    <td><asp:Image ID="R4Slot1" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R4Slot2" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R4Slot3" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R4Slot4" runat="server" Height="50px" Width="50px"></asp:Image></td>
                </tr>
                <tr>
                    <td><asp:Label ID="R5Result" runat="server" Width="200px"></asp:Label></td>
                    <td><asp:Image ID="R5Slot1" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R5Slot2" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R5Slot3" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R5Slot4" runat="server" Height="50px" Width="50px"></asp:Image></td>
                </tr>
                <tr>
                    <td><asp:Label ID="R6Result" runat="server" Width="200px"></asp:Label></td>
                    <td><asp:Image ID="R6Slot1" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R6Slot2" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R6Slot3" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R6Slot4" runat="server" Height="50px" Width="50px"></asp:Image></td>
                </tr>
                <tr>
                    <td><asp:Label ID="R7Result" runat="server" Width="200px"></asp:Label></td>
                    <td><asp:Image ID="R7Slot1" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R7Slot2" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R7Slot3" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R7Slot4" runat="server" Height="50px" Width="50px"></asp:Image></td>
                </tr> 
                <tr>
                    <td><asp:Label ID="R8Result" runat="server" Width="200px"></asp:Label></td>
                    <td><asp:Image ID="R8Slot1" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R8Slot2" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R8Slot3" runat="server" Height="50px" Width="50px"></asp:Image></td>
                    <td><asp:Image ID="R8Slot4" runat="server" Height="50px" Width="50px"></asp:Image></td>
                </tr>
            </table>
        </div>
    

        <br />


</div>
                <asp:Button ID="resetButton" runat="server" Text="Reset Game" Font-Size="20px" Height="50px" Width="425px" OnClick="resetButton_Click" />
                <br />
                <br />
        </div>

        </div>
        </div>
    </form>
</body>
</html>
