namespace Factory
{
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
