namespace fightgrid
{
    public static class ArraySliceExt
    {
         public static ArraySlice2D<T> Slice<T>(this T[,] arr, int dimension1){
                return new ArraySlice2D<T> (arr, dimension1);
            }
    }
}