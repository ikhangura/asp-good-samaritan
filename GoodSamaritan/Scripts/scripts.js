/// <reference path="jquery-1.10.2.intellisense.js" />

var smartFormAdded = false;

$(document).ready(function () {
    $("#ProgramId").change(function () {
        if (this.value == 3) {
            //alert("SMART OPTION SELECTED");
            addSmartForm();
        } else {
            if (smartFormAdded) {
                removeSmartForm();
            }
        }
    })
})

function addSmartForm() {
    $.ajax({
        url: "/SmartModels/Create",
        type: "GET",
        success: function (response) {
            //alert(response);
            //$("#formShell").html += response;
            document.getElementById("smart-form-placeholder").innerHTML += response;
            smartFormAdded = true;
        },
        error: function (response) {
            alert("There Was An Error Fetching the Smart Portion Of The Form\n\n" + response);
        }
    });
    return false;
}

function removeSmartForm() {
    document.getElementById("smart-form-placeholder").innerHTML = "";
}

