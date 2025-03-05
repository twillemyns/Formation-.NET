"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var library_js_1 = require("./library.js");
var functions_js_1 = require("./functions.js");
var library = new library_js_1.Library();
var author1 = {
    name: "Agatha Christie",
    genres: ["Enquête", "Policier"],
    birthYear: 1929
};
var book1 = (0, functions_js_1.createBook)("Ils étaient dix", author1, 251);
var author2 = {
    name: "J.K. Rowling",
    genres: ["Fantasy"],
    birthYear: 1965
};
var book2 = (0, functions_js_1.createBook)("Harry Potter à l'école des sorciers", author2, 309);
var author3 = {
    name: "George Orwell",
    genres: ["Dystopie", "Science-fiction"],
    birthYear: 1903
};
var book3 = (0, functions_js_1.createBook)("1984", author3, 328);
var author4 = {
    name: "J.R.R. Tolkien",
    genres: ["Fantasy"],
    birthYear: 1892
};
var book4 = (0, functions_js_1.createBook)("Le Seigneur des Anneaux", author4, 1178);
var author5 = {
    name: "Victor Hugo",
    genres: ["Drame", "Historique"],
    birthYear: 1802
};
var book5 = (0, functions_js_1.createBook)("Les Misérables", author5, 1488);
library.addBook(book1);
library.addBook(book2);
library.addBook(book3);
library.addBook(book4);
library.addBook(book5);
