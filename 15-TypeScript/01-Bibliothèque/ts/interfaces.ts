export interface Author {
    name: string;
    birthYear: number;
    genres: string[];
}

export interface Book {
    title: string;
    author: Author;
    nbPages: number;
    isAvailable: boolean;
}