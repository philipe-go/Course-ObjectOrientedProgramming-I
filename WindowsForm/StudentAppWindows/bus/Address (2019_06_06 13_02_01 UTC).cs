namespace StudentAppWindows.bus
{
    public class Address
    {
        private string street, city, province, zip;
       
        public string Street { get => this.street; set => this.street = value; }
        public string City { get => this.city; set => this.city = value; }
        public string Province { get => this.province; set => this.province = value; }
        public string Zip { get => this.zip; set => this.zip = value; }

        public Address()
        {
            this.street = " default ";
            this.city = " default ";
            this.province = " default ";
            this.zip = " default ";
        }
        public Address(string st, string city, string province, string zip)
        {
            this.street = st;
            this.city = city;
            this.province = province;
            this.zip = zip;
        }
        public override string ToString()
        {
            return (this.street+", "+this.city + ", " + this.province + ", " + this.zip);
        }
    }
}
