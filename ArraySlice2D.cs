namespace fightgrid
{
    public class ArraySlice2D<T>
    {
            private readonly T[,] arr;
            private readonly int dimension1;
            private readonly int length;

            public ArraySlice2D(T[,] arr, int dimension1){
                this.arr = arr;
                this.dimension1 = dimension1;
                this.length = arr.GetUpperBound (1)+1;
            }

            public T this [int index]{
                get {return arr[dimension1, index];}
                set {arr[dimension1, index] = value;}
            }
    }
}