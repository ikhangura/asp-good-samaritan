/// <reference path="jquery-1.10.2.intellisense.js" />

var smartFormAdded = false;

$(document).ready(function () {
    $("#ProgramId").change(function () {
        if (this.value == "SMART") {
            //alert("SMART OPTION SELECTED");
            addSmartForm();
        } else {
            if (smartFormAdded) {
                removeSmartForm();
            }
        }
    })

    $("#create_user_form").submit(function () {
        if ($('#create_user_form').valid()) {
            alert("TRUE");
        } else {
            alert("FALSE");
        }
    })
})

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
    document.getElementById("smart-form-placeholder").style.display = "inline";
}

function removeSmartForm() {
    //document.getElementById("smart-form-placeholder").innerHTML = "";
    document.getElementById("smart-form-placeholder").style.display = "none";
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

