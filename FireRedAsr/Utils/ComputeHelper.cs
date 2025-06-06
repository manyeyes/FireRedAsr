using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireRedAsr.Utils
{
    internal class ComputeHelper
    {
        public static int ExactDiv(int x, int y)
        {
            Debug.Assert(x % y == 0);
            return x / y;
        }
        public static float[] SoftmaxCompute(float[] values)
        {
            if (values == null || values.Length == 0)
            {
                throw new ArgumentException("Input array must not be null or empty.");
            }
            // Calculate the maximum value in the input array for numerical stability 
            float maxVal = values.Max();
            float sum = 0.0F;
            float[] result = new float[values.Length];
            // Apply the Softmax to each value 
            for (int i = 0; i < values.Length; i++)
            {
                float e = (float)Math.Exp(values[i] - maxVal); // Prevent overflow  
                sum += e;
                result[i] = e;
            }
            // Normalize  
            for (int i = 0; i < values.Length; i++)
            {
                result[i] /= sum;
            }
            return result;
        }

        public static float[] LogCompute(float[] values)
        {
            values = values.Select(x => (float)Math.Log(x)).ToArray();
            return values;
        }

        public static float LogSumExp(float[] arr, int dim = -1)
        {
            // For one-dimensional arrays, dim is always 0 because there's only one dimension.
            // However, to maintain compatibility with higher-dimensional array processing, we accept the dim parameter and validate it.
            if (dim != -1 && dim != 0)
            {
                throw new ArgumentException("dim must be -1 or 0 for a one-dimensional array");
            }
            // Find the maximum value to avoid numerical overflow 
            double maxVal = arr.Max(); 
            // Compute the sum of exp(arr[i] - maxVal)
            double sumExp = arr.Sum(x => Math.Exp(x - maxVal));
            // Compute the final log sum
            double logSumExp = Math.Log(sumExp) + maxVal;
            return (float)logSumExp;
        }

        public static float CompressionRatio(string text)
        {
            float compressionRatio = 0f;
            string originalString = text;
            byte[] originalBytes = Encoding.UTF8.GetBytes(originalString);

            using (var memoryStream = new MemoryStream())
            {
                using (var zlibStream = new ZLibStream(memoryStream, CompressionLevel.Fastest))
                {
                    zlibStream.Write(originalBytes, 0, originalBytes.Length);
                    zlibStream.Flush(); 
                }
                byte[] compressedBytes = memoryStream.ToArray(); // Get the compressed byte array
                compressionRatio = (float)originalBytes.Length / compressedBytes.Length; 
                // If decompression is needed, ZlibStream can be used again with CompressionMode set to Decompress.
            }
            return compressionRatio;
        }
    }
}
