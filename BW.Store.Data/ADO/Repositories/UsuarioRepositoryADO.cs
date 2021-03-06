﻿using BW.Store.Domain.Contracts.Repositories;
using BW.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BW.Store.Data.ADO.Repositories
{
    public class UsuarioRepositoryADO : IUsuarioRepository
    {
        private readonly BWStoreDataContextADO _ctx;

        public UsuarioRepositoryADO(BWStoreDataContextADO ctx)
        {
            _ctx = ctx;
        }

        public void Add(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {}

        public void Edit(Usuario entity)
        {
            throw new NotImplementedException();
        }
        
        public Usuario Get(string email)
        {
            var query = $@"SELECT 
                        u.Id, u.Nome, u.Email, u.Senha, u.DataCadastro
                        FROM Usuario u
                        WHERE Email = '{email}'";

            var dR = _ctx.ExecuteCommandWithData(query);

            if (dR.HasRows)
            {
                var usuarios = new List<Usuario>();
                
                while (dR.Read())
                {
                    usuarios.Add(new Usuario() 
                    {
                        Id = (int)dR["Id"],
                        Nome = dR["Nome"].ToString(),
                        Email = dR["Email"].ToString(),
                        Senha = dR["Senha"].ToString(),
                        DataCadastro = (DateTime)dR["DataCadastro"]
                    });
                }

                dR.Close();

                return usuarios.First();
            }

            return null;
        }

        public IEnumerable<Usuario> Get()
        {
            throw new NotImplementedException();
        }

        public Usuario Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
