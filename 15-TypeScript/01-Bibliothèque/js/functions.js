"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.createBook = createBook;
exports.toggleAvailability = toggleAvailability;
function createBook(title, author, nbPages) {
    return {
        author: author,
        isAvailable: true,
        nbPages: nbPages,
        title: title
    };
}
function toggleAvailability(book) {
    book.isAvailable = !book.isAvailable;
}
