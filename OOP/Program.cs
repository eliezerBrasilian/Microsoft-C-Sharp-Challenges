namespace Classes{
    class Program{
        static void Main(string[] args){
            BankAccount AnaAccount;
            try
            {
                AnaAccount = new BankAccount("Ana",10,DateTime.Now, "opening account"); 
                Console.WriteLine($"The new account was created for {AnaAccount.OwnerName} with {AnaAccount.Balance} your account is {AnaAccount.NumberAccount}");
                AnaAccount.MakeDeposit(50,DateTime.Today,"primeiro depósito");
                AnaAccount.MakeWithDrawal(20,DateTime.Today,"primeira retirada");
                
            }
            catch (Exception)
            {
                throw;
            }
           BankAccount BiaAccount;
           try
           {
             BiaAccount = new BankAccount("Bia",20,DateTime.Now, "opening account");
            Console.WriteLine($"The new account was created for {BiaAccount.OwnerName} with {BiaAccount.Balance} your account is {BiaAccount.NumberAccount}");
        
           }
           catch (System.Exception)
           {
            
            throw;
           }
            Console.WriteLine($"Registro de {AnaAccount.OwnerName}");
            Console.WriteLine(AnaAccount.GetAllTransations());
            
        }
    }
}