import React from "react";

// Using ES6 Destructuring
const T20players = ["First Player", "Second Player", "Third Player"];
const RanjiTrophyPlayers = ["Fourth Player", "Fifth Player", "Sixth Player"];

// Using ES6 Spread Operator
export const IndianPlayers = [...T20players, ...RanjiTrophyPlayers];

// Function to display Odd Players
export function OddPlayers(props) {

    const [first, , third, , fifth] = props;

    return (
        <ul>
            <li>First : {first}</li>
            <li>Third : {third}</li>
            <li>Fifth : {fifth}</li>
        </ul>
    );
}

// Function to display Even Players
export function EvenPlayers(props) {

    const [, second, , fourth, , sixth] = props;

    return (
        <ul>
            <li>Second : {second}</li>
            <li>Fourth : {fourth}</li>
            <li>Sixth : {sixth}</li>
        </ul>
    );
}