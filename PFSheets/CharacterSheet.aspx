<%@ Page Title="Character Sheet" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CharacterSheet.aspx.cs" Inherits="PFSheets.CharacterSheet" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4><%: Title %></h4>
    <section id="character" class="section">
        <h2>Character</h2>
        <table class="table-condensed">
            <thead>
                <tr class="row">
                    <th></th>
                    <th class="text-center">Character</th>
                </tr>
            </thead>
            <tbody>
                <tr class="row">
                    <td><label for="charName">Character Name:</label></td>
                    <td><input class="input-sm" name="charName" type="text" placeholder="ChemicalDragon" required></td>
                </tr>
                <tr class="row">
                    <td><label for="playerName">Name:</label></td>
                    <td><input class="input-sm" name="playerName" type="text" required></td>
                    <td><label>Race:</label></td>
                    <td><input class="input-sm" name="race" type="text" placeholder="Human"/ required></td>
                </tr>
                <tr class="row">
                    <td><label for="alignment">Alignment:</label></td>
                    <td><input class="input-sm" name="alignment" type="text" placeholder="Lawful Good" required></td>
                    <td><label for="deity">Deity:</label></td>
                    <td><input class="input-sm" name="deity" type="text"></td>
                </tr>
            </tbody>
        </table>
    </section>
    <section id="classList" class="section">
        <h2>Classes</h2>
        <table class="table-condensed" id="Classes">
            <thead>
                <tr>
                    <th class="text-center">Class</th>
                    <th class="text-center">Level</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    
                    <td><input class="input-sm" name="class1" type="text" required></td>
                    <td><input class="input-sm" name="level1" type="number" min="1" required></td>
                </tr>
                 <tr>
                    <td><input class="input-sm" name="class2" type="text"></td>
                    <td><input class="input-sm" name="level2" type="number" min="0"></td>
                </tr>
                 <tr>
                    <td><input class="input-sm" name="class3" type="text"></td>
                    <td><input class="input-sm" name="level3" type="number" min="0"></td>
                </tr>
                 <tr>
                    <td><input class="input-sm" name="class4" type="text"></td>
                    <td><input class="input-sm" name="level4" type="number" min="0"></td>
                </tr>
                <tr>
                    <td><input class="input-sm" name="class5" type="text"></td>
                    <td><input class="input-sm" name="level5" type="number" min="0"></td>
            </tbody>
        </table>
    </section>
    <asp:Button runat="server" CssClass="btn-primary text-right" ID="SaveBtn" Text="Save" OnClick="SaveBtn_OnClick"/>
    <h4><%: Title %></h4>
</asp:Content>
