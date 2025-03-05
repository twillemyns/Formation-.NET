import {Vehicle} from "./classes/vehicle.js";

let listVehicles = [new Vehicle("ag-777-bm", new Date("2025-02-28T15:00:00"))];
let immatriculation = document.getElementById("immatriculation");
let message = document.getElementById("message");
let entry = document.getElementById("entry");
let buyBtn = document.getElementById("buy");

entry.addEventListener("click", enter);
buyBtn.addEventListener("click", buy);

function buy() {
    let vehicle = listVehicles.find((x) => x.immatriculation === immatriculation.value);

    if (!vehicle) {
        message.innerHTML = "<h2>Votre voiture n'est pas enregistrée</h2>"
    } else {
        message.innerHTML = `<h2>Le prix à payer est de ${price(vehicle.entryDate, Date.now())} €</h2>`;
        let index = listVehicles.indexOf(vehicle);
        listVehicles.splice(index, 1);
    }
}

function enter() {
    if (immatriculation.value.length === 0) {
        message.innerHTML = "<h2>Veuillez renseigner votre plaque d'immatriculation</h2>"
    } else {
        listVehicles[listVehicles.length] = new Vehicle(immatriculation.value, new Date());
        message.innerHTML = "<h2>Veuillez prendre votre ticket</h2>";
    }
}

function price(entryDate, exitDate) {
    let time = (exitDate - entryDate) / 1000;
    if (time <= 15 * 60) {
        return "0.80"
    } else if (time <= 30 * 60) {
        return "1.30"
    } else if (time <= 45 * 60) {
        return "1.70"
    } else {
        return "6.00"
    }
}