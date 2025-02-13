int [,] campo = new int [10,10];
int [,] jogador = new int [10,10];

int qtdLinhas = campo.GetLength(0);
int qtdColunas = campo.GetLength(1);

bool fileError = false;
string absolutPath = "C:\\VSCodeProjects\\CSHARPProjetosSenac\\CampoMinado\\Campo.txt";
//string ralativePath = "..\\..\\..\\..\\Campo.txt";

try {
    StreamReader sr = new StreamReader(absolutPath);
    string linhas_file = sr.ReadLine();
    int linhas_mtz = 0;
    int colunas_mtz = 0;

    while (linhas_file != null || linhas_mtz <10) {
        foreach (var numero in linhas_file.Split(',')){
            int num; 
            
            if (int.TryParse(numero, out num)) {
                campo[linhas_mtz, colunas_mtz] = num;
                jogador[linhas_mtz, colunas_mtz] = -1;
                colunas_mtz++;
            }
        }
    linhas_file = sr.ReadLine();
    colunas_mtz = 0;
    linhas_mtz++;
    }
    sr.Close();
 }
 catch (Exception e) {
    Console.WriteLine("Ocorreu um problema na leitura do arquivo!!");
    fileError = true;
 }

 if (!fileError){
    bool fimJogo = false;
    bool vitoria = false;
    
        do{
            for (int l = 0; l < qtdLinhas; l++){
                for (int c = 0; c < qtdColunas; c++) {
                    Console.WriteLine(string.Format("{0}", jogador[l,c]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            Console.Write("Selecione uma linha [1-10]:");
            int linha = Convert.ToInt32(Console.ReadLine()) -1;
            Console.Write("Selecione uma coluna [1-10]:");
            int coluna = Convert.ToInt32(Console.ReadLine()) -1;
            
            switch (campo [linha, coluna]) {
                case 0: 
                    jogador [linha, coluna] = 0;
                    Console.Write("Continue tentando. \n\n");
                    break;
                case 1: 
                    jogador [linha, coluna] = 1;
                    Console.Write("BOOOM! Você perdeu. \n\n");
                    fimJogo = true;
                    break;
                default: 
                    jogador[linha, coluna] = 2;
                    Console.Write("Parabéns. Você ganhou!\n\n");
                    fimJogo = true;
                    vitoria = true;
                    break;
            }
        } while (!fimJogo);

    string [] file = File.ReadAllLines(absolutPath);
     string msgVitorias = file[file.Length -2];
     string msgDerrota = file[file.Length -1];

    try {
        StreamWriter sw = new StreamWriter (absolutPath);
        int cont; 
        int linha_sobrescrever;
        string txt;

        if (vitoria){
            int.TryParse(msgVitorias.Split(':')[1], out cont);
            linha_sobrescrever = 11;
            txt = "Vitórias:";
        } else {
            int.TryParse(msgDerrota.Split(':')[1], out cont);
            linha_sobrescrever = 12;
            txt = "Derrotas:";
        }
        
        cont++;

        for (int i = 0; i < file.Length; i++) {
            if (i == linha_sobrescrever)
                sw.WriteLine (txt + cont);
            else
                sw.WriteLine(file[i]);
        }

        sw.Close();
    }
    catch (Exception e){
    Console.WriteLine("Ocorreu um erro na escrita do arquivo!");
    }
 }