let inventaire = [
    { "nom": "Boules de Noël", "quantite": 50, "prix": 1.5 },
    { "nom": "Guirlandes", "quantite": 30, "prix": 3.0 },
    { "nom": "Sapin de Noël", "quantite": 10, "prix": 25.0 }
]

function afficher_inventaire() {
    let message = "";
    inventaire.forEach(e => {
        message += `Nom: ${e.nom}, Quantité: ${e.quantite}, Prix: ${e.prix}\n`
    });
    alert(message);
}

function ajouter_produit() {
    let nom = prompt("Nom produit:");
    let quantite = prompt("Quantité produit:");
    let prix = prompt("Prix produit:");

    let product = inventaire.find((e) => e.nom == nom);

    if (product == null) {
        inventaire[inventaire.length] = {
            "nom": nom,
            "quantite": quantite,
            "prix": prix
        }
    } else {
        product.prix = prix;
        product.quantite = quantite;
    }
}

function supprimer_produit() {
    let nom = prompt("Nom produit:");

    let product = inventaire.find((e) => e.nom == nom);

    if (product == null) {
        alert("Ce produit n'existe pas !");
    } else {
        let index = inventaire.indexOf(product);
        inventaire.splice(index, 1);
    }
}

function modifier_quantite() {
    let nom = prompt("Nom produit:");

    let product = inventaire.find((e) => e.nom == nom);

    if (product == null) {
        alert("Ce produit n'existe pas !");
    } else {
        let quantite = prompt("Nouvelle quantité:");
        product.quantite = quantite;
    }
}

function rechercher_produit() {
    let nom = prompt("Nom produit:");

    let product = inventaire.find((e) => e.nom == nom);

    if (product == null) {
        alert("Ce produit n'existe pas.");
    } else {
        alert(`Nom: ${product.nom}, Quantité: ${product.quantite}, Prix: ${product.prix}`)
    }
}

function valeur_totale_inventaire() {
    let total = 0;

    inventaire.forEach(e => {
        total += e.quantite * e.prix;
    });

    alert("Valeur totale :" + total + "€")
}

let message = `1.Afficher l’inventaire.\n2.Ajouter un produit.\n3.Supprimer un produit.\n4.Modifier la quantité d’un produit.\n5.Rechercher un produit.\n6.Calculer la valeur totale de l’inventaire.\n7.Quitter le programme.`
let input = 0;

do {
    input = Number(prompt(message));

    switch (input) {
        case 1:
            afficher_inventaire();
            break;
        case 2:
            ajouter_produit();
            break;
        case 3:
            supprimer_produit();
            break;
        case 4:
            modifier_quantite();
            break;
        case 5:
            rechercher_produit();
            break;
        case 6:
            valeur_totale_inventaire();
            break;
        case 7:
            alert("Fermeture du programme");
            break;

        default:
            break;
    }
} while (input > 0 && input < 7);