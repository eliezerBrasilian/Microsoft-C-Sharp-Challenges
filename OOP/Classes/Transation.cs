namespace Classes{
     class Transation{
        public decimal amount;
        public DateTime date;
        public string ?note;

        public Transation(decimal amount,DateTime date,string note){
            this.amount = amount;
            this.date = date;
            this.note = note;
        }
    }
}