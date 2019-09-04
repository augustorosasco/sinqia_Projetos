using DesenvolvimentoWeb.Vendas.Models;
using DesenvolvimentoWeb.Vendas.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesenvolvimentoWeb.Vendas.Data
{
    public class UsuariosDao
    {
        public static void IncluirUsuario(Usuario usuario)
        {
            using (var context = new VendasEntities()) 
            {
                //Alterando a senha do usuario para MD5 
                usuario.Senha = utilitarios.GetMd5Hash(usuario.Senha); 

                context.Usuarios.Add(usuario);
                context.SaveChanges(); 
            } 
        }

        public static Usuario ValidarUsuario(string nome, string senha)
        { 
            using(var context = new VendasEntities()) 
            {
                var senhaMD5 = utilitarios.GetMd5Hash(senha);
                 
                return context
                    .Usuarios
                    .FirstOrDefault(p => p.Nome == nome && p.Senha == senhaMD5);
            }
        }
    }
}