namespace InterfaceSegregationPrinciple.Classes
{
    public class ComprovanteCredito : Comprovante
    {
        public int Parcelas { get; set; }

        public ComprovanteCredito(int parcelas, string descricao, string valor, TipoPagamento tipoPagamento) 
            
            : base(descricao, valor, tipoPagamento)
        {
            this.Parcelas = parcelas;
        }
    }
}
