
namespace typescriptgame {
    const startBtn = document.querySelector("#startBtn");
    const msg = document.querySelector("#msg");
    const p1Score: HTMLParagraphElement = document.querySelector("#p1Score");
    const p2Score: HTMLParagraphElement = document.querySelector("#p2Score");
    let playerOne = 0;
    let playerTwo = 0;
    const pieces: HTMLImageElement[] = Array.from(document.querySelectorAll(".piece"));
    let pile = [];
    let backImage: string[] = [];
    let turnArr: HTMLImageElement[] = [];
    let gameStarted = false;
    let currentTurn = "Player One";
    startBtn.textContent = "Start";

    startBtn.addEventListener("click", startGame);
    pieces.forEach(pcs => pcs.addEventListener("click", takeSpot));


    async function takeSpot(e: Event) {
        if (gameStarted && turnArr.length < 2) {
            (e.target as HTMLImageElement).src = backImage[pieces.indexOf(e.target as HTMLImageElement)];
            if (turnArr[0] !== e.target) {
                turnArr.push(e.target as HTMLImageElement);
            }
            if (turnArr.length == 2) {
                await new Promise(resolve => setTimeout(resolve, 2000));
                if (turnArr[0].src === turnArr[1].src) {
                    if (gameStarted) {
                        turnArr.forEach(el => el.style.visibility = "hidden");
                        turnArr = [];
                        if (currentTurn === "Player One") {
                            playerOne++;
                            p1Score.textContent = playerOne.toString();
                        } else {
                            playerTwo++;
                            p2Score.textContent = playerTwo.toString();
                        }
                        checkEndGame();
                    }
                }
                else {
                    turnArr.forEach(p => p.src = "/images/background.jpeg");
                    turnArr = [];
                    currentTurn = (currentTurn === "Player One") ? "Player Two" : "Player One";
                    msg.textContent = currentTurn + "'s Turn";
                }
            }
        }
    }

    function checkEndGame() {
        let b = pieces.every(el => el.style.visibility === "hidden");
        if (b) {
            if (playerOne > playerTwo) {
                msg.textContent = "Player One Wins!!!";
            } else if (playerTwo > playerOne) {
                msg.textContent = "Player Two Wins!!!";
            } else {
                msg.textContent = "Tie Game!!!";
            }
        }
    }

    function startGame() {
        currentTurn = "Player One";
        if (!gameStarted) {
            pieces.forEach(el => el.style.visibility = "visible");
            gameStarted = true;
            startBtn.textContent = "Stop"
            turnArr = [];
            setupBoard();
            playerOne = 0;
            playerTwo = 0;
            p1Score.textContent = playerOne.toString();
            p2Score.textContent = playerTwo.toString();
            msg.textContent = currentTurn + "'s Turn";
        } else {
            gameStarted = false;
            startBtn.textContent = "Start";
            msg.textContent = "Click Start to Play";
            pieces.forEach(p => p.src = "/images/background.jpeg");
        }
    }

    function setupBoard() {
        backImage = [];
        pile = [
            "/images/bassclef.jpeg", "/images/bumblebee.jpeg", "/images/candy.jpeg", "/images/card.jpeg",
            "/images/chair.jpeg", "/images/dice.jpeg", "/images/lamp.jpeg", "/images/pen.jpeg",
            "/images/squares.jpeg", "/images/trebleclef.jpeg", "/images/bassclef.jpeg", "/images/bumblebee.jpeg",
            "/images/candy.jpeg", "/images/card.jpeg", "/images/chair.jpeg", "/images/dice.jpeg",
            "/images/lamp.jpeg", "/images/pen.jpeg", "/images/squares.jpeg", "/images/trebleclef.jpeg",];

        // while (pile.length > 0) {
        //     let n = pile.splice(Math.floor(Math.random() * pile.length), 1)[0];
        //     backImage.push(n);
        // }
        fisherYatesShuffle(pile);
        backImage.push(...pile);
    }

    function fisherYatesShuffle(arr: string[]) {
        for (let i = arr.length - 1; i > 0; i--) {
            const j = Math.floor(Math.random() * (i + 1));
            [arr[i], arr[j]] = [arr[j], arr[i]];
        }
    }
}