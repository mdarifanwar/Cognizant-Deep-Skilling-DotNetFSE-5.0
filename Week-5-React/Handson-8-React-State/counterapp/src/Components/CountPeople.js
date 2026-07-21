import React, { Component } from "react";

class CountPeople extends Component {

    constructor(props) {
        super(props);

        this.state = {
            entrycount: 0,
            exitcount: 0
        };
    }

    updateEntry = () => {
        this.setState((prevState) => ({
            entrycount: prevState.entrycount + 1
        }));
    };

    updateExit = () => {
        this.setState((prevState) => ({
            exitcount: prevState.exitcount + 1
        }));
    };

    render() {

        return (

            <div
                style={{
                    display: "flex",
                    justifyContent: "space-around",
                    alignItems: "center",
                    marginTop: "120px"
                }}
            >

                <div>

                    <button
                        onClick={this.updateEntry}
                        style={{
                            backgroundColor: "lightgreen",
                            border: "2px solid green",
                            cursor: "pointer"
                        }}
                    >
                        Login
                    </button>

                    <span style={{ marginLeft: "8px" }}>
                        {this.state.entrycount} People Entered!!!
                    </span>

                </div>

                <div>

                    <button
                        onClick={this.updateExit}
                        style={{
                            backgroundColor: "lightgreen",
                            border: "2px solid green",
                            cursor: "pointer"
                        }}
                    >
                        Exit
                    </button>

                    <span style={{ marginLeft: "8px" }}>
                        {this.state.exitcount} People Left!!!
                    </span>

                </div>

            </div>

        );
    }
}

export default CountPeople;