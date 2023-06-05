using System.ComponentModel.DataAnnotations.Schema;
using MyData;

namespace Models{
    public class ModeloModels{
        [Column("ID Modelo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("Modelo: ")]
        public string Nome { get; set;}

        public ModeloModels(string nome){
            this.Nome = nome;

            this.Create(this);
        }

        public ModeloModels(){}

        public void Create(ModeloModels modelo){
            using (var context = new Context()){
                context.Modelos.Add(modelo);
                context.SaveChanges();
            }
        }

        public static ModeloModels Update(ModeloModels modelo){
            using(var context = new Context()) {
                context.Modelos.Update(modelo);
                context.SaveChanges();

                return modelo;
            }
        }

        public static List<ModeloModels> Read(){
            using (var context = new Context()){
                return context.Modelos.ToList();
            }
        }
        public static ModeloModels ReadById(int id){
            using (var context = new Context()){
                var modelo = context.Modelos.Find(id);
                return modelo;
            }   
        }  
    } 
}       