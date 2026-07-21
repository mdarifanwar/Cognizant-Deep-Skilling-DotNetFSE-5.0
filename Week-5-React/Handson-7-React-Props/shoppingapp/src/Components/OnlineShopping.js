import React, { Component } from "react";
import Cart from "./Cart";

export default class OnlineShopping extends Component {

    render() {

        const CartInfo = [

            { itemname: "Laptop", price: 80000 },

            { itemname: "TV", price: 120000 },

            { itemname: "Washing Machine", price: 50000 },

            { itemname: "Mobile", price: 30000 },

            { itemname: "Fridge", price: 70000 }

        ];

        return (

            <div
                style={{
                    textAlign: "center",
                    marginTop: "25px"
                }}
            >

                <h1
                    style={{
                        color: "green",
                        fontWeight: "bold",
                        fontSize: "52px",
                        marginBottom: "20px"
                    }}
                >
                    Items Ordered :
                </h1>

                <Cart item={CartInfo} />

            </div>

        );

    }

}