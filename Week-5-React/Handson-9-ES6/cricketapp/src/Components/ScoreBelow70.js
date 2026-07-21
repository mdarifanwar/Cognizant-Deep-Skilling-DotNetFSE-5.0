import React from "react";

function ScoreBelow70(props) {

    // Filter players having score less than 70
    const filteredPlayers = props.players.filter(
        player => player.score <= 70
    );

    return (

        <div>

            <ul>

                {filteredPlayers.map((player, index) => (

                    <li key={index}>
                        Mr. {player.name} <span>{player.score}</span>
                    </li>

                ))}

            </ul>

        </div>

    );

}

export default ScoreBelow70;