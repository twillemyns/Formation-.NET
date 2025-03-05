import {Vehicule} from "./Vehicule.js";

export class Voiture extends Vehicule {

    constructor(brand, model, distance, year, options) {
        super(brand, model, distance, year);
        this.options = options;
    }

    display() {
        return "Type: Voiture, " + super.display() + `, Options: ${this.options}`;
    }
}