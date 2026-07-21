import React from "react";
import "./App.css";
import officeImage from "./office.jpg";

function App() {

  const officeList = [
    {
      Name: "DBS",
      Rent: 50000,
      Address: "Chennai"
    },
    {
      Name: "Regus",
      Rent: 65000,
      Address: "Bangalore"
    },
    {
      Name: "WeWork",
      Rent: 55000,
      Address: "Hyderabad"
    },
    {
      Name: "SmartWorks",
      Rent: 80000,
      Address: "Pune"
    }
  ];

  return (
    <div className="container">

      <h1>Office Space, at Affordable Range</h1>

      <img
        src={officeImage}
        alt="Office Space"
      />

      {
        officeList.map((office, index) => (

          <div key={index} className="office-card">

            <h2>Name: {office.Name}</h2>

            <h3
              style={{
                color: office.Rent <= 60000 ? "red" : "green"
              }}
            >
              Rent: Rs. {office.Rent}
            </h3>

            <h3>Address: {office.Address}</h3>

            <hr />

          </div>

        ))
      }

    </div>
  );
}

export default App;