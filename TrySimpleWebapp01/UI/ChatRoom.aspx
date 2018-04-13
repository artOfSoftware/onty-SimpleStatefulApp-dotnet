<%@ Page Title="Chat Room" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChatRoom.aspx.cs" Inherits="TrySimpleWebapp01.ChatRoom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server"> 

	<link rel="stylesheet" type="text/css" href="/Content/ChatRoom.css">

	<table class="outer">
		<tr>
			<td>
				<div class="leftSide side">
					<h1 class="userSays centered white">Please say something below:</h1>
					<div class="userSays white">Your name:</div>
					<asp:TextBox ID="textUserName" runat="server" TextMode="SingleLine" CssClass="userSays "></asp:TextBox>
					<div class="userSays white">Your message:</div>
					<asp:TextBox ID="textUserSays" runat="server" Rows="10" TextMode="MultiLine" CssClass="userSays"></asp:TextBox>
					<asp:Button ID="buttonUserSaysClick" CssClass="userSaysButton white" runat="server" Text="Say it!" OnClick="buttonUserSaysClick_Click" />
				</div>
			</td>
			<td>
				<div class="rightSide side">
					<h1 class="userSays centered white">Conversation:</h1>

					<div class="convHist">
						<asp:Table ID="tableConvHist" runat="server" CssClass="convHist" GridLines="Both"></asp:Table>
					</div>

					<div class="commands">
						<asp:Button ID="buttonRefresh" runat="server" Text="Refresh" OnClick="buttonRefresh_Click" />
						<span class="raisedText">&nbsp;or</span>
						<asp:Button ID="buttonClear" runat="server" Text="Clear" OnClick="buttonClear_Click" />
					</div>

				</div>

			</td>
		</tr>
	</table>

</asp:Content>
