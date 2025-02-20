let A = 1;
let B = 2;

console.log("A =", A);
console.log("B =", B);
console.log("Traitement en cours...");

let C = 0;

C = B;
B = A;
A = C;

console.log("A =", A);
console.log("B =", B);