export interface IMovie{
    title : string,
    year  : string,
    poster: string,
    director:string,
    plot: string, 
    imdbID: string,
    ratings: IRating[]
}

export interface IRating{
    source:string,
    value:string
}