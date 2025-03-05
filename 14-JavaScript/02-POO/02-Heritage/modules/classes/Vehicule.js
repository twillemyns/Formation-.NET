export class Vehicule {

    constructor(brand, model, distance, year) {
        this.brand = brand;
        this.model = model;
        this.distance = distance;
        this.year = year;
    }

    display() {
        return `Marque : ${this.brand}, Modèle : ${this.model}, Distance : ${this.distance} km, Année : ${this.year}`;
    }
}