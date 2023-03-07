
int[] vetA = new int[5];
int[] vetB = new int[5];
int[] vetC = new int[10];

EntradaUsuario();
ConcatenaVets(vetA, vetB);
ImprimeVets(vetA, "Vetor A: ");
ImprimeVets(vetB, "Vetor B: ");
ImprimeVets(vetC, "Vetor C: ");
OrdenarVet(vetC);
ImprimeVets(vetC, "Vetor C em ordem: ");

void EntradaUsuario()
{
    LerVetor(vetA, "Vetor A: "); // Chamada para a função ler vetor; Com a manipulacao do texto
    LerVetor(vetB, "Vetor B: ");
}
void LerVetor(int[] aux, string texto)
{
    Console.WriteLine("Digite os valores do {0}", texto);
    for (int i = 0; i < aux.Length; i++)
    {
        Console.Write("Posição {0}: ", i + 1);
        aux[i] = int.Parse(Console.ReadLine());
    }

}
void ConcatenaVets(int[] vetA, int[] vetB)
{
    vetC = vetA.Concat(vetB).ToArray();
}
void ImprimeVets(int[] aux, string texto)
{
    Console.Write("Os valores do {0}", texto);
    foreach (int i in aux)
    {
        Console.Write("{0}, ", i);
    }
    Console.WriteLine();
}
void OrdenarVet(int[] aux)
{
    int i, j;
    for (i = 0; i < aux.Length - 1; i++)
    {
        for (j = i +1; j < aux.Length; j++)
        {
            if (aux[i] > aux[j])
            {
                int n = aux[i];
                aux[i] = aux[j];
                aux[j] = n;
            }
        }
    }
}