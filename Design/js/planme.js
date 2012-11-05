$(document).ready(function(){
	
            $(function() { 
                $("#loginform").validity(function() {
                    $("#login")
                        .require();
                  
                    $("#pswd")
                        .require();
                });
                $.validity.setup({ outputMode:"summary" });

            });
}); 
     