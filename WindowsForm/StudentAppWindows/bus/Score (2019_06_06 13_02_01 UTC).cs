namespace StudentAppWindows.bus
{
    public class Score
    {
        private double midterm, project, finalterm;

        public double Midterm
        {
            set => this.midterm = value;
            get => this.midterm;
        }
        public double Project
        {
            set => this.project = value;
            get => this.project;
        }
        public double Finalterm
        {
            set => this.finalterm = value;
            get => this.finalterm;
        }

        public Score()
        {
            this.midterm = 0.00;
            this.project = 0.00;
            this.finalterm = 0.00;
        }
        public Score(double mt, double prj, double ft)
        {
            this.midterm = mt;
            this.project = prj;
            this.finalterm = ft;
        }
        public override string ToString()
        {
            return ("Mid Term: "+this.midterm+" - Project: "+this.project+" - Final Term: "+this.finalterm);
        }

    }
}
