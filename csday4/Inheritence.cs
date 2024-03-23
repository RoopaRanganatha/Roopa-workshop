using System;
using System.Collections.Generic;
using csday4;
class BankAccount
{
    private int AccountNo;
    public string Name;
    protected decimal Balance=0;
    protected decimal InterestRate=0;
    protected decimal Interest=0;

public void Add(int accountNo, string name)
{
    this.AccountNo=accountNo;
    this.Name=name;
}

    public void Deposit(int amount){
        this.Balance+=amount;
    }
    public void Withdraw(int amount){
        if (Balance>amount)        
        this.Balance-=amount;
        else
        Console.WriteLine("Balance is low");
    }

    public virtual decimal CalculateInterest(){
        return 0;
    }

}

class SavingAccount:BankAccount{
public override decimal CalculateInterest(){
    this.InterestRate=5.5M;    
    decimal interest = (Balance*InterestRate/100);
    return interest;
}
}

class CurrentAccount : BankAccount{

}

public class Inheritence
{
    public static void Main(){
        SavingAccount savingAccount= new SavingAccount();
        savingAccount.Add(100, "Roopa");
        savingAccount.Deposit(1000);
        decimal interest = savingAccount.CalculateInterest();
        Console.WriteLine($"Interest:{interest}");
    }
}