import React, { Component } from "react";
import Greeting from "./Components/Greeting";
import FlightDetails from "./Components/FlightDetails";
import LoginButton from "./Components/LoginButton";
import LogoutButton from "./Components/LogoutButton";
import "./App.css";

class App extends Component {
  constructor(props) {
    super(props);

    this.state = {
      isLoggedIn: false,
      ticketBooked: false
    };
  }

  handleLogin = () => {
    this.setState({
      isLoggedIn: true,
      ticketBooked: false
    });
  };

  handleLogout = () => {
    this.setState({
      isLoggedIn: false,
      ticketBooked: false
    });
  };

  handleBookTicket = () => {
    this.setState({
      ticketBooked: true
    });
  };

  render() {
    return (
      <div className="container">

        <Greeting isLoggedIn={this.state.isLoggedIn} />

        <FlightDetails
          isLoggedIn={this.state.isLoggedIn}
          ticketBooked={this.state.ticketBooked}
          onBook={this.handleBookTicket}
        />

        <br />

        {this.state.isLoggedIn ? (
          <LogoutButton onClick={this.handleLogout} />
        ) : (
          <LoginButton onClick={this.handleLogin} />
        )}

      </div>
    );
  }
}

export default App;