import {Author, Book} from "./interfaces.js";

export function createBook(title: string, author: Author, nbPages: number): Book {
    return {
        author: author,
        isAvailable: true,
        nbPages: nbPages,
        title: title
    };
}

export function toggleAvailability(book: Book) {
    book.isAvailable = !book.isAvailable;
}