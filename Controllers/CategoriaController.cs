using Models;
using MyData;

namespace Controllers{
    public class CategoriaController{
        public static void Create(string Nome){
            if (Nome == null || Nome.Length == 0) {
                throw new Exception("Nome inválido.");
            }
            new CategoriaModels(Nome);
        }

        public static void Update(string idRef, string Nome){
            int id = 0;
            try {
                id = int.Parse(idRef);
            } catch (Exception e) {
                throw new Exception("Id inválido");
            }
            CategoriaModels categoria = CategoriaModels.ReadById(id);
            if (categoria == null) {
                throw new Exception("Categoria inválido.");
            }

            if (Nome != null && Nome.Length > 0) {
                categoria.Nome = Nome;
            }

            CategoriaModels.Update(categoria);
        }
        
        public static void Delete(string idRef){
            int id = 0;
            try{
                id = int.Parse(idRef);
            } catch (Exception e) {
                throw new Exception("ID inválido");
            }
            CategoriaModels categoria = CategoriaModels.ReadById(id);
            if(categoria != null){
                throw new Exception("Categoria inválida");
            }
            
            CategoriaModels.Delete(categoria);
        }

        public static List<CategoriaModels> Read(){
            return CategoriaModels.Read();
        }

        public static CategoriaModels ReadById(int id){
            return CategoriaModels.ReadById(id);
        }
    }
}        