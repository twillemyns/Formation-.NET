import {Vehicule} from "./Vehicule.js";

export class Moto extends Vehicule {

    display() {
        return "Type: Moto, " + super.display();
    }
}