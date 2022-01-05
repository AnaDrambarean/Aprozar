using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Aprozar.Models;

namespace Aprozar.Data
{
    public class AprozarDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public AprozarDatabase(string dbPath) 
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<CosCumparaturi>().Wait();
            _database.CreateTableAsync<Client>().Wait();
            _database.CreateTableAsync<Categorie>().Wait();
            _database.CreateTableAsync<Produs>().Wait();
            _database.CreateTableAsync<Furnizor>().Wait();
            _database.CreateTableAsync<Comanda>().Wait();
        }
        public Task<List<CosCumparaturi>> GetCosCumparaturiAsync()
        {
            return _database.Table<CosCumparaturi>().ToListAsync();
        }
        public Task<List<Client>> GetClientAsync()
        {
            return _database.Table<Client>().ToListAsync();
        }
        public Task<List<Categorie>> GetCategorieAsync()
        {
            return _database.Table<Categorie>().ToListAsync();
        }
        public Task<List<Produs>> GetProdusAsync()
        {
            return _database.Table<Produs>().ToListAsync();
        }
        public Task<List<Furnizor>> GetFunizorAsync()
        {
            return _database.Table<Furnizor>().ToListAsync();
        }
        public Task<List<Comanda>> GetComandaAsync()
        { 
            return _database.Table<Comanda>().ToListAsync();
        }
        public Task<CosCumparaturi> GetCosCumparaturiAsync(int id)
        {
            return _database.Table<CosCumparaturi>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }
        public Task<Client> GetClientAsync(int id)
        {
            return _database.Table<Client>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }
        public Task<Categorie> GetCategorieAsync(int id)
        {
            return _database.Table<Categorie>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }
        public Task<Produs> GetProdusAsync(int id)
        {
            return _database.Table<Produs>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }
        public Task<Furnizor> GetFurnizorAsync(int id)
        {
            return _database.Table<Furnizor>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }
        public Task<Comanda> GetComandaAsync(int id)
        {
            return _database.Table<Comanda>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }
        public Task<int> SaveCosCumparaturiAsync(CosCumparaturi clist)
        {
            if (clist.ID != 0)
            {
                return _database.UpdateAsync(clist);
            }
            else
            {
                return _database.InsertAsync(clist);
            }
        }
        public Task<int> SaveClientAsync(Client clist)
        {
            if (clist.ID != 0)
            {
                return _database.UpdateAsync(clist);
            }
            else
            {
                return _database.InsertAsync(clist);
            }
        }
        public Task<int> SaveCategorieAsync(Categorie clist)
        {
            if (clist.ID != 0)
            {
                return _database.UpdateAsync(clist);
            }
            else
            {
                return _database.InsertAsync(clist);
            }
        }
        public Task<int> SaveProdusAsync(Produs clist)
        {
            if (clist.ID != 0)
            {
                return _database.UpdateAsync(clist);
            }
            else
            {
                return _database.InsertAsync(clist);
            }
        }
        public Task<int> SaveFurnizorAsync(Furnizor clist)
        {
            if (clist.ID != 0)
            {
                return _database.UpdateAsync(clist);
            }
            else
            {
                return _database.InsertAsync(clist);
            }
        }
        public Task<int> SaveComandaAsync(Comanda clist)
        {
            if (clist.ID != 0)
            {
                return _database.UpdateAsync(clist);
            }
            else
            {
                return _database.InsertAsync(clist);
            }
        }

        public Task<int> DeleteCosCumparaturiAsync(CosCumparaturi clist)
        {
            return _database.DeleteAsync(clist);
        }
        public Task<int> DeleteClientAsync(Client clist)
        {
            return _database.DeleteAsync(clist);
        }
        public Task<int> DeleteCategorieAsync(Categorie clist)
        {
            return _database.DeleteAsync(clist);
        }
        public Task<int> DeleteProdusAsync(Produs clist)
        {
            return _database.DeleteAsync(clist);
        }
        public Task<int> DeleteFurnizorAsync(Furnizor clist)
        {
            return _database.DeleteAsync(clist);
        }
        public Task<int> DeleteComandaAsync(Comanda clist)
        {
            return _database.DeleteAsync(clist);
        }
    }
}
