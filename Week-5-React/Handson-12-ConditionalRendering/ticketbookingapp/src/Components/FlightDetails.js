import React from "react";

function FlightDetails(props) {

    return(

        <div>

            <h2>Flight Details</h2>

            <table border="1" cellPadding="8" style={{margin:"auto"}}>

                <tbody>

                    <tr>
                        <th>Flight No</th>
                        <td>AI-202</td>
                    </tr>

                    <tr>
                        <th>From</th>
                        <td>Delhi</td>
                    </tr>

                    <tr>
                        <th>To</th>
                        <td>Mumbai</td>
                    </tr>

                    <tr>
                        <th>Departure</th>
                        <td>10:30 AM</td>
                    </tr>

                    <tr>
                        <th>Fare</th>
                        <td>₹5500</td>
                    </tr>

                </tbody>

            </table>

            <br/>

            {props.isLoggedIn && !props.ticketBooked && (

                <button onClick={props.onBook}>
                    Book Ticket
                </button>

            )}

            {props.ticketBooked && (

                <div>

                    <h2 style={{color:"green"}}>
                        Ticket Booked Successfully!
                    </h2>

                    <h3>Your seat has been confirmed.</h3>

                </div>

            )}

        </div>

    );

}

export default FlightDetails;