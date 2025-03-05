import {Author, Book} from "./interfaces.js";

export class Library {
    books: Book[];

    addBook(book: Book) {
        this.books.push(book);
    }

    removeBook(book: Book) {
        this.books.splice(this.books.indexOf(book), 1);
    }

    findBookByTitle(title: string) {
        return this.books.filter(book => book.title === title)[0];
    }

    listAvailableBooks(books: Book[]) {
        return books.filter(book => book.isAvailable);
    }

    getBooksByAuthor(author: Author) {
        return this.books.filter(book => book.author === author);
    }

}