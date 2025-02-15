class Tela {
    public double PedirDouble (string msg){
        Console.WriteLine(msg);
        double nota = Convert.ToDouble(Console.ReadLine());
        return nota;
    }

     public void Exibir(string msg){
        Console.WriteLine(msg);
    }
}