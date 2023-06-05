using Models;
using MyData;

namespace Controllers{
    public class LogisticaController{
        public void Create(DateTime data, int quantidade, string produtoid, string estoqueid){
            if(data == null && quantidade == null && produtoid == null && produtoid.Length == 0 && estoqueid == null && estoqueid.Length == 0){
                throw new Exception("Logistica não identificada.");
            }
            new LogisticaModels(data, quantidade, produtoid, estoqueid);
        }

        public void Update(string idRef, DateTime data, int quantidade, string produtoid, string estoqueid){
            int id = 0;
            try{
                id = int.Parse(idRef);
            } catch (Exception e){
                throw new Exception("Id inválido.");
            }
            LogisticaModels logistica = LogisticaModels.ReadById(id);
            if(logistica == null){
                throw new Exception("Logistica inválida.");
            }
            if(data != null && quantidade != null && produtoid != null && produtoid.Length > 0 && estoqueid != null && estoqueid.Length > 0){
                logistica.Data = data;
                logistica.Quantidade = quantidade;
                logistica.Produtoid = produtoid;
                logistica.Estoqueid = estoqueid;    
            }

            LogisticaModels.Update(logistica);
        }   

        public static List<LogisticaModels> Read(){
            return LogisticaModels.Read();   
        }

        public static LogisticaModels ReadById(int id){
            return LogisticaModels.ReadById(id);
        }
    }
}