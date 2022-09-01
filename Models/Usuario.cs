using System.Collections.Generic;
using System.Linq;

namespace USANDOVIEWS.Models{

    public class Usuario{
        public int Id {get;set;}

        public string Nome {get;set;}

        public string Email {get;set;}

        private static List<Usuario> listagem = new List<Usuario>();

        public static IQueryable<Usuario> Listagem{
            
            get{
                return listagem.AsQueryable();
            }
            
        }

        static Usuario(){
            Usuario.listagem.Add(
                new Usuario {Id = 1, Nome = "Fulano", Email = "fulano@gmail.com"}
            );
            Usuario.listagem.Add(
                new Usuario {Id = 2, Nome = "Sicrano", Email = "sicrano@gmail.com"}
            );
            Usuario.listagem.Add(
                new Usuario {Id = 3, Nome = "Beltrano", Email = "beltrano@gmail.com"}
            );
            Usuario.listagem.Add(
                new Usuario {Id = 4, Nome = "Jão", Email = "Jao@gmail.com"}
            );
            Usuario.listagem.Add(
                new Usuario {Id = 5, Nome = "Maria", Email = "maria@gmail.com"}
            );
        }

        public static void Salvar(Usuario usuario)
        {
            var usuarioExistente = Usuario.listagem.Find(u => u.Id == usuario.Id );
            if (usuarioExistente != null){
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Email = usuario.Email;
            } 
            else{
                int maiorId = Usuario.Listagem.Max(u => u.Id);
                usuario.Id = maiorId + 1;
                Usuario.listagem.Add(usuario);
            }
        }

         public static void Excluir(int id)
        {
            var usuarioExistente = Usuario.listagem.Find(u => u.Id == id);
            if (usuarioExistente != null){
                Usuario.listagem.Remove(usuarioExistente);
            }
        }



    }
}