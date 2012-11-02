$(document).ready(function(){

    $("#loginform").validate({
        
       rules:{ 
        
            login:{
                required: true,
            },
            
            pswd:{
                required: true,
            },
       },
       
       messages:{
        
            login:{
                required: "Please, enter Your Login",

            },
            
            pswd:{
                required: "Please, enter Your Password",

            },
        
       }
        
    });


}); //end of ready