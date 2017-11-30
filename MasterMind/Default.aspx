<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mastermind Game</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Mastermind Game</h1>
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
        <asp:Label ID="gameEndLabel" runat="server"></asp:Label>
        <asp:Label ID="numGen" runat="server" Text="TESTING: This is the correct code:"></asp:Label>
        <asp:Label ID="numArray" runat="server"></asp:Label>
        <br />
        <asp:Label ID="testlabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="testlabel2" runat="server"></asp:Label>
        



    </div>
    
    <table runat="server" style="width:300px; height: 300px;">
       <%-- <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr> --%>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Label ID="R1Slot1" runat="server"></asp:Label></td>
            <td><asp:Label ID="R1Slot2" runat="server"></asp:Label></td>
            <td><asp:Label ID="R1Slot3" runat="server"></asp:Label></td>
            <td><asp:Label ID="R1Slot4" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><asp:Label ID="guessDisplay1" runat="server"></asp:Label></td>
            <td><asp:Label ID="guessDisplay2" runat="server"></asp:Label></td>
            <td><asp:Label ID="guessDisplay3" runat="server"></asp:Label></td>
            <td><asp:Label ID="guessDisplay4" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            <td><asp:Button ID="ansButton1" runat="server" Text="1" OnClick="ansButton1_Click1"/></td>
            <td><asp:Button ID="ansButton2" runat="server" Text="2" OnClick="ansButton2_Click" /></td>
            <td><asp:Button ID="ansButton3" runat="server" Text="3" OnClick="ansButton3_Click" /></td>
            <td><asp:Button ID="ansButton4" runat="server" Text="4" OnClick="ansButton4_Click" /></td>
        </tr>
    </table>
    <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" />
    <asp:Button ID="resetGuessButton" runat="server" Text="Clear Guess" OnClick="resetGuessButton_Click1" />
    </form>
</body>
</html>
