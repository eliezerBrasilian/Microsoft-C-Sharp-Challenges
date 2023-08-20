namespace Classes
{
    class BankAccount{
        public string ?OwnerName  {get;set;}
        public string ?NumberAccount {get;set;}

        public decimal Balance {get{
            decimal balance = 0;
         foreach (var amount in all_transations)
         {
          balance += amount.amount;  
         }
            return balance;
        }}
        private static int s_numberSeed = 2123;
        private List<Transation> all_transations = new List<Transation>();

        public BankAccount(string? ownerName, decimal initialBalance,DateTime date, string note){
            this.OwnerName = ownerName;
            
            NumberAccount = s_numberSeed.ToString();
            s_numberSeed ++;
            MakeDeposit(initialBalance,date,note);
        }
        public void MakeDeposit(decimal amount,DateTime date, string note){

            if(amount <= 0){
                throw new ArgumentOutOfRangeException(amount.ToString(),"The amount must be 1 or more");
            }
            var transation = new Transation(amount,date,note);
            all_transations.Add(transation);
        }

        public void MakeWithDrawal(decimal amount,DateTime date, string note){
            if(amount > this.Balance){
                throw new ArgumentOutOfRangeException(amount.ToString(),"Insuffitient balance");
            }
            var transation = new Transation(-amount, date,note);
            all_transations.Add(transation);
        }

        public string GetAllTransations(){
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\t\tAmount\tBalance\tNote");
            foreach (var item in all_transations)
            {
                balance += item.amount;
                report.AppendLine($"{item.date.ToString()}\t{item.amount.ToString()}\t{balance.ToString()}\t{item.note}");
            }
            return report.ToString();
        }
    }
}