namespace Factory
{
    /// <summary>
    /// Defines functionalities of a Transportation vehicle used to deliver
    /// goods to the customers.
    /// </summary>
    public interface TransportVehicle
    {
        public void DeliverGoods( string[] goods );

        public string Id
        {
            get;
        }

        public string DestinationPoint
        {
            get;
            set;
        }
    }
}
