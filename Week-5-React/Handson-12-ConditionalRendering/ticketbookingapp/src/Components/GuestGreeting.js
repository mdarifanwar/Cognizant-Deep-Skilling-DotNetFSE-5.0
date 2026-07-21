import React from "react";
import FlightDetails from "./FlightDetails";

function GuestGreeting() {
    return (
        <div>
            <h1>Please sign up.</h1>

            <FlightDetails canBook={false} />
        </div>
    );
}

export default GuestGreeting;