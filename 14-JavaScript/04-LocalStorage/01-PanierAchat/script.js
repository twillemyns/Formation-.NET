let inputPanier = document.getElementById('panier');
let inputItem = document.getElementById('item');
let buttons = inputItem.getElementsByTagName('button');

function addItem() {
    let panier = JSON.parse(localStorage.getItem("panierAchat"));
    console.log(panier);
    let item = inputItem.value;
    panier.push(item);
    localStorage.setItem("panierAchat", JSON.stringify(panier));
    showItems();
}

function removeItem(item) {
    let panier = JSON.parse(localStorage.getItem("panierAchat"));
    console.log(panier);
    let index = panier.indexOf(item.value);
    console.log(index);
    panier.splice(index, 1);
    localStorage.setItem("panierAchat", JSON.stringify(panier));
    showItems();
}

function showItems() {
    inputPanier.innerHTML = '';
    let panier = JSON.parse(localStorage.getItem("panierAchat"));
    console.log(panier)
    panier.forEach((item) => {
        inputPanier.innerHTML +=
            `<li>${item}<button onclick="removeItem(item)">Supprimer l'article</button></li>`;
    })
}