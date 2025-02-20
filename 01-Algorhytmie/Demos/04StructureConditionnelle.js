// Demo
// let age = 0;

// if (age > 0) {
//     if (age > 18) {
//         console.log("MAJEUR");
//     } else {
//         console.log("MINEUR");
//     }
// } else {
//     console.log("L'age doit être positif");
// }

// if (age > 10) {

// } else if (age > 15) {

// } else if (age > 18) {

// } else {

// }

// switch (age) {
//     case 10:
//         break;
//     case 15:
//         break;
//     case 18:
//         break;
//     default:
//         break;
// }

// Ex 1
// let nb = prompt("Nombre de copies :");

// let price = 0;

// switch (nb) {
//     case nb < 10:
//         price = 0.5;
//         break;
//     case nb >=10 & nb < 20:
//         price = 0.4;
//     default:
//         price = 0.3;
//         break;
// }

// console.log("Le prix de l'impression est de " + nb*price);

// Ex 2
// let c = prompt("Capital :")
// let t = prompt("Taux :") / 100
// let n = prompt("Nombre d'années :")

// let Cn = c * Math.pow((1+t),n)

// console.log("Le placement aura gagné :" + (Cn - c) + "Euros")

// Ex 3
// let age = prompt("Age de l'enfant :");
// let category = "";

// if ( age >=13 ){
//     category = "Cadet";
// } else if ( age >= 11) {
//     category = "Minime";
// } else if ( age >= 9 ) {
//     category = "Pupille";
// } else if ( age >= 7 ) {
//     category = "Poussin";
// } else if (age >= 3 ) {
//     category = "Baby";
// } else {
//     console.log("L'enfant ne peut pas s'inscrire");
// }

// if (age >= 3) {
//     console.log("Catégorie: " + category);
// }

// Ex 4
// let AB = prompt("Longueur AB :");
// let BC = prompt("Longueur BC :");
// let CA = prompt("Longueur CA :");

// if (AB == BC && BC == CA){
//     console.log("Triangle équilatéral")
// }else{
//     if(AB == BC){
//         console.log("Triangle isocèle en B")
//     }else if(AB == CA) {
//         console.log("Triangle isocèle en A")
//     }else if (BC == CA) {
//         console.log("Triangle isocèle en C")
//     }else{
//         console.log("Triangle quelconque")
//     }
// }

// Ex 5
let taille = prompt("Taille:");
let poids = prompt("Poids:");

if (taille <= 157) {
    if (poids <= 65){
        alert("1");
    }else{
        alert("pas de taille dispo")
    }
}else if(taille == 160){
    if (poids >= 72){
        alert("Pas de taille dispo")
    }else if (poids >= 66){
        alert("2")
    }else {
        alert("1")
    }
}else if(taille == 163){
    if (poids >= 72){
        alert("3");
    }else if (poids >= 60){
        alert("2");
    }else {
        alert("1");
    }
}else if(taille == 166){
    if (poids >= 72){
        alert("3");
    }else if (poids >= 54){
        alert("2");
    }else {
        alert("1");
    }
}else if(taille == 169){
    if (poids >= 72){
        alert("3");
    }else if (poids >= 48){
        alert("2");
    }else {
        alert("1");
    }
}else if(taille == 172){
    if (poids >= 66){
        alert("3");
    }else if (poids >= 48){
        alert("2");
    }else {
        alert("pas de taille dispo");
    }
}else if(taille == 175){
    if (poids >= 60){
        alert("3");
    }else if (poids >= 48){
        alert("2");
    }else {
        alert("pas de taille dispo");
    }
}else if(taille == 178){
    if (poids >= 54){
        alert("3");
    }else if (poids >= 48){
        alert("2");
    }else {
        alert("pas de taille dispo");
    }
}else if(taille == 183){
    if (poids > 54){
        alert("3");
    }else{
        alert("pas de taille dispo")
    }
}