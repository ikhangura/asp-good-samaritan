$(document).ready(function () {

    $("#signupform").submit(function () {

        var status = true;

        if ($("#ProgramId").value == 3) {


            var accompMin = document.getElementById("SmartModel_AccompanimentMinutes").innerHTML;
            alert(accompMin);
            if ( accompMin.match(/\^[0-9]*$/) == null) {
                document.getElementById("accompaniment_minutes_error").innerHTML = "The required field must be a number";
                status = false;
            }




           
        }

        return status;
        
    })


    
})