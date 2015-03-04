var main = function () {
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
};

$(document).ready(main);