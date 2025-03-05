// DOM => Document Object Model

function myButtonClick(){
    alert("Vous avez un nouveau message !");
}

function onMouseOver(){
    alert("Vous avez survolé le bouton !");
}

function onDoubleClick() {
    alert("Vous avez cliqué 2 fois sur le bouton !")
}

document.addEventListener("keydown", (event) => {
    if (event.key === "Enter"){
        let message = document.querySelector(".inputText");
        alert(message.value);
        message.value = "";
    }
})

document.addEventListener("click", event => {

})