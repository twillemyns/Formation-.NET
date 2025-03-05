import {Author, Book} from './interfaces.js';
import {Library} from './library.js';
import {createBook} from "./functions.js";

let library = new Library();

let author1: Author = {
    name: "Agatha Christie",
    genres: ["Enquête", "Policier"],
    birthYear: 1929
};

let book1 = createBook("Ils étaient dix", author1, 251);

let author2: Author = {
    name: "J.K. Rowling",
    genres: ["Fantasy"],
    birthYear: 1965
};

let book2 = createBook("Harry Potter à l'école des sorciers", author2, 309);

let author3: Author = {
    name: "George Orwell",
    genres: ["Dystopie", "Science-fiction"],
    birthYear: 1903
};

let book3 = createBook("1984", author3, 328);

let author4: Author = {
    name: "J.R.R. Tolkien",
    genres: ["Fantasy"],
    birthYear: 1892
};

let book4 = createBook("Le Seigneur des Anneaux", author4, 1178);

let author5: Author = {
    name: "Victor Hugo",
    genres: ["Drame", "Historique"],
    birthYear: 1802
};

let book5 = createBook("Les Misérables", author5, 1488);

library.addBook(book1);
library.addBook(book2);
library.addBook(book3);
library.addBook(book4);
library.addBook(book5);