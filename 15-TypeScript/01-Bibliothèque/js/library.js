"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Library = void 0;
var Library = /** @class */ (function () {
    function Library() {
    }
    Library.prototype.addBook = function (book) {
        this.books.push(book);
    };
    Library.prototype.removeBook = function (book) {
        this.books.splice(this.books.indexOf(book), 1);
    };
    Library.prototype.findBookByTitle = function (title) {
        return this.books.filter(function (book) { return book.title === title; })[0];
    };
    Library.prototype.listAvailableBooks = function (books) {
        return books.filter(function (book) { return book.isAvailable; });
    };
    Library.prototype.getBooksByAuthor = function (author) {
        return this.books.filter(function (book) { return book.author === author; });
    };
    return Library;
}());
exports.Library = Library;
