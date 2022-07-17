namespace series.src.entities
{

    using System.Collections.Generic;
    public class locacao :Locar
    {

       public Filmes? filme { get; set; }
       //public double valor { get; set; }  
       public double totalDalocacao { get; set; }  
            
        public void entregando(Filmes f)
        { 
         filmeslocados.Remove(f);       
        }

        
                      
        protected List<Filmes>  filmeslocados = new List<Filmes>();
        public void locando(Filmes f){
         filmeslocados.Add(f); 
         }

          public void total()
        {         
           foreach(var f in filmeslocados )
           {
            totalDalocacao += f.preco();
           }          
             Console.WriteLine("Valor Total do aluguel"+string.Format(" {0:N}",totalDalocacao));
                
        }     
                   
        
         public void msg()
        { 
         foreach(var filme in filmeslocados ){
          Console.WriteLine("Código: "+filme.GetHashCode()+" | "+filme.ToString());
        }          


        }

        

        
    }
 }