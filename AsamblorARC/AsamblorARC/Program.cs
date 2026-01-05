using System;
using System.IO;
using System.Runtime.CompilerServices;

public class InfoInstruction
{
    public string OpCode { get; set; }
    public string Op3 { get; set; }
    public string Op2 { get; set; }
    public TipFormat Format { get; set; }

    public InfoInstruction(string op, string op3, TipFormat format, string op2 = null){
        this.OpCode = op;
        this.Op3 = op3;
        this.Format = format;
        this.Op2 = op2;
    }
}
public enum TipFormat
{

    Branch = 2,     
    Aritmetic = 3,  
    Memory = 4    
}

public class Asamblor
{
    private Dictionary<string, InfoInstruction> TableInstructions;

    public Asamblor()
    {
        TableInstructions = new Dictionary<string, InfoInstruction>();
        InitializeInstruction();
    }
    private void InitializeInstruction()
    {
        TableInstructions.Add("addcc", new InfoInstruction("10", "010000", TipFormat.Aritmetic));
    }
    Dictionary<string, int> TabelaSimboluri = new Dictionary<string, int>();
    
    int currentAdress = 0;

    foreach(string line in lines)
        {
        string[] cuvinte = line.Split(' ');
        }
}


