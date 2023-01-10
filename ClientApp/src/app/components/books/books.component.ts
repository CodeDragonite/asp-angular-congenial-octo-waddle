import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BookService } from '../../services/book.service';
import { Book } from './../../interfaces/book';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {

  public books!: Book[];

  constructor(private service: BookService, private router: Router) { }

  ngOnInit(): void {
    this.service.getAllBooks().subscribe(data => {
      this.books = data;
    });
  }

  showBook(id: number): void {
    this.router.navigate(["/show-book/"+id ])
  }

}
