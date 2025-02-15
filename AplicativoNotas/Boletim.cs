class Boletim {

    public Resultado Calcular(NotasAluno notas){
        Resultado res = new Resultado();
        res.Media = Media(notas);
        res.Situação = Situação(res.Media);
        return res; 

    }
      private string Situação (double media){
        string sit = "";
        
        if (media >= 6 )

            sit = "aprovado";
        else {
            sit = "reprovado";
        }

        return sit;
    }

    private double Media (NotasAluno notas){
        double m =  notas.Nota1 + notas.Nota2 + notas.Nota3 / 3;
        return m;

    }

}
