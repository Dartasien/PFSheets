<%@ Page Title="Character Sheet" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateNewCharacter.aspx.cs" Inherits="PFSheets.CreateNewCharacter" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(function ()
        {
            //Sums up the initiatives input
            var totalMod = 0;
            $("#<%=totalMod.ClientID%>").val(totalMod);
            $("input.modInput").on('input', function () {
                totalMod = 0;
                $("input.modInput").each(function () {
                    if (!isNaN(this.value)) {
                        totalMod += parseInt(this.value);
                    }
                });
                $("#<%=totalMod.ClientID%>").val(totalMod);
            });
        });
    </script>
    <h2 class="text-center"><%: Title %></h2>
    <div class="row">
        <section class="col-md-6">
            <h4 class="table-bordered h4">Character</h4>
            <table class="table-condensed table-bordered">
                <tbody>
                    <tr class="row">
                        <td><label for="charName">Character Name:</label></td>
                        <td><input class="input-sm" name="charName" type="text" placeholder="ChemicalDragon" required></td>
                    </tr>
                    <tr class="row">
                        <td><label for="playerName">Name:</label></td>
                        <td><input class="input-sm" name="playerName" type="text" required></td>
                    </tr>
                    <tr class="row">
                        <td><label>Race:</label></td>
                        <td><input class="input-sm" name="race" type="text" placeholder="Human" required></td>
                    </tr>
                    <tr class="row">
                        <td><label for="alignment">Alignment:</label></td>
                        <td><input class="input-sm" name="alignment" type="text" placeholder="Lawful Good" required></td>
                    </tr>
                    <tr class="row">
                        <td><label for="deity">Deity:</label></td>
                        <td><input class="input-sm" name="deity" type="text"></td>
                    </tr>
                </tbody>
            </table>
        </section>
        <section class="col-md-6">
            <h4 class="table-bordered h4">Classes</h4>
            <table class="table-condensed table-bordered">
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
        <section class="col-md-6" id="modSection">
            <h4 class="table-bordered h4">Initiative</h4>
            <table class="table-condensed table-bordered">
                <tbody>
                    <tr class="row">
                        <td><label for="dexMod">Dex Mod:</label></td>
                        <td><input class="modInput" type="number" name="dexMod" min="0" value="0"/></td>
                    </tr>
                    <tr class="row">
                        <td><label for="featMod">Feat Mod:</label></td>
                        <td><input class="modInput" type="number" name="featMod" min="0" value="0"/></td>
                    </tr>
                    <tr class="row">
                        <td><label for="raceMod">Race Mod:</label></td>
                        <td><input class="modInput" type="number" name="raceMod" min="0" value="0"/></td>
                    </tr>
                    <tr class="row">
                        <td><label for="miscMod">Miscellaneous Mod:</label></td>
                        <td><input class="modInput" type="number" name="miscMod" min="0" value="0"/></td>
                    </tr>
                    <tr class="row">
                        <td><label>Total of Mods:</label></td>
                        <td><asp:TextBox ID="totalMod" runat="server" ReadOnly="True"/></td>
                    </tr>
                </tbody>
            </table>
        </section>
    </div>
    <asp:Button runat="server" CssClass="btn-primary text-right center-block" ID="SaveBtn" Text="Save New Character" OnClick="SaveBtn_OnClick"/>
    <h4><%: Title %></h4>
</asp:Content>
