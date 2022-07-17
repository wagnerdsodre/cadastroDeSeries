namespace series.src.entities
{
    public class Filmes
    {
        private int id { get; set; }
        private string name{get; set;}
      
        private string category{get; set;}

        private DateTime dia { get; set; }
        private double valor { get; set; }
        private bool excluido { get; set; }   

     public Filmes( int id , string name, string category, DateTime dia, double valor)
        {
        this.id = id;
        this.name = name;
        this.category = category;
        this.dia = dia;
        this.valor = valor;
        this.excluido = false;
    }


     public override String ToString(){
        string retorno = ""+Environment.NewLine;
        retorno += " Name: "+this.name + Environment.NewLine;
        retorno += " Category: "+this.category + Environment.NewLine; 
        retorno += " Dia: "+this.dia + Environment.NewLine;
        retorno += " Valor: "+this.valor + Environment.NewLine;
        retorno += " Status: "+this.excluido + Environment.NewLine;
        return retorno;

    }

    public void Excluir(){
        this.excluido = true;
    }

    public double preco(){
       return valor;
    }

    public string titulo(){
       return name;
    }
    public int Id(int id){
       return this.id;
    }
     public int Id(){
       return this.id;
    }





    }
}