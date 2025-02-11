var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var typescriptgame;
(function (typescriptgame) {
    const startBtn = document.querySelector("#startBtn");
    const msg = document.querySelector("#msg");
    const p1Score = document.querySelector("#p1Score");
    const p2Score = document.querySelector("#p2Score");
    let playerOne = 0;
    let playerTwo = 0;
    const pieces = Array.from(document.querySelectorAll(".piece"));
    let pile = [];
    let backImage = [];
    let turnArr = [];
    let gameStarted = false;
    let currentTurn = "Player One";
    startBtn.textContent = "Start";
    startBtn.addEventListener("click", startGame);
    pieces.forEach(pcs => pcs.addEventListener("click", takeSpot));
    function takeSpot(e) {
        return __awaiter(this, void 0, void 0, function* () {
            if (gameStarted && turnArr.length < 2) {
                e.target.src = backImage[pieces.indexOf(e.target)];
                if (turnArr[0] !== e.target) {
                    turnArr.push(e.target);
                }
                if (turnArr.length == 2) {
                    yield new Promise(resolve => setTimeout(resolve, 2000));
                    if (turnArr[0].src === turnArr[1].src) {
                        if (gameStarted) {
                            turnArr.forEach(el => el.style.visibility = "hidden");
                            turnArr = [];
                            if (currentTurn === "Player One") {
                                playerOne++;
                                p1Score.textContent = playerOne.toString();
                            }
                            else {
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
        });
    }
    function checkEndGame() {
        let b = pieces.every(el => el.style.visibility === "hidden");
        if (b) {
            if (playerOne > playerTwo) {
                msg.textContent = "Player One Wins!!!";
            }
            else if (playerTwo > playerOne) {
                msg.textContent = "Player Two Wins!!!";
            }
            else {
                msg.textContent = "Tie Game!!!";
            }
        }
    }
    function startGame() {
        currentTurn = "Player One";
        if (!gameStarted) {
            pieces.forEach(el => el.style.visibility = "visible");
            gameStarted = true;
            startBtn.textContent = "Stop";
            turnArr = [];
            setupBoard();
            playerOne = 0;
            playerTwo = 0;
            p1Score.textContent = playerOne.toString();
            p2Score.textContent = playerTwo.toString();
            msg.textContent = currentTurn + "'s Turn";
        }
        else {
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
            "/images/lamp.jpeg", "/images/pen.jpeg", "/images/squares.jpeg", "/images/trebleclef.jpeg",
        ];
        fisherYatesShuffle(pile);
        backImage.push(...pile);
    }
    function fisherYatesShuffle(arr) {
        for (let i = arr.length - 1; i > 0; i--) {
            const j = Math.floor(Math.random() * (i + 1));
            [arr[i], arr[j]] = [arr[j], arr[i]];
        }
    }
})(typescriptgame || (typescriptgame = {}));
//# sourceMappingURL=gametypescript.js.map