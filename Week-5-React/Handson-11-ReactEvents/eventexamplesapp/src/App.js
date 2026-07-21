import React, { Component } from "react";
import "./App.css";
import CurrencyConverter from "./Components/CurrencyConverter";

class App extends Component {

  constructor(props) {
    super(props);

    this.state = {
      count: 5
    };
  }

  // Increment Counter
  increment = () => {
    this.setState({
      count: this.state.count + 1
    });
  };

  // Decrement Counter
  decrement = () => {
    this.setState({
      count: this.state.count - 1
    });
  };

  // Hello Message
  sayHello = () => {
    alert("Hello! Member!");
  };

  // Increment button invokes multiple methods
  handleIncrement = () => {
    this.increment();
    this.sayHello();
  };

  // Welcome Button
  sayWelcome = (message) => {
    alert(message);
  };

  // Synthetic Event
  handleClick = () => {
    alert("I was clicked");
  };

  render() {

    return (

      <div className="container">

        <h2>{this.state.count}</h2>

        <button onClick={this.handleIncrement}>
          Increment
        </button>

        <br /><br />

        <button onClick={this.decrement}>
          Decrement
        </button>

        <br /><br />

        <button onClick={() => this.sayWelcome("Welcome")}>
          Say Welcome
        </button>

        <br /><br />

        <button onClick={this.handleClick}>
          Click on me
        </button>

        <br /><br />

        <CurrencyConverter />

      </div>

    );
  }
}

export default App;