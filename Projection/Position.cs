namespace Projection
{
    public class Position
    {
        public Position(int lon, int lat)
        {
            this.Longitude = lon;
            this.Latitude = lat;
        }

        public double Longitude
        {
            get;
            set;
        }

        public double Latitude
        {
            get;
            set;
        }

    }
}