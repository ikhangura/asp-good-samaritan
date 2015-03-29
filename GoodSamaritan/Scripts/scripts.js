/// <reference path="jquery-1.10.2.intellisense.js" />

var smartFormAdded = false;

$(document).ready(function () {

    alert(document.getElementById("ProgramId").value);

    if (document.getElementById("ProgramId").value == 3) {
        addSmartForm();
    } else {
        removeSmartForm();
    }

    $("#ProgramId").change(function() {
        if (this.value == 3) {
            alert("SMART OPTION SELECTED");
            addSmartForm();
        } else {
            if (smartFormAdded) {
                removeSmartForm();
            }
        }
    })

    $("#signupform").submit(function () {
        if ($('#signupform').valid()) {
            alert("TRUE");
        } else {
            alert("FALSE");
        }
    })
})

function checkIfSmartSelected() {
    alert(document.getElementById("ProgramId").value);
    if (document.getElementById("ProgramId").value == 3) {
        alert("Adding");
        addSmartForm();
    } else {
        alert("Removing");
        removeSmartForm();
    }
}

function validateExtras() {
    var status = true;
    alert("HERE");

    //if smart is not loaded then don't validate it
    if (document.getElementById("ProgramId").value != 3) {
        return true;
    }


    var accompMin = document.getElementById("SmartModel_AccompanimentMinutes").value;
    var transNum = document.getElementById("SmartModel_NumberTransportsProvided").value;
    alert(accompMin);
    if (accompMin.match(/^[0-9]+$/) == null) {
        alert("accompMin: failure");
        document.getElementById("accompaniment_minutes_error").innerHTML = "The Required Field Must Be A Number";
        status = false;
    } else {
        alert("accompMin: passed");
    }

    if (transNum.match(/^[0-9]+$/) == null) {
        alert("transNum: failure");
        document.getElementById("transNum_error").innerHTML = "The Required Field Must Be A Number";
        status = false;
    } else {
        alert("transNum: passed");
    }

    return status;
}

function addSmartForm() {
    /*$.ajax({
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
    return false;*/
    smartFormAdded = true;
    document.getElementById("smart-entity-placeholder").style.display = "inline";
}

function removeSmartForm() {
    //document.getElementById("smart-form-placeholder").innerHTML = "";
    document.getElementById("smart-entity-placeholder").style.display = "none";
}



/* Beginning of Angular */

(function () {

    angular.module("createUserViewer", []).
        controller("FormController", ["$scope", function ($scope) {
            $scope.userFormInfo = {};
            $scope.smartFormInfo = {};

            $scope.saveInfo = function () {
                console.log($scope.userFormInfo);
                console.log($scope.smartFormInfo);
            };
            //$scope.saveUserInfo = saveUserInfo;
            //$scope.saveSmartInfo = saveSmartInfo;
        }]);



    var saveUserInfo = function () {

    }

    var saveSmartInfo = function () {

    }
}());

