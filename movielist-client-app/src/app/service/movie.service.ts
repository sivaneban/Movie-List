import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { IMovie } from '../model/movie';
import { Observable } from 'rxjs';


@Injectable({
    providedIn: 'root'
  })

  export class MovieService {
    url = "https://localhost:5001/movielist"

    constructor(private http:HttpClient) { }
    getMovies(): Observable<IMovie[]>
    {
        return this.http.get<IMovie[]>(this.url);
    } 

  }
