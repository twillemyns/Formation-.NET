// let i = 0;
// let sum = 0;

// while (sum <= 100) {
//     sum += i;
//     i++;
// }

// alert("Valeur : " + i +"\nSomme : " + sum);

// let i = 0;

// while (i <1 || i > 3){
//     i = prompt("Entrez un nombre entre 1 et 3:");
// }


// let c = prompt("Capital:");
// let t = prompt("Taux en %:")/100;
// let n = 1;

// let Cn = 0

// while(Cn <= 2*c){
//     Cn = c*Math.pow((1+t), n);
//     n++;
// }

// alert("Le capital aura doublé dans " + n + " années.")

// let somme = 0;

// for (let i = 0; i <= 10; i++) {
//     somme += i;
// }

// alert("Somme : " + somme)

// let nombre = 0;

// do {
//     nombre = prompt("Valeur entre 1 et 3");
// } while (nombre < 1 || nombre > 3);

// let input;
// let max = 0;

// for (let i = 0; i < 6; i++) {
//     input = prompt("Entrez un nombre:");
//     if (input > max) {
//         max = input;
//     }
// }
// alert("Le nombre le plus grand est : " + max)

// for (let i = 0; i < 11; i++) {
//     alert("9*"+i+"="+9*i)    
// }

// let input = prompt("Entrez un nombre");
// let sum = 0

// for (let i = 1; i <= input; i++) {
//     sum += i;
// }

// alert("Résultat: " + sum);

// let message = "";

// for (let i = 1; i < 11; i++) {
//     message += "Table de " + i + " :\n\n";
//     for(let j = 1; j < 11; j++){
//         message += `${i} x ${j} = ${i*j}\n`;
//     }
//     alert(message);
//     message = "";
// }

// let hab = 96809;
// let années = 0;

// while (hab < 120000){
//     hab += (0.89/100) * hab;
//     années++;
// }

// alert("Nombre d'années :" + années)

// let min = 20;
// let max = 0;
// let somme = 0;

// for (let i = 0; i < 20; i++) {
//     let note = Number(prompt("Note n° " + (i + 1)));

//     if (note > max) {
//         max = note;
//     } else if (note < min) {
//         min = note;
//     }
//     somme += note;
// }

// let moyenne = somme/20;

// alert("Min:" + min +"\nMax: " + max + "\nMoyenne: " + moyenne);

let input = prompt("Nombre:");
let message = ""

for (let i = 1; i <= input; i++) {
    for (let j = 1; j <= i; j++) {
        message += j + " "
    }
    message += "\n";
}

console.log(message);