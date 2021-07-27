using MVCrelations.Context;
using MVCrelations.Models;
using System;


namespace MVCrelations.Repository
{
    public class UnitOfWork
    {
        public Db _db;
        public UnitOfWork(Db db) => _db = db;

        public Repository<Country> CountryRepository() =>
                new Repository<Country>(_db);

       // public Repository<Post> PostRepository() =>
         //       new Repository<Post>(_db);
    }
}

