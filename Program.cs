using System;

namespace Ordenacoes
{
    static class Program
    {
        static void Main(string[] args)
        {
            ConsoleUtils.ShowTitle("\n  ORDENAÇÃO POR INSERÇÃO \n");
            InsertionSort();
            ShellSort();

            ConsoleUtils.ShowTitle("\n  ORDENAÇÃO POR SELEÇÃO \n");
            SelectionSort();
            HeapSort();

            ConsoleUtils.ShowTitle("\n  ORDENAÇÃO POR TROCA \n");
            BubbleSort();
            CocktailSort();
            CombSort();
            GnomeSort();
            OddEvenSort();
            QuickSort();

            Console.WriteLine();
        }

        static void QuickSort()
        {
            int[] vetor = { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            ConsoleUtils.ShowTitle("\n\t QUICK SORT");
            ConsoleUtils.ShowArray(vetor);

            int inicio = 0;
            int fim = vetor.Length - 1;
            ArrayUtils.QuickSort(vetor, inicio, fim);

            ConsoleUtils.ShowArray(vetor, true);
        }

        /// <summary>
        /// O Odd-Even Sort é um algoritmo de ordenação por comparação baseado no Bubble Sort
        /// </summary>
        static void OddEvenSort()
        {
            int[] vetor = { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            ConsoleUtils.ShowTitle("\n\t ODD-EVEN SORT");
            ConsoleUtils.ShowArray(vetor);

            bool sorted = false;
            while (!sorted)
            {
                sorted = true;

                // Odd-Even
                for (int x = 1; x < vetor.Length - 1; x += 2)
                {
                    if (vetor[x] > vetor[x + 1])
                    {
                        int tmp = vetor[x];
                        vetor[x] = vetor[x + 1];
                        vetor[x + 1] = tmp;

                        sorted = false;
                    }
                }

                // Even-Odd
                for (int x = 0; x < vetor.Length - 1; x += 2)
                {
                    if (vetor[x] > vetor[x + 1])
                    {
                        int tmp = vetor[x];
                        vetor[x] = vetor[x + 1];
                        vetor[x + 1] = tmp;

                        sorted = false;
                    }
                }
            }

            ConsoleUtils.ShowArray(vetor, true);
        }

        /// <summary>
        /// O Gnome Sort é um algoritmo com uma sequencia grande de trocas como o Bubble Sort, porem ele é similar ao Insertion Sort com a diferença de levar um elemento para sua posição correta.
        /// </summary>
        static void GnomeSort()
        {
            int[] vetor = { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            ConsoleUtils.ShowTitle("\n\t GNOME SORT");
            ConsoleUtils.ShowArray(vetor);

            int p = 0;
            int aux;
            while (p < (vetor.Length - 1))
            {
                if (vetor[p] > vetor[p + 1])
                {
                    aux = vetor[p];
                    vetor[p] = vetor[p + 1];
                    vetor[p + 1] = aux;
                    if (p > 0)
                    {
                        p -= 2;
                    }
                }
                p++;
            }

            ConsoleUtils.ShowArray(vetor, true);
        }

        /// <summary>
        /// O Comb Sort, é um algoritmo de ordenação por troca.
        /// Desenvolvido em 1980 por Wlodzimierz Dobosiewicz e mais tarde, foi redescoberto e popularizado por Stephen Lacey e Richard Box em um artigo publicado na revista Byte em Abril de 1991.
        /// O Comb Sort é uma melhoria do Bubble Sort e rivaliza com o Quick Sort.
        /// </summary>
        static void CombSort()
        {
            int[] vetor = { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            ConsoleUtils.ShowTitle("\n\t COMB SORT");
            ConsoleUtils.ShowArray(vetor);

            int gap = vetor.Length;
            bool swapped = true;
            while (gap > 1 || swapped)
            {
                if (gap > 1)
                    gap = (int)(gap / 1.247330950103979);

                int i = 0;
                swapped = false;
                while (i + gap < vetor.Length)
                {
                    if (vetor[i].CompareTo(vetor[i + gap]) > 0)
                    {
                        int t = vetor[i];
                        vetor[i] = vetor[i + gap];
                        vetor[i + gap] = t;
                        swapped = true;
                    }

                    i++;
                }
            }

            ConsoleUtils.ShowArray(vetor, true);
        }

        /// <summary>
        /// O Cocktail Sort ou Bubble Sort Bidirecional é uma variação do Bubble Sort que se difere pelo fato de ordenar a lista em ambas as direções
        /// </summary>
        static void CocktailSort()
        {
            int[] vetor = { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            ConsoleUtils.ShowTitle("\n\t COCKTAIL SORT");
            ConsoleUtils.ShowArray(vetor);

            int tamanho, inicio, fim, swap, aux;
            tamanho = vetor.Length;
            inicio = 0;
            fim = tamanho - 1;
            swap = 0;
            while (swap == 0 && inicio < fim)
            {
                swap = 1;
                for (int i = inicio; i < fim; i = i + 1)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        swap = 0;
                    }
                }

                fim--;
                for (int i = fim; i > inicio; i = i - 1)
                {
                    if (vetor[i] < vetor[i - 1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i - 1];
                        vetor[i - 1] = aux;
                        swap = 0;
                    }
                }

                inicio++;
            }

            ConsoleUtils.ShowArray(vetor, true);
        }

        /// <summary>
        /// O Bubble Sort é um algoritmo de ordenação mais simples que tem como característica percorrer a vista várias vezes e a cada passagem fazendo flutuar para o topo o maior elemento da sequência
        /// </summary>
        static void BubbleSort()
        {
            int[] vetor = { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            ConsoleUtils.ShowTitle("\t BUBBLE SORT");
            ConsoleUtils.ShowArray(vetor);

            int tamanho = vetor.Length;
            int comparacoes = 0;
            int trocas = 0;
            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                        trocas++;
                    }
                }
            }

            ConsoleUtils.ShowArray(vetor, true);
        }

        /// <summary>
        /// Desenvolvido em 1964 por Robert W. Floyd e J.W.J. Williams, o algoritmo Heap Sort é um método de ordenação por seleção. Esse algoritmo tem esse nome por utiliza uma estrutura de dados chamada heap
        /// </summary>
        static void HeapSort()
        {
            int[] vetor = { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            ConsoleUtils.ShowTitle("\n\t HEAP SORT");
            ConsoleUtils.ShowArray(vetor);

            ArrayUtils.BuildMaxHeap(vetor);
            int n = vetor.Length;

            for (int i = vetor.Length - 1; i > 0; i--)
            {
                ArrayUtils.Swap(vetor, i, 0);
                ArrayUtils.MaxHeapify(vetor, 0, --n);
            }

            ConsoleUtils.ShowArray(vetor, true);
        }

        /// <summary>
        /// O Selection Sort é um método de ordenação por seleção. Ele percorre a lista em busca do menor valor e o move para a posição correta precedido sempre do elemento de menor valor
        /// </summary>
        static void SelectionSort()
        {
            int[] vetor = { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            ConsoleUtils.ShowTitle("\t SELECTION SORT");
            ConsoleUtils.ShowArray(vetor);

            int min, aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++)
                    if (vetor[j] < vetor[min])
                        min = j;

                if (min != i)
                {
                    aux = vetor[min];
                    vetor[min] = vetor[i];
                    vetor[i] = aux;
                }
            }

            ConsoleUtils.ShowArray(vetor, true);
        }

        /// <summary>
        /// É um método de ordenação por inserção criado por Donald Shell que basicamente divide a lista a ser ordenada em grupos menores e aplica o método de ordenação por inserção
        /// </summary>
        static void ShellSort()
        {
            int[] vetor = { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            ConsoleUtils.ShowTitle("\n\t SHELL SORT");
            ConsoleUtils.ShowArray(vetor);

            int h = 1;
            int n = vetor.Length;
            while (h < n)
                h = (h * 3) + 1;

            h /= 3;
            int c, j;
            while (h > 0)
            {
                for (int i = h; i < n; i++)
                {
                    c = vetor[i];
                    j = i;
                    while (j >= h && vetor[j - h] > c)
                    {
                        vetor[j] = vetor[j - h];
                        j -= h;
                    }
                    vetor[j] = c;
                }
                h /= 2;
            }

            ConsoleUtils.ShowArray(vetor, true);
        }


        /// <summary>
        /// O Insertion Sort ou Ordenação por Inserção é um método simples de ordenação que percorre um vetor ordenando os elementos a esquerda a medida que avança
        /// </summary>
        static void InsertionSort()
        {
            int[] vetor = { 12, 34, 98, 890, 1000, 3, 8, 54, 87, 100, 112, 133, 5, 1, 450 };

            ConsoleUtils.ShowTitle("\t INSERTION SORT");
            ConsoleUtils.ShowArray(vetor);

            int i, j, atual;
            for (i = 1; i < vetor.Length; i++)
            {
                atual = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > atual))
                {
                    vetor[j] = vetor[j - 1];
                    j--;
                }

                vetor[j] = atual;
            }

            ConsoleUtils.ShowArray(vetor, true);
        }
    }
}
