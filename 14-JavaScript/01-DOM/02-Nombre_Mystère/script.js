window.onload = () => {
    mystery = Math.floor(Math.random() * 50);
}

document.addEventListener("keydown", (event) => {
    if (event.key === "Enter"){
        checkNumber();
    }
})

let mystery;
let input = document.getElementById("number");
let message = "";
let pMessage = document.getElementById("message");
let nbTries = 0;

function checkNumber() {
    let result = parseInt(input.value);
    if (result < mystery) {
        message = "Le nombre est plus grand.";
    } else if (result > mystery) {
        message = "Le nombre est plus petit.";
    }else if (result === mystery){
        message = "Gagné !!";
    }

    nbTries++;
    pMessage.innerText = message + ` Nombre d'essais : ${nbTries}`;
}