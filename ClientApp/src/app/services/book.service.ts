import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Book } from '../interfaces/book';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  private _baseURL: string = "https://localhost:44305/api/Books";

  constructor(private http: HttpClient) { }

  public getAllBooks() {
    return this.http.get<Book[]>(this._baseURL+"/GetBooks")
  }

  public addBook(book: Book) {
    return this.http.post(this._baseURL + "/AddBook/", book);
  }

  public getBookById(id: number) {
    return this.http.get<Book>(this._baseURL + "/SingleBook/" + id);
  }

}
