namespace BusinessEntities
{
    public interface IResource
    {
        //add ui elements for size, color and shape here
        string name { get; }
        int value { get; set; }
    }
}