import React from "react";

function Greeting(props) {

    if(props.isLoggedIn){
        return <h1>Welcome Back</h1>;
    }

    return <h1>Please Sign Up.</h1>;
}

export default Greeting;