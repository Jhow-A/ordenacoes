namespace Ordenacoes
{
    static class ArrayUtils
    {
        public static void QuickSort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = vetor[inicio];
                int i = inicio + 1;
                int f = fim;
                while (i <= f)
                {
                    if (vetor[i] <= p)
                    {
                        i++;
                    }
                    else if (p < vetor[f])
                    {
                        f--;
                    }
                    else
                    {
                        int troca = vetor[i];
                        vetor[i] = vetor[f];
                        vetor[f] = troca;
                        i++;
                        f--;
                    }
                }

                vetor[inicio] = vetor[f];
                vetor[f] = p;

                QuickSort(vetor, inicio, f - 1);
                QuickSort(vetor, f + 1, fim);
            }
        }

        public static void BuildMaxHeap(int[] v)
        {
            for (int i = (v.Length / 2) - 1; i >= 0; i--)
                MaxHeapify(v, i, v.Length);
        }

        public static void MaxHeapify(int[] v, int pos, int n)
        {
            int max = (2 * pos) + 1, right = max + 1;
            if (max < n)
            {
                if (right < n && v[max] < v[right])
                    max = right;

                if (v[max] > v[pos])
                {
                    Swap(v, max, pos);
                    MaxHeapify(v, max, n);
                }
            }
        }

        public static void Swap(int[] v, int j, int aposJ)
        {
            int aux = v[j];
            v[j] = v[aposJ];
            v[aposJ] = aux;
        }
    }
}
