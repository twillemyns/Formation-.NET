export class Car {
    constructor(brand, model, speed) {
        this.brand = brand;
        this.model = model;
        this.speed = speed;
    }

    speedUp(){
        this.speed += 10;
    }

    turn(){
        this.speed -= 5;
    }
}