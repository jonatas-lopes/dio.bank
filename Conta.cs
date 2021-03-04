namespace dio.bank
{
    public class Conta
    {
        public TipoConta TipoConta {get; set;}

        public string nome {get; set;}
        public int numero { get; set; }
        public double saldo { get;  set; }
        public double credito {get;  set;}

        public Conta( TipoConta tipoconta, int numero, double saldo, double credito)
        {  
            this.TipoConta = tipoconta;
            this.numero = numero; 
            this.saldo = saldo;
            this.credito = credito;
                     
        }
        
        public bool Sacar(double valor)
        {
            if(this.saldo - valor < (this.credito *-1))
            {
                return false;
            } 
            else
            {
                this.saldo -= valor;
                return true;
            }
            
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Transferir(Conta partida, Conta destino, double valor)
        {
            if(partida.Sacar(valor))
            {
                destino.Depositar(valor);
            }
        }

          public override string ToString()
		{
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.nome + " | ";
            retorno += "Saldo " + this.saldo + " | ";
            retorno += "Crédito " + this.credito;
			return retorno;
		}
    }
}