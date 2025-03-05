import {Car} from "./classes/Car.js";

let car1 = new Car("BMW",  "Série 1", 80);
let car2 = new Car("Mercedes",  "GLB", 100);

car1.speedUp();
car1.speedUp();
car1.speedUp();
console.log(car1.speed);

car2.speedUp();
car2.speedUp();
car2.turn();
car2.turn();
console.log(car2.speed);