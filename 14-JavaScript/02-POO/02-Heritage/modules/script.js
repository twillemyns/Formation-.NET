import {Voiture} from "./classes/Voiture.js";
import {Moto} from "./classes/Moto.js";

let vehicules = [new Voiture("Renault", "Kangoo", 240000, 2003, "Climatisée"), new Moto("BMW", "R1150R Rockster", 65000, 2005)];
let liste = document.getElementById("vehicles");

vehicules.forEach(vehicule => {
    liste.innerHTML += `<li>${vehicule.display()}</li>`;
})