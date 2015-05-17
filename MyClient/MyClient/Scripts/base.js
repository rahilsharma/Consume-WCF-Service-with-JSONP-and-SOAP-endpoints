
var wcfServiceUrl, populateDropdown;

// default URL WCF service
wcfServiceUrl = "http://localhost:6573/Service.svc/";


populateDropdown = function () {
    var ID, description;
    ID = this.ID;
    description = this.description;

    $("#selectJSON")
        .append($("<option></option>")
        .val(ID)
        .html(description));    
};



function loadDropDownJSONP(idDropdownJson, idDropdownSoap) {

    // sets both dropdown lists empty
    $("#" + idDropdownSoap + "").html("");
    $("#" + idDropdownJson + "").html("");

    // JSONP CALL TO WCF SERVICE
    $.ajax({
        cache: false,
        url: wcfServiceUrl + "GetTourListJSONP",
        data: "{}",
        type: "GET",
        jsonpCallback: "tourList",
        contentType: "application/javascript",
        dataType: "jsonp",
        error: function () {
            alert("list failed!");
        },
        success: function (list) {
            $.each(list, populateDropdown); // must call function as var
        }
    });

}