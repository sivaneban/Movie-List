import { Component, OnInit } from '@angular/core';
import { IMovie } from '../model/movie';
import {MovieService} from '../service/movie.service';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {

  movies:IMovie[]


  constructor(private movieService :MovieService) { }

  ngOnInit() {
    this.movieService.getMovies().subscribe((result)=>{  
      this.movies = result
    });
  }

}
