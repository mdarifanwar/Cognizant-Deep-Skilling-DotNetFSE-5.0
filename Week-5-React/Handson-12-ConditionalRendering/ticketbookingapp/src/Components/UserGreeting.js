import React from "react";
import FlightDetails from "./FlightDetails";

function UserGreeting() {
    return (
        <div>
            <h1>Welcome back</h1>

            <FlightDetails canBook={true} />
        </div>
    );
}

export default UserGreeting;