import React, { Component } from "react";

class CurrencyConverter extends Component {

  constructor(props) {
    super(props);

    this.state = {
      amount: "",
      currency: ""
    };
  }

  handleAmountChange = (event) => {
    this.setState({
      amount: event.target.value
    });
  };

  handleCurrencyChange = (event) => {
    this.setState({
      currency: event.target.value
    });
  };

  handleSubmit = (event) => {
    event.preventDefault();

    const amount = parseFloat(this.state.amount);

    if (isNaN(amount)) {
      alert("Please enter a valid amount");
      return;
    }

    // 1 Euro = 80 INR (as per assignment screenshot)
    const convertedAmount = amount * 80;

    alert("Converting to Euro Amount is " + convertedAmount);
  };

  render() {

    return (

      <div>

        <h1 style={{ color: "green" }}>
          Currency Convertor!!!
        </h1>

        <form onSubmit={this.handleSubmit}>

          <table>

            <tbody>

              <tr>
                <td>Amount:</td>

                <td>
                  <input
                    type="number"
                    value={this.state.amount}
                    onChange={this.handleAmountChange}
                  />
                </td>
              </tr>

              <tr>
                <td>Currency:</td>

                <td>
                  <input
                    type="text"
                    value={this.state.currency}
                    onChange={this.handleCurrencyChange}
                  />
                </td>
              </tr>

              <tr>

                <td></td>

                <td>
                  <button type="submit">
                    Submit
                  </button>
                </td>

              </tr>

            </tbody>

          </table>

        </form>

      </div>

    );
  }
}

export default CurrencyConverter;