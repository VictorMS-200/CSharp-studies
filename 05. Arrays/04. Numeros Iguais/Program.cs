// Criação de arrays

int[] numeros = new int[10] {0,0,1,0,5,5,5,5,6,7};
int[] numerosIguais = new int[10];

// Criação de variaveis
int posicao = 0;
int confirmar = 0;

// Primeira seleção
for (int externo = 0; externo < numeros.Length; externo++) 
{
    // Segunda seleção
    for (int interno = 0; interno < numeros.Length; interno++) 
    {
        // Não comparar o mesmo número (primeira seleção com a segunda)
        // Verifica se os números são iguais
        if (numeros[externo] == numeros[interno] && externo != interno)
        {
            confirmar = 0; // reseta o confirmar para os outros números
            
            // Verifica se já houve mais de uma vez o número repitido
            for (int p = 0; p < posicao; p++) 
            {
                if (numeros[externo] == numerosIguais[p])
                {
                    confirmar++;
                    break;
                }
            }

            // Adiciona o número se ele for repitido, e não tiver já na array numerosIguais
            if (confirmar == 0)
            {
                numerosIguais[posicao] = numeros[externo];
                posicao++;
            }
        }   
    }   
}

// Mostra os números iguais
for (int i = 0; i < posicao; i++)
{
    Console.Write(numerosIguais[i] + " ");
}

/* 
Output

0 5
*/