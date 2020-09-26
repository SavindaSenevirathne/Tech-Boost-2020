namespace Tech_Boost_2020
{
    interface IFileReader<T>
    {
        public abstract T[] Read(string fileName);
    }
}
