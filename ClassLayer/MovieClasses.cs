﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace MovieClassLayer
{
    public class MovieClasses
    {
        // ------------------------------------------------------------------------------------------------------------------- FILMS
        public class Films : List<Film> 
        {
            //--------------------------------------------------------------------- CONSTRUCTORS
            public Films() { }

            public Films(List<Film> films)
            {
                this.AddRange(films);
            }

            //--------------------------------------------------------------------- METHODS

            //----------------------------------------------------------- FILMS
            public Films GetFilmsFilteredSubset(string filmID, string directorID, string actorID)
            {
                var tmpFilms = this.Where(f => f.FilmID == ((filmID == null) ? f.FilmID : filmID))
                                    .Where(f => f.Directors.Any(p => p.PersonID == ((directorID == null) ? p.PersonID : directorID)))
                                    .Where(f => f.Actors.Any(p => p.PersonID == ((actorID == null) ? p.PersonID : actorID )))
                                    .OrderBy(f => f.FilmName)
                                    .ThenBy(f => f.FilmID)
                                    .ToList();
                return new Films(tmpFilms);
            }

            public List<SimplisticFilm> ToListSimplisticFilm()
            {
                //return this.Select(f => f.GetSimplisticFilm()).OrderBy(f => f.FilmName)
                //                                                .ThenBy(f => f.FilmID)
                //                                                .ToList();

                return this.ToList<SimplisticFilm>().OrderBy(s => s.FilmName)
                                                    .ThenBy(s => s.FilmID)
                                                    .ToList();
            }

            public List<SimplisticFilm> GetDistinctSimplisticFilm(string filmID)
            {
                return this.Select(f => f.GetSimplisticFilm()).Where(f => f.FilmID == filmID)
                                                                .ToList();
            }

            //----------------------------------------------------------- DIRECTORS
            public List<Director> ToListDistinctDirector()
            {
                return this.SelectMany(p => p.Directors, (parent, child) => (Director)(child.GetPerson())).GroupBy(p => p.PersonID)
                                                                                                            .Select(grp => grp.First())
                                                                                                            .OrderBy(p => p.PersonName)
                                                                                                            .ThenBy(p => p.PersonID)
                                                                                                            .ToList();
            }

            public List<Director> GetDistinctDirector(string directorID)
            {
                return this.SelectMany(p => p.Directors, (parent, child) => (Director)(child.GetPerson())).Where(p => p.PersonID == directorID)
                                                                                                            .GroupBy(p => p.PersonID)
                                                                                                            .Select(grp => grp.First())
                                                                                                            .ToList();            
            }

            //----------------------------------------------------------- ACTORS
            public List<Actor> ToListDistinctActor()
            {
                return this.SelectMany(p => p.Actors, (parent, child) => (Actor)(child.GetPerson())).GroupBy(p => p.PersonID)
                                                                                                        .Select(grp => grp.First())
                                                                                                        .OrderBy(p => p.PersonName)
                                                                                                        .ThenBy(p => p.PersonID)
                                                                                                        .ToList();
            }

            public List<Actor> GetDistinctActor(string actorID)
            {
                return this.SelectMany(p => p.Actors, (parent, child) => (Actor)(child.GetPerson())).Where(p => p.PersonID == actorID)
                                                                                                        .GroupBy(p => p.PersonID)
                                                                                                        .Select(grp => grp.First())
                                                                                                        .ToList();
            }
        }

        // ------------------------------------------------------------------------------------------------------------------- FILM
        public class Film : SimplisticFilm
        {
            public string ImdbRating { get; set; }
            public string FilmYear { get; set; }
            public List<Director> Directors { get; set; }
            public List<Actor> Actors { get; set; }

            public Film()
            {
                this.Directors = new List<Director>();
                this.Actors = new List<Actor>();
            }

            //------------------------------------------ CONSTRUCTORS
            public Film(string filmID, string filmName, string imdbRating, string filmYear) : base(filmID, filmName)
            {
                this.ImdbRating = imdbRating;
                this.FilmYear = filmYear;
                this.Directors = new List<Director>();
                this.Actors = new List<Actor>();
            }

            public Film(string filmID, string filmName, string imdbRating, List<Director> directors, List<Actor> actors, string filmYear) : base(filmID, filmName)
            {
                this.ImdbRating = imdbRating;
                this.FilmYear = filmYear;
                this.Directors = directors;
                this.Actors = actors;
            }

            //------------------------------------------ METHODS

            public SimplisticFilm GetSimplisticFilm()
            {
                return (SimplisticFilm)this;
            }
        }

        // ------------------------------------------------------------------------------------------------------------------- SIMPLISTIC FILM
        public class SimplisticFilm
        {
            public string FilmID { get; set; }
            public string FilmName { get; set; }

            //------------------------------------------ CONSTRUCTORS
            public SimplisticFilm() { }
            public SimplisticFilm(string filmID, string filmName)
            {
                this.FilmID = filmID;
                this.FilmName = filmName;
            }

            //------------------------------------------ METHODS

            public bool IsValid()
            {
                //-- valid if has ID and Name
                return (!(string.IsNullOrEmpty(this.FilmID)) && !(string.IsNullOrEmpty(this.FilmName)));
            }
        }

        // ------------------------------------------------------------------------------------------------------------------- DIRECTOR
        public class Director : Person
        {
            //------------------------------------------ CONSTRUCTORS
            public Director() { }
            public Director(string personID, string personName) : base(personID, personName)
            { }
        }

        // ------------------------------------------------------------------------------------------------------------------- ACTOR
        public class Actor : Person
        {
            //------------------------------------------ CONSTRUCTORS
            public Actor() { }
            public Actor(string personID, string personName) : base(personID, personName)
            { }
        }

        // ------------------------------------------------------------------------------------------------------------------- PERSON
        public class Person
        { 
            public string PersonID { get; set; }
            public string PersonName { get; set; }

            //------------------------------------------ CONSTRUCTORS
            public Person() { }
            public Person(string personID, string personName)
            {
                this.PersonID = personID;
                this.PersonName = personName;
            }

            //------------------------------------------ METHODS
            public Person GetPerson()
            {
                return (Person)this;
            }
        }
    }
}
