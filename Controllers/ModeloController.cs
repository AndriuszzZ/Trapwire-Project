using Models;
using MyData;

namespace Controllers{
    public class ModeloController{
        public void Create(string modelo){
            if (modelo == null || modelo.Length == 0) {
                throw new Exception("Nome inválido.");
            }
            new CategoriaModels(modelo);
        }

        public void Update(string idRef, string nome){
            int id = 0;
            try{
                id = int.Parse(idRef);
            } catch(Exception e){
                throw new Exception("ID inválido");
            }
            ModeloModels modelo = ModeloModels.ReadById(id);
            if(modelo == null){
                throw new Exception("Modelo inválido.");
            }
            if(modelo != null){
                modelo.Nome = nome;
            }
            ModeloModels.Update(modelo);
        }

        public static List<ModeloModels> Read(){
            return ModeloModels.Read();
        }

        public static ModeloModels ReadById(int id){
            return ModeloModels.ReadById(id);
        }
    }
}        