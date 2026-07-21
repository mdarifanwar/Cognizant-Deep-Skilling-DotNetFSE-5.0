import React, { Component } from "react";

const headerStyle = {
    border: "2px solid #bfbfbf",
    padding: "8px 15px",
    color: "#66CC66",
    fontWeight: "bold",
    textAlign: "center"
};

const cellStyle = {
    border: "2px solid #bfbfbf",
    padding: "8px 15px",
    color: "#66CC66",
    fontWeight: "normal",
    textAlign: "center"
};

class Cart extends Component {

    render() {

        return (

            <div
                style={{
                    display: "inline-block",
                    border: "2px solid #bfbfbf",
                    padding: "8px",
                    boxShadow: "3px 3px 6px rgba(0,0,0,0.25)",
                    backgroundColor: "white"
                }}
            >

                <table
                    style={{
                        borderCollapse: "collapse"
                    }}
                >

                    <thead>

                        <tr>

                            <th style={headerStyle}>
                                Name
                            </th>

                            <th style={headerStyle}>
                                Price
                            </th>

                        </tr>

                    </thead>

                    <tbody>

                        {this.props.item.map((item, index) => (

                            <tr key={index}>

                                <td style={cellStyle}>
                                    {item.itemname}
                                </td>

                                <td style={cellStyle}>
                                    {item.price}
                                </td>

                            </tr>

                        ))}

                    </tbody>

                </table>

            </div>

        );

    }

}

export default Cart;