// function plus_grand_que(A, B) {
//     return Math.max(A, B);
// }

// let A = prompt("Nombre 1: ");
// let B = prompt("Nombre 2: ");

// alert("Nombre le plus grand: " + plus_grand_que(A, B));

// let tableau = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// alert(tableau[8]);

// let tableau = [];

// for (let i = 0; i < 15; i++) {
//     let nombre = prompt("Nombre: ");
//     tableau.push(nombre);
// }

// alert(tableau);

let tableau = [];

for (let i = 0; i < 15; i++) {
    let note1 = prompt("Maths: ");
    let note2 = prompt("Histoire: ");
    let note3 = prompt("Musique: ");

    tableau.push([note1, note2, note3]);
}