namespace ClassFunctions
{
    public static class TestPO
    {
        public static void Merge(int[] mas, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] leftmas = new int[n1];
            int[] rightmas = new int[n2];

            for (int g = 0; g < n1; g++) leftmas[g] = mas[left + g];

            for (int f = 0; f < n2; f++) rightmas[f] = mas[mid + 1 + f];

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (leftmas[i] <= rightmas[j])
                {
                    mas[k] = leftmas[i];
                    i++;
                }
                else
                {
                    mas[k] = rightmas[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                mas[k] = leftmas[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                mas[k] = rightmas[j];
                j++;
                k++;
            }
        }

        public static void MergeSort(int[] mas, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(mas, left, mid);
                MergeSort(mas, mid+1, right);
                Merge(mas, left, mid, right);
            }
        }
    }
}