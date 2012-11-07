$(document).ready(function(){
	
            $(function() { 
                $("#loginform").validity(function() {
                    $("#login")
                        .require();
                  
                    $("#pswd")
                        .require();
                });
                $.validity.setup({ outputMode:"summary" });

                $("#registrationform").validity(function() {
                    $("#newlogin")
                        .require();
                   $("#newemail")
                   	    .match("email")
                        .require();
                   	
                    $("#newname")
                        .require();
                  
                    $("#newpswd")
                        .require();
                });
                $.validity.setup({ outputMode:"summary" });
            });
}); 
     