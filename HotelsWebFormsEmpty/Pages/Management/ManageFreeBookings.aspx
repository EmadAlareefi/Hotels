<%@ Page Title="Manage Free Booking" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ManageFreeBookings.aspx.cs" Inherits="HotelsWebFormsEmpty.Pages.Management.ManageFreeBookings" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder">

    <div class="content">
    <div id="dialog-form" title="Create new user" >
    </div>

    <div id="users-contain" class="ui-widget">
        <h1>Existing Users:</h1>
        <table id="users" class="ui-widget ui-widget-content">
            <thead>
                <tr class="ui-widget-header ">
                    <th>Name</th>
                    <th>Email</th>
                    <th>Password</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>John Doe</td>
                    <td>john.doe@example.com</td>
                    <td>johndoe1</td>
                </tr>
            </tbody>
        </table>
    </div>
    <button id="create-user">Create new user</button>
    </div>
    <div id="create-user-panel" class="create-user-interface">
        <p class="validateTips">All form fields are required</p>
        <form>
            <fieldset>
                <label for="name">Name</label>
                <input type="text" name="name" id="name" value="Jane Smith" class="text ui-widget-content ui-corner-all">
                <label for="email">Email</label>
                <input type="text" name="email" id="email" value="jane@smith.com" class="text ui-widget-content ui-corner-all">
                <label for="password">Password</label>
                <input type="password" name="password" id="password" value="xxxxxxx" class="text ui-widget-content ui-corner-all">
                <!-- Allow form submission with keyboard without duplicating the dialog button -->
                <input type="submit" tabindex="-1" style="position: absolute;">
            </fieldset>
        </form>
        <div class="exit-btn">

        </div>
    </div>
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script src="../../Scripts/ManageFreeBookings.js"></script>


</asp:Content>


